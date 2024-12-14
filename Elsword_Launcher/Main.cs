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
using System.Diagnostics;
using System.IO;

namespace Elsword_Launcher
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KillProc("x2");

            void KillProc(string a)
            {
                Process[] Proclist = Process.GetProcessesByName(a);

                if (Proclist.Length > 0)
                {
                    Proclist[0].Kill();
                }
            }

            MessageBox.Show("엘소드 강제 종료 성공!", "알림");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Level_Scroll form4 = new Level_Scroll();
            form4.ShowDialog();
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Min_Cal form2 = new Min_Cal();
            form2.ShowDialog();
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Horary_Timer_Main form3 = new Horary_Timer_Main();
            form3.Show();
        }


        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Nexon\ElSword\data\movie\movie_title.avi");
            }
            catch (Exception)
            {
                MessageBox.Show("C 드라이브에 엘소드 폴더가 없습니다!", "알림");
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"D:\Nexon\ElSword\data\movie\movie_title.avi");
            }
            catch (Exception)
            {
                MessageBox.Show("D 드라이브에 엘소드 폴더가 없습니다!", "알림");
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\Nexon\ElSword\elsword.exe");
            if (fi.Exists)
            {
                Process.Start("cmd.exe", @"/c cd C:\Nexon\ElSword\&&elsword.exe d");
                DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, "패치가 끝나면 자동으로 CMD 창이 닫힙니다.", "안내사항");
            }
            else
            {
                MessageBox.Show(new Form { TopMost = true }, "C 드라이브에 엘소드 파일이 없습니다!", "알림");
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"D:\Nexon\ElSword\elsword.exe");
            if (fi.Exists)
            {
                Process.Start("cmd.exe", @"/c cd D:\Nexon\ElSword\&&elsword.exe d");
                MessageBox.Show(new Form { TopMost = true }, "패치가 끝나면 자동으로 CMD 창이 닫힙니다.", "안내사항");
            }
            else
            {
                MessageBox.Show(new Form { TopMost = true }, "D 드라이브에 엘소드 파일이 없습니다!", "알림");
            }
        }
    }
}
