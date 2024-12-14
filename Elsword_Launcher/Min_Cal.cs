using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Elsword_Launcher
{
    public partial class Min_Cal : MetroForm
    {
        public Min_Cal()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            long a = 0, b = 0, c = 0;
            double d = 0;


            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                a = long.Parse(textBox1.Text);
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            else
            {
                b = long.Parse(textBox2.Text);
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            else
            {
                c = long.Parse(textBox3.Text);
            }




            // 총딜÷(분x60 + 초)x60
            //d = a / (b * 60 + c) * 60;
            d = Convert.ToDouble(a) / (b * 60 + c) * 60;
            string re = "" + d;

            label5.Text = string.Format("분당 {0} 딜량", d.ToString("n0"));
            if (d >= 1000000000000)//10000억 딜 이상
            {
                label6.Text = "";
            }
            else if (d >= 100000000000)//1000억 딜 이상
            {
                label6.Text = "분당 " + re.Substring(0, 4) + "억 딜량";
            }
            else if (d >= 10000000000)//100억 딜 이상
            {
                label6.Text = "분당 " + re.Substring(0, 3) + "억 딜량";
            }
            else if (d >= 1000000000)// 10억 딜 이상
            {
                label6.Text = "분당 " + re.Substring(0, 2) + "억 딜량";
            }
            else if (d >= 100000000)// 1억 딜 이상
            {
                label6.Text = "분당 " + re.Substring(0, 1) + "억 딜량";
            }
            else if (d >= 10000000)// 천만 딜 이상
            {
                label6.Text = "분당 " + re.Substring(0, 4) + "만 딜량";
            }
            else if (d >= 1000000)// 백만 딜 이상
            {
                label6.Text = "분당 " + re.Substring(0, 3) + "만 딜량";
            }
            else if (d >= 100000)// 십만 딜 이상
            {
                label6.Text = "분당 " + re.Substring(0, 2) + "만 딜량";
            }
            else if (d >= 10000)// 만 딜 이상
            {
                label6.Text = "분당 " + re.Substring(0, 1) + "만 딜량";
            }
        }

        private void Exit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        // 숫자만 입력받게!!
        private void C_only(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        // Tab 누르면 넘어가면서 전체 선택!!
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
