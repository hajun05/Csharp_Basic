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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        enum RockScissorPaper
        {
            Rock,
            Scissor,
            Paper
        }
        byte my_score = 0;
        byte com_score = 0;

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            RockScissorPaper my_choice = RockScissorPaper.Scissor;
            MeVSComputer(my_choice);
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            RockScissorPaper my_choice = RockScissorPaper.Rock;
            MeVSComputer(my_choice);
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            RockScissorPaper my_choice = RockScissorPaper.Paper;
            MeVSComputer(my_choice);
        }

        private void MeVSComputer(RockScissorPaper my_choice)
        {
            Random random = new Random();
            int com_choice_num = random.Next(0, 3);
            RockScissorPaper com_choice = new RockScissorPaper();

            switch (com_choice_num)
            {
                case (int)RockScissorPaper.Rock:
                    com_choice = RockScissorPaper.Rock;
                    break;
                case (int)RockScissorPaper.Scissor:
                    com_choice = RockScissorPaper.Scissor;
                    break;
                case (int)RockScissorPaper.Paper:
                    com_choice = RockScissorPaper.Paper;
                    break;
            }

            GameResultOutput(my_choice, com_choice);
        }

        private void GameResultOutput(RockScissorPaper my_choice, RockScissorPaper com_choice)
        {
            OutputText.Text = "";
            OutputText.Text += string.Format($"내 선택 : {my_choice.ToString()}\r\nVS\r\n컴퓨터의 선택 : {com_choice.ToString()}\r\n");

            if (my_choice == com_choice)
            {
                OutputText.Text += "비김!\r\n";
            }
            else
            {
                if (my_choice == RockScissorPaper.Rock && com_choice == RockScissorPaper.Scissor ||
                    my_choice == RockScissorPaper.Scissor && com_choice == RockScissorPaper.Paper ||
                    my_choice == RockScissorPaper.Paper && com_choice == RockScissorPaper.Rock)
                {
                    OutputText.Text += "나의 승리!\r\n";
                    my_score += 1;
                }
                else
                {
                    OutputText.Text += "나의 패배...\r\n";
                    com_score += 1;
                }
            }

            OutputText.Text += string.Format("내 점수 : {0} - 컴퓨터의 점수 : {1}\r\n", my_score, com_score);
            if (my_score >= 3)
            {
                OutputText.Text += "나의 최종 승리!(점수 초기화)\r\n";
                my_score = 0;
                com_score = 0;
            }
            else if (com_score >= 3)
            {
                OutputText.Text += "나의 최종 패배...(점수 초기화)\r\n";
                my_score = 0;
                com_score = 0;
            }
        }
    }
}
