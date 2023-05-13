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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b;
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage  = Image.FromFile("img/circle.png");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength)
                if (textBox1.Text != "0")
                    textBox1.Text += 9;
                else
                    textBox1.Text = "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength)
                if (textBox1.Text != "0")
                    textBox1.Text += 8;
                else
                    textBox1.Text = "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength)
                if (textBox1.Text != "0")
                    textBox1.Text += 7;
                else
                    textBox1.Text = "7";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = null;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength)
                if (textBox1.Text != "0")
                    textBox1.Text += 6;
                else
                    textBox1.Text = "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength)
                if (textBox1.Text != "0")
                    textBox1.Text += 5;
                else
                    textBox1.Text = "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength)
                if (textBox1.Text != "0")
                    textBox1.Text += 4;
                else
                    textBox1.Text = "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength)
                if (textBox1.Text != "0")
                    textBox1.Text += 3;
                else
                    textBox1.Text = "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength)
                if (textBox1.Text != "0")
                    textBox1.Text += 2;
                else
                    textBox1.Text = "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength)
                if (textBox1.Text != "0")
                    textBox1.Text += 1;
                else
                    textBox1.Text = "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength && textBox1.Text != "0")
                textBox1.Text += 0;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.ForeColor = Color.Red;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.ForeColor = Color.White;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = null;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = null;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = null;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackgroundImage = null;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackgroundImage = null;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackgroundImage = null;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackgroundImage = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength-1);
            else
                textBox1.Text ="0";
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackgroundImage = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text = "0";
            else
                label1.Text = "";

        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackgroundImage = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double d;
            d=Convert.ToDouble(textBox1.Text);
            if (d > 0.9999)
            {
                d *= 0.01;
                textBox1.Text = d.ToString();
            }
            
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackgroundImage = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double d;
            d = Convert.ToDouble(textBox1.Text);
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackgroundImage = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("+"))
            {
                label1.Text += textBox1.Text;
                b = double.Parse(textBox1.Text);
                double c = a + b;
                textBox1.Text = c.ToString();
            }
            if (label1.Text.Contains("-"))
            {
                double c;
                label1.Text += textBox1.Text;
                b = double.Parse(textBox1.Text);
                    c = a - b;
                textBox1.Text = c.ToString();
            }
            if (label1.Text.Contains("×"))
            {
                double c;
                label1.Text += textBox1.Text;
                b = double.Parse(textBox1.Text);
                c = a * b;
                textBox1.Text = c.ToString();
            }
            if (label1.Text.Contains("÷"))
            {
                double c;
                label1.Text += textBox1.Text;
                b = double.Parse(textBox1.Text);
                if (b != 0)
                {
                    c = a / b;
                    textBox1.Text = c.ToString();
                }
                else
                {
                    textBox1.Text = "0";
                    label1.Text = "";
                    Form2 form2=new Form2("Деление на 0");
                    Form1 form1 = new Form1();
                    form2.ShowDialog();
                    form1.Hide();
                    
                }
                    
            }
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackgroundImage = null;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            button18.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackgroundImage = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "-";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {
            button19.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            button19.BackgroundImage = null;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "×";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button20_MouseEnter(object sender, EventArgs e)
        {
            button20.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            button20.BackgroundImage = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "÷";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button21_MouseEnter(object sender, EventArgs e)
        {
            button21.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            button21.BackgroundImage = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text+ "+";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
        }
    }
}
