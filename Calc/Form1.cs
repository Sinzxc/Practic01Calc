using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
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
        bool more = false;
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
                    Form2 form2=new Form2("Деление на 0",115);
                    Form1 form1 = new Form1();
                    form2.ShowDialog();
                    form1.Hide();
                    
                }
                
            }
            if (label1.Text.Contains("^"))
            {
                double c;
                label1.Text += textBox1.Text;
                b = double.Parse(textBox1.Text);
                c =Math.Pow(a,b);
                textBox1.Text = c.ToString();
            }
            listBox1.Items.Add(label1.Text);
            label1.Text = "";
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
            button18.ForeColor = Color.White;
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackgroundImage = null;
            button18.ForeColor = Color.FromArgb(108, 153, 195);
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength && !textBox1.Text.Contains(","))
                if (textBox1.Text != "0")
                    textBox1.Text += Math.Round(Math.PI, 2);
                else
                    textBox1.Text = Math.Round(Math.PI, 2).ToString();
        }

        private void button22_MouseEnter(object sender, EventArgs e)
        {
            button22.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            button22.BackgroundImage = null;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!more)
            {
                
                while (this.Width < 500)
                {
                    
                    this.Width+=5;
                    panel1.Width+=5;
                    button11.Left = 310+140;
                    button12.Left = 236+140;
                }
                more = true;
            }
            else
            {
                while (this.Width > 355)
                {
                    this.Width -= 5;
                    panel1.Width -= 5;
                    button11.Left = 310;
                    button12.Left = 236;
                }
                more = false;
            }
            panel2.Enabled = more;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 355;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength&&!textBox1.Text.Contains(","))
                if (textBox1.Text != "0")
                    textBox1.Text += Math.Round(Math.E, 2);
                else
                    textBox1.Text = Math.Round(Math.E, 2).ToString();
        }

        private void button24_MouseEnter(object sender, EventArgs e)
        {
            button24.BackgroundImage = Image.FromFile("img/circle.png");
        }

        private void button24_MouseLeave(object sender, EventArgs e)
        {
            button24.BackgroundImage = null;
        }

        private void button23_MouseEnter(object sender, EventArgs e)
        {
            button23.BackgroundImage = Image.FromFile("img/circle.png");
            button23.ForeColor = Color.White;
        }

        private void button23_MouseLeave(object sender, EventArgs e)
        {
            button23.BackgroundImage = null;
            button23.ForeColor = Color.FromArgb(108, 153, 195);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label1.Text =  "1/"+ textBox1.Text;
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            double c;
            c = 1 / a;
            textBox1.Text = c.ToString();
            listBox1.Items.Add(label1.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label1.Text = "!" + textBox1.Text;
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            double c = 1;
            for (int i = 1; i <= a; i++)
            {
                c *= i;
            }
            textBox1.Text = c.ToString();
            listBox1.Items.Add(label1.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label1.Text = "√" + textBox1.Text;
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            double c;
            c = Math.Sqrt(a);
            textBox1.Text = c.ToString();
            listBox1.Items.Add(label1.Text);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "^";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            listBox1.Items.Add(label1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            label1.Text =  "ln("+ textBox1.Text +")";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            double c;

            if (a > 0)
            {
                c = Math.Log(a);
                textBox1.Text = c.ToString();
                listBox1.Items.Add(label1.Text);
            }
            else
            {
                textBox1.Text = "0";
                label1.Text = "";
                Form2 form2 = new Form2("Подлогарифмическое\n выражение меньше нуля",44);
                Form1 form1 = new Form1();
                form2.ShowDialog();
                form1.Hide();
            }
                
        }

        private void button31_Click(object sender, EventArgs e)
        {
            label1.Text = "tg(" + textBox1.Text + ")";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            double c;
            c = Math.Tan(a);
            textBox1.Text = c.ToString();
            listBox1.Items.Add(label1.Text);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            label1.Text =  "sin("+ textBox1.Text +")";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            double c;
            c = Math.Sin(a);
            textBox1.Text = c.ToString();
            listBox1.Items.Add(label1.Text);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            label1.Text = "cos(" + textBox1.Text + ")";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            double c;
            c = Math.Cos(a);
            textBox1.Text = c.ToString();
            listBox1.Items.Add(label1.Text);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            listBox1.Visible = !listBox1.Visible;
            listBox1.Location = new Point(16, 394);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void button25_MouseEnter(object sender, EventArgs e)
        {
            button25.BackgroundImage = Image.FromFile("img/circle.png");
            button25.ForeColor = Color.White;
        }

        private void button26_MouseEnter(object sender, EventArgs e)
        {
            button26.BackgroundImage = Image.FromFile("img/circle.png");
            button26.ForeColor = Color.White;
        }

        private void button27_MouseEnter(object sender, EventArgs e)
        {
            button27.BackgroundImage = Image.FromFile("img/circle.png");
            button27.ForeColor = Color.White;
        }

        private void button29_MouseEnter(object sender, EventArgs e)
        {
            button29.BackgroundImage = Image.FromFile("img/circle.png");
            button29.ForeColor = Color.White;
        }

        private void button30_MouseEnter(object sender, EventArgs e)
        {
            button30.BackgroundImage = Image.FromFile("img/circle.png");
            button30.ForeColor = Color.White;
        }

        private void button32_MouseEnter(object sender, EventArgs e)
        {
            button32.BackgroundImage = Image.FromFile("img/circle.png");
            button32.ForeColor = Color.White;
        }

        private void button33_MouseEnter(object sender, EventArgs e)
        {
            button33.BackgroundImage = Image.FromFile("img/circle.png");
            button33.ForeColor = Color.White;
        }

        private void button31_MouseEnter(object sender, EventArgs e)
        {
            button31.BackgroundImage = Image.FromFile("img/circle.png");
            button31.ForeColor = Color.White;
        }

        private void button25_MouseLeave(object sender, EventArgs e)
        {
            button25.BackgroundImage = null;
        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {
            button26.BackgroundImage = null;
        }

        private void button27_MouseLeave(object sender, EventArgs e)
        {
            button27.BackgroundImage = null;
        }

        private void button29_MouseLeave(object sender, EventArgs e)
        {
            button29.BackgroundImage = null;
        }

        private void button30_MouseLeave(object sender, EventArgs e)
        {
            button30.BackgroundImage = null;
        }

        private void button32_MouseLeave(object sender, EventArgs e)
        {
            button32.BackgroundImage = null;
        }

        private void button33_MouseLeave(object sender, EventArgs e)
        {
            button33.BackgroundImage = null;
        }

        private void button31_MouseLeave(object sender, EventArgs e)
        {
            button31.BackgroundImage = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text+ "+";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "0";
        }
    }
}
