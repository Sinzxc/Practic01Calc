using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form2 : Form
    {
        public Form2(string s,int pos)
        {
            InitializeComponent();
            label1.Text = s;
            label1.Left = pos;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
