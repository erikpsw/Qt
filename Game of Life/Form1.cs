using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        int Row = 5;
        int Column = 20;
        public int[,] pos = new int[20, 5];
        public string[] btnlist = new string[] { "button2", "button1","button3", "button4" };
        public int[,] tmp = new int[20, 5];

        public Form1()
        {
            InitializeComponent();
            refresh();
        }   
                    

        public void refresh()         
        {
            int x = 10;
            int y = 30;//初始位置
            for (int i = 0; i < Row * Column; i++)
            {
                if (i % Column == 0)
                {
                    x = 10;
                    y += 30;
                }
                Button NewButton = new Button();
                NewButton.Location = new Point(x, y);
                NewButton.Size = new Size(30, 30);
                NewButton.Click += NewButton_Click;
                this.Controls.Add(NewButton);
                x += 30;
            }
    
        }

        public void Restart()
        {
            int sum = Column * Row;
            while (sum > 0.1)
            {
                sum = sum / 2;

                foreach (Control ctl in this.Controls)
                {
                    bool ok = true;
                    if (ctl is Button)
                    {
                        foreach (string name in btnlist)
                        {
                            if (name == ctl.Name.ToString())
                                ok = false;
                        }
                        if (ok)
                            this.Controls.Remove(ctl);
                    }
                }
            }
            int x = 10;
            int y = 30;//初始位置
            for (int i = 0; i < Row * Column; i++)
            {
                if (i % Column == 0)
                {
                    x = 10;
                    y += 30;
                }
               
                Button NewButton = new Button();
                NewButton.Location = new Point(x, y);
                NewButton.Size = new Size(30, 30);
                NewButton.Click += NewButton_Click;
                this.Controls.Add(NewButton);
                if (tmp[(x - 10) / 30, ((y - 30) / 30 )- 1] == 1)
                    NewButton.BackColor = Color.Blue;
                x += 30;
            }

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            int px,py;
            Button p = (Button)sender;
            p.BackColor = Color.Blue;
            px = (p.Location.X - 10) / 30;
            py = (p.Location.Y - 30) / 30 -1;
            Console.Write(px+" ");
            Console.Write(py);
            Console.WriteLine("\n");
            pos[px, py] = 1;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void columnnum_ValueChanged(object sender, EventArgs e)
        {
            Column=(int)columnnum.Value;
        }

        private void rownum_ValueChanged(object sender, EventArgs e)
        {
            Row = (int)rownum.Value;
        }

        //更新大小
        private void button1_Click(object sender, EventArgs e)
        {
            pos = new int[Column, Row];
            int sum = Column * Row;
            while (sum > 0.1)
            {
                sum = sum / 2;
         
                foreach (Control ctl in this.Controls)
                {
                    bool ok = true;
                    if (ctl is Button)
                    {
                        foreach(string name in btnlist)
                        {
                            if (name == ctl.Name.ToString())
                                ok = false;
                        }
                        if(ok)
                            this.Controls.Remove(ctl);
                    }
                }
            }
          
            refresh();
        }

  

        private static bool Equal(int s)
        {
            if (s == 1)
                return true;
            else
                return false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("ori");
            for (int j = 0; j < Row; j++)
            {
                for (int i = 0; i < Column; i++)
                    Console.Write(pos[i, j] + " ");
                Console.WriteLine("\n");

            }
            tmp = new int[Column, Row];
            for (int m = 0; m < Column; m++)
                for (int n = 0; n < Row; n++)
                {
                    if (pos[m, n] == 1)
                    {
                        int s = 0;
                        for(int p=0;p<3;p++)
                            for(int q = 0; q < 3; q++)
                            {
                                if (m + p - 1 >= Column || m + p - 1 < 0)
                                    continue;
                                else if (n + q - 1 >= Row || n + q - 1 < 0)
                                    continue;
                                else
                                    s += pos[m + p - 1, n + q - 1];
                            }
                        if (s > 2 && s < 5)
                            tmp[m, n] = 1;
                    }
                    else
                    {
                        int s = 0;
                        for (int p = 0; p < 3; p++)
                            for (int q = 0; q < 3; q++)
                            {
                                if (m + p - 1 >= Column || m + p - 1 < 0)
                                    continue;
                                else if (n + q - 1 >= Row || n + q - 1 < 0)
                                    continue;
                                else
                                    s += pos[m + p - 1, n + q - 1];
                            }
                        if (s==3)
                            tmp[m, n] = 1;
                    }
                }
            Console.WriteLine("tmp");
            for (int j = 0; j < Row; j++)
            {
                for (int i = 0; i < Column; i++)
                {
                    Console.Write(tmp[i, j] + " ");
                    pos[i, j] = tmp[i, j];
                }
                Console.WriteLine("\n");
            }

            int sum = Column * Row;//清除原图
            while (sum > 0.1)
            {
                sum = sum / 2;

                foreach (Control ctl in this.Controls)
                {
                    bool ok = true;
                    if (ctl is Button)
                    {
                        foreach (string name in btnlist)
                        {
                            if (name == ctl.Name.ToString())
                                ok = false;
                        }
                        if (ok)
                            this.Controls.Remove(ctl);
                    }
                }
            }
      
            Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("ori");
            for (int j = 0; j < Row; j++)
            {
                for (int i = 0; i < Column; i++)
                    Console.Write(pos[i, j] + " ");
                Console.WriteLine("\n");

            }
            tmp = new int[Column, Row];
            for (int m = 0; m < Column; m++)
                for (int n = 0; n < Row; n++)
                {
                    if (pos[m, n] == 1)
                    {
                        int s = 0;
                        for (int p = 0; p < 3; p++)
                            for (int q = 0; q < 3; q++)
                            {
                                if (m + p - 1 >= Column || m + p - 1 < 0)
                                    continue;
                                else if (n + q - 1 >= Row || n + q - 1 < 0)
                                    continue;
                                else
                                    s += pos[m + p - 1, n + q - 1];
                            }
                        if (s > 2 && s < 5)
                            tmp[m, n] = 1;
                    }
                    else
                    {
                        int s = 0;
                        for (int p = 0; p < 3; p++)
                            for (int q = 0; q < 3; q++)
                            {
                                if (m + p - 1 >= Column || m + p - 1 < 0)
                                    continue;
                                else if (n + q - 1 >= Row || n + q - 1 < 0)
                                    continue;
                                else
                                    s += pos[m + p - 1, n + q - 1];
                            }
                        if (s == 3)
                            tmp[m, n] = 1;
                    }
                }
            Console.WriteLine("tmp");
            for (int j = 0; j < Row; j++)
            {
                for (int i = 0; i < Column; i++)
                {
                    Console.Write(tmp[i, j] + " ");
                    pos[i, j] = tmp[i, j];
                }
                Console.WriteLine("\n");
            }

            int sum = Column * Row;//清除原图
            while (sum > 0.1)
            {
                sum = sum / 2;

                foreach (Control ctl in this.Controls)
                {
                    bool ok = true;
                    if (ctl is Button)
                    {
                        foreach (string name in btnlist)
                        {
                            if (name == ctl.Name.ToString())
                                ok = false;
                        }
                        if (ok)
                            this.Controls.Remove(ctl);
                    }
                }
            }
      
            Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
