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
    public partial class Level_Scroll : MetroForm
    {
        public Level_Scroll()
        {
            InitializeComponent();
        }

        // 폼 로드
        private void 현자의_주문서_Load(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
        }



		// 계산 버튼
		private void button1_Click(object sender, EventArgs e)
        {
			int Level = 0, Quantity = 0, LevelC = 0;

			Level = Int32.Parse(textBox1.Text);
			Quantity = Int32.Parse(textBox2.Text);

			/*
			if (Quantity >= 99)
			{
				Quantity = Quantity - 99;
			}
				else
            {
				Level += Quantity;
			}
			*/

			Level += Quantity;

			if (Level > 99)
			{
				LevelC = Level - 99;
				Level = 99;

				label5.Text = Level.ToString();
				label6.Text = LevelC.ToString();
			}
			else
			{
				label5.Text = Level.ToString();
				label6.Text = LevelC.ToString();
			}
		}

		// 숫자만 입력
        private void C_Only(object sender, KeyPressEventArgs e)
        {
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
			{
				e.Handled = true;
			}
		}

		// ESC
        private void Exit(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
    }
}
