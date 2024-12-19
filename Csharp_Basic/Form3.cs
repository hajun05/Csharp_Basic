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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private enum week_name // 요일을 열거형으로 저장.
        {
            monday = 0,
            tuesday, 
            wednesday,
            thursday,
            friday,
            saturday,
            sunday,
            not = -1 // 요일이 아닌것을 표시
        }

        private void InputButton_Click(object sender, EventArgs e) // 텍스트 input
        {
            if (InputTxt.Text.Length > 0 )
            {

                string input_str = InputTxt.Text;
                week_name choice_day = new week_name(); // 열거형으로 입력된 텍스트에 따라 분기처리

                switch (input_str) // switch문 분기처리
                {
                    case "monday": case "mon": case "월요일": case "월":
                        choice_day = week_name.monday;
                        Monday.Checked = true;
                        break;
                    case "tuesday": case "tues": case "화요일": case "화":
                        choice_day = week_name.tuesday;
                        Tuesday.Checked = true;
                        break;
                    case "wednesday": case "wednes": case "수요일": case "수":
                        choice_day = week_name.wednesday;
                        Wednesday.Checked = true;
                        break;
                    case "thursday": case "thurs": case "목요일": case "목":
                        choice_day = week_name.thursday;
                        Thursday.Checked = true;
                        break;
                    case "friday": case "fri": case "금요일": case "금":
                        choice_day = week_name.friday;
                        Friday.Checked = true;
                        break;
                    case "saturday": case "satur": case "토요일": case "토":
                        choice_day = week_name.saturday;
                        Saturday.Checked = true;
                        break;
                    case "sunday": case "sun": case "일요일": case "일":
                        choice_day = week_name.sunday;
                        Sunday.Checked = true;
                        break;
                    default:
                        choice_day = week_name.not;
                        break;
                }
                DayOutput(choice_day); // 출력
            }
        }

        // .Checked값 수정시 모든 CheckedChanged 이벤트 시행, 무한루프 위험. Click 이벤트로 대체
        private void Monday_Click(object sender, EventArgs e) 
        {
            InputTxt.Text = "monday";
            InputButton.PerformClick();
        }
        private void Tuesday_Click(object sender, EventArgs e)
        {
            InputTxt.Text = "tuesday";
            InputButton.PerformClick();
        }
        private void Wednesday_Click(object sender, EventArgs e)
        {
            InputTxt.Text = "wednesday";
            InputButton.PerformClick();
        }
        private void Thursday_Click(object sender, EventArgs e)
        {
            InputTxt.Text = "thursday";
            InputButton.PerformClick();
        }
        private void Friday_Click(object sender, EventArgs e)
        {
            InputTxt.Text = "friday";
            InputButton.PerformClick();
        }
        private void Saturday_Click(object sender, EventArgs e)
        {
            InputTxt.Text = "saturday";
            InputButton.PerformClick();
        }
        private void Sunday_Click(object sender, EventArgs e)
        {
            InputTxt.Text = "sunday";
            InputButton.PerformClick();
        }

        private void DayOutput(week_name choice_day) // Txtbox 출력
        {
            switch (choice_day)
            {
                case week_name.monday:
                    OutputTxt.Text = "이야 월요일이다! 출근한다!";
                    break;
                case week_name.tuesday:
                    OutputTxt.Text = "벌써 주말이 그리운 화요일...";
                    break;
                case week_name.wednesday:
                    OutputTxt.Text = "이제 절반 넘긴 수요일!";
                    break;
                case week_name.thursday:
                    OutputTxt.Text = "2일 남았다! 힘내는 목요일!";
                    break;
                case week_name.friday:
                    OutputTxt.Text = "불타는 금요일! 어차피 내일은 주말!";
                    break;
                case week_name.saturday:
                    OutputTxt.Text = "주말의 시작인 토요일!";
                    break;
                case week_name.sunday:
                    OutputTxt.Text = "벌써 일요일이라니, 내일 월요일이라니...";
                    break;
                default:
                    OutputTxt.Text = "요일을 선택하세요!";
                    break;
            }
        }
    }
}
