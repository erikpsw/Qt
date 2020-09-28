/********************************************************************************
** Form generated from reading UI file 'Hello_Qt.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_HELLO_QT_H
#define UI_HELLO_QT_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QToolBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_Hello_QtClass
{
public:
    QMenuBar *menuBar;
    QToolBar *mainToolBar;
    QWidget *centralWidget;
    QStatusBar *statusBar;

    void setupUi(QMainWindow *Hello_QtClass)
    {
        if (Hello_QtClass->objectName().isEmpty())
            Hello_QtClass->setObjectName(QString::fromUtf8("Hello_QtClass"));
        Hello_QtClass->resize(600, 400);
        menuBar = new QMenuBar(Hello_QtClass);
        menuBar->setObjectName(QString::fromUtf8("menuBar"));
        Hello_QtClass->setMenuBar(menuBar);
        mainToolBar = new QToolBar(Hello_QtClass);
        mainToolBar->setObjectName(QString::fromUtf8("mainToolBar"));
        Hello_QtClass->addToolBar(mainToolBar);
        centralWidget = new QWidget(Hello_QtClass);
        centralWidget->setObjectName(QString::fromUtf8("centralWidget"));
        Hello_QtClass->setCentralWidget(centralWidget);
        statusBar = new QStatusBar(Hello_QtClass);
        statusBar->setObjectName(QString::fromUtf8("statusBar"));
        Hello_QtClass->setStatusBar(statusBar);

        retranslateUi(Hello_QtClass);

        QMetaObject::connectSlotsByName(Hello_QtClass);
    } // setupUi

    void retranslateUi(QMainWindow *Hello_QtClass)
    {
        Hello_QtClass->setWindowTitle(QApplication::translate("Hello_QtClass", "Hello_Qt", nullptr));
    } // retranslateUi

};

namespace Ui {
    class Hello_QtClass: public Ui_Hello_QtClass {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_HELLO_QT_H
