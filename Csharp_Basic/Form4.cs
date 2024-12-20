using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Basic
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void InputTextButtonClick(object sender, EventArgs e)
        {
            int students_num = 0;
            if (int.TryParse(InputText.Text, out students_num))
            {
                int[] students_score = new int[students_num];
                Random score = new Random();
                for(int i = 0; i < students_num; i++)
                {
                    students_score[i] = score.Next(0, 101);
                }
                OutputStudentsScore(students_num, students_score);
            }
            else
            {
                OutputText.Text = "잘못된 값을 입력했습니다.";
            }
        }

        private void OutputStudentsScore(int student_num, int[] students_score)
        {
            OutputText.Text = "";
            for (int i = 0; i < student_num; i++)
            {
                OutputText.Text += string.Format("학생{0}의 점수 : {1}점.\r\n", i, students_score[i]);
            }
        }
    }
}
