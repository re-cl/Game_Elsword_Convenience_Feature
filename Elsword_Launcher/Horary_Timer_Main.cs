using System;
using System.Drawing;
using System.Windows.Forms;

namespace Elsword_Launcher
{
    public partial class Horary_Timer_Main : MetroFramework.Forms.MetroForm
    {
        private int count = 0;
        private int List_count = 0;

        public Horary_Timer_Main()
        {
            InitializeComponent();
        }

        // 폼 로드
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetUI();
        }

        // 타이머 Tick 이벤트
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            UpdateTimerUI();
        }

        // 플러스 버튼 (시간 감소)
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                UpdateTimerUI();
            }
            else if (count == 0)
            {
                count = 59;
                UpdateTimerUI();
            }
        }

        // 마이너스 버튼 (시간 증가)
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (count < 60)
            {
                count++;
                UpdateTimerUI();
            }
        }

        // UI 업데이트 메서드
        private void UpdateTimerUI()
        {
            if (count < 20) // 푸른색
            {
                label1.Text = "푸른색";
                label2.Text = (20 - count).ToString();
                label3.Text = "아군의 모든 피해량 증가 : 20%";
                label4.Text = "유지 시간 : 10초";

                label1.ForeColor = Color.FromArgb(0, 0, 192);
                label2.ForeColor = Color.FromArgb(255, 128, 128);
            }
            else if (count < 40) // 보라색
            {
                label1.Text = "보라색";
                label2.Text = (40 - count).ToString();
                label3.Text = "가드 상태 무시와 방어력을 100% 무시한 피해";
                label4.Text = "유지 시간 : 1초";

                label1.ForeColor = Color.FromArgb(192, 0, 192);
                label2.ForeColor = Color.FromArgb(255, 128, 128);
            }
            else if (count < 55) // 노란색
            {
                label1.Text = "노란색";
                label2.Text = (55 - count).ToString();
                label3.Text = "아군은 특정 특수 자원을 소모하지 않는다.";
                label4.Text = "유지 시간 : 8초";

                label1.ForeColor = Color.Orange;
                label2.ForeColor = Color.FromArgb(255, 128, 128);
            }
            else if (count < 60) // 컬미네이션
            {
                label1.Text = "컬미네이션";
                label2.Text = (60 - count).ToString();
                label3.Text = "";
                label4.Text = "유지 시간 : 10초";

                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.FromArgb(255, 128, 128);
            }
            else // 초기화 상태
            {
                count = 0;
                ResetUI();
            }
        }

        // 초기화 메서드
        private void ResetUI()
        {
            count = 0; // 초기 상태에서 count를 0으로 설정
            label1.Text = "푸른색";
            label2.Text = "20";
            label3.Text = "아군의 모든 피해량 증가 : 20%";
            label4.Text = "유지 시간 : 10초";

            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
        }

        // 시작 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // 일시정지 버튼
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // 리셋 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ResetUI();
        }

        // 설정 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            Horary_Timer_Setting form2 = new Horary_Timer_Setting(this);
            form2.ShowDialog();
        }

        // ESC 키로 종료
        private void Exit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        // 아이콘 클릭 시 크기 변경
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            List_count++;

            if (List_count == 1)
            {
                this.Size = new Size(353, 59);  // 축소
                pictureBox1.Location = new Point(312, 17);
            }
            else
            {
                this.Size = new Size(353, 183); // 기본
                List_count = 0;
                pictureBox1.Location = new Point(312, 17);
            }
        }

        // 폼 종료 시에
        private void horary_Form_Closing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            Dispose();
        }

        #region 폼 이동 이벤트 항목
        private Point mouseDownPoint = Point.Empty;
        private void formMove_Down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint = e.Location;
            }
        }
        #endregion

        private void formMove_Move(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint != Point.Empty)
            {
                this.Location = new Point(
                    this.Location.X + e.X - mouseDownPoint.X,
                    this.Location.Y + e.Y - mouseDownPoint.Y
                );
            }
        }

        private void formMove_Up(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint = Point.Empty;
            }
        }
    }
}
