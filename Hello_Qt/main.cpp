#include <QApplication>
#include <QPushButton>
#include <QDebug>
#include <QSpinBox>
#include <QSlider>
#include <QHBoxLayout>

int main(int argc, char* argv[])
{
	QApplication app(argc, argv);
	QWidget window;
	window.setWindowTitle("clicked");
	QSpinBox* spinBox = new QSpinBox(&window);
	QSlider* slider = new QSlider(Qt::Horizontal, &window);
	//�½�С����
	//QSpinBox �� QSlider��QSpinBox ����ֻ���������ֵ�����򣬲��Ҵ������¼�ͷ�Ĳ�����ť��QSlider ���Ǵ��л���Ļ���
	spinBox->setRange(0, 130);
	slider->setRange(0, 130);
	QObject::connect(slider, &QSlider::valueChanged, spinBox, &QSpinBox::setValue);
	//������ʹ�� &QSpinBox::valueChanged ȡ����ָ��ʱ����������֪��Ӧ��ȡ��һ������
	void (QSpinBox:: * spinBoxSignal)(int) = &QSpinBox::valueChanged;
	//���Ǵ���һ������ָ�룬�������ָ�����ָ��Ϊ int
	QObject::connect(spinBox, spinBoxSignal, slider, &QSlider::setValue);
	
	spinBox->setValue(35);
	QHBoxLayout* layout = new QHBoxLayout;
	//QHBoxLayout ������Ȼ�������һ�����ֹ�����
	layout->addWidget(spinBox);
	layout->addWidget(slider);

	QPushButton* button1=new QPushButton("Quit", &window);
	QObject::connect(button1, &QPushButton::clicked, &QApplication::quit);
	//����������õ���ʽ��connect() һ���ʹ��ǰ���ĸ���������һ���Ƿ����źŵĶ��󣬵ڶ����Ƿ��Ͷ��󷢳����źţ��������ǽ����źŵĶ��󣬵��ĸ��ǽ��ն����ڽ��յ��ź�֮������Ҫ
	//���õĺ�����Ҳ����˵���� sender ������ signal �ź�֮�󣬻��Զ����� receiver �� slot ����

	QPushButton* button2=new QPushButton("cliked",&window);
	QObject::connect(button2, &QPushButton::clicked, [](bool) {
		qDebug() << "You clicked me!"; });
	layout->addWidget(button1);
	layout->addWidget(button2);
	window.setLayout(layout);
	window.show();
	return app.exec();
}

