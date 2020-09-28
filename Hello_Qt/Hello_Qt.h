#pragma once

#include <QtWidgets/QMainWindow>
#include "ui_Hello_Qt.h"

class Hello_Qt : public QMainWindow
{
    Q_OBJECT

public:
    Hello_Qt(QWidget *parent = Q_NULLPTR);

private:
    Ui::Hello_QtClass ui;
};
