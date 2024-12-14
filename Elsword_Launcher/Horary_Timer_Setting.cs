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
    public partial class Horary_Timer_Setting : MetroForm
    {

        Horary_Timer_Main form1;

        public Horary_Timer_Setting(Horary_Timer_Main form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }


        public Horary_Timer_Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.TopMost = true;
            label7.Text = "항상 맨 위로 설정 완료!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.TopMost = false;
            label7.Text = "설정 해제 완료!";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        private void Exit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
