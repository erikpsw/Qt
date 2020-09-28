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
	//新建小部件
	//QSpinBox 和 QSlider。QSpinBox 就是只能输入数字的输入框，并且带有上下箭头的步进按钮。QSlider 则是带有滑块的滑竿
	spinBox->setRange(0, 130);
	slider->setRange(0, 130);
	QObject::connect(slider, &QSlider::valueChanged, spinBox, &QSpinBox::setValue);
	//当我们使用 &QSpinBox::valueChanged 取函数指针时，编译器不知道应该取哪一个函数
	void (QSpinBox:: * spinBoxSignal)(int) = &QSpinBox::valueChanged;
	//我们创建一个函数指针，这个函数指针参数指定为 int
	QObject::connect(spinBox, spinBoxSignal, slider, &QSlider::setValue);
	
	spinBox->setValue(35);
	QHBoxLayout* layout = new QHBoxLayout;
	//QHBoxLayout 对象。显然，这就是一个布局管理器
	layout->addWidget(spinBox);
	layout->addWidget(slider);

	QPushButton* button1=new QPushButton("Quit", &window);
	QObject::connect(button1, &QPushButton::clicked, &QApplication::quit);
	//这是我们最常用的形式。connect() 一般会使用前面四个参数，第一个是发出信号的对象，第二个是发送对象发出的信号，第三个是接收信号的对象，第四个是接收对象在接收到信号之后所需要
	//调用的函数。也就是说，当 sender 发出了 signal 信号之后，会自动调用 receiver 的 slot 函数

	QPushButton* button2=new QPushButton("cliked",&window);
	QObject::connect(button2, &QPushButton::clicked, [](bool) {
		qDebug() << "You clicked me!"; });
	layout->addWidget(button1);
	layout->addWidget(button2);
	window.setLayout(layout);
	window.show();
	return app.exec();
}

