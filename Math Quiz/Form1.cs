using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{

    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        //随机数生成器
        int addend1;
        int addend2;
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);


            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            label5.Text = addend1.ToString();
            label4.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            timeLeft = 10;
            timeLabel.Text = "10 seconds";
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft <= 5)
                timeLabel.BackColor = Color.Red;
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                //在窗体中，请选择刚才添加的“timer1”图标，并将其“Interval”属性设置为“1000”。
                //因为间隔值单位为毫秒，因此当值为 1000 时将使 Tick 事件每秒触发一次。
                timeLabel.Text = timeLeft.ToString() + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                startButton.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private bool CheckTheAnswer()
        {
            if (addend1 + addend2 == sum.Value)
                return true;
            else
                return false;
        }
    }
}
