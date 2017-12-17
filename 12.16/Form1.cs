using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndex = 0;
        }
        int x, y,r;
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("      请将必须的参数输入完整！");


            }

            else
            {
                r = Convert.ToInt16(textBox3.Text);
                x = Convert.ToInt16(this.textBox1.Text) - this.Location.X;
                y = Convert.ToInt16(textBox2.Text) - this.Location.Y - 30;
                Graphics g = this.CreateGraphics();
                Rectangle ju = new Rectangle(x - r, y - r, 2 * r, 2 * r);
                g.DrawEllipse(new Pen(Color.Lime, 1), ju);
                g.Dispose();
            }
            

        }

        private void groupbox1_MouseMove(object sender,MouseEventArgs e)
        {
            this.Text = "当前坐标位置:" + Convert.ToString(Control.MousePosition.X) + "," + Convert.ToString(Control.MousePosition.Y);
            
        }








        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "当前坐标位置:" + Convert.ToString(Control.MousePosition.X) + "," + Convert.ToString(Control.MousePosition.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Graphics g = this.CreateGraphics();
            r = Convert.ToInt16(textBox3.Text);
            x = Convert.ToInt16(this.textBox1.Text) - this.Location.X;
            y = Convert.ToInt16(textBox2.Text) - this.Location.Y - 30;
            g.FillEllipse(redBrush, x-r, y-r, 2*r, 2*r);



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
