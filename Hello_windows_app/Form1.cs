using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_windows_app
{
    public partial class Btn : Form
    {
        public Btn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblhello.Text = "Hello world";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
