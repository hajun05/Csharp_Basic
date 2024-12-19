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

        private enum week_name
        {
            monday = 0,
            tuesday, 
            wednesday,
            thursday,
            friday,
            saturday,
            sunday,
            not = -1
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (InputTxt.Text.Length > 0 )
            {
                string input_str = InputTxt.Text;
                week_name choice_day = new week_name();

                switch (input_str)
                {
                    case "monday": case "mon": case "월요일": case "월":
                        choice_day = week_name.monday;
                        break;
                    case "tuesday": case "tues": case "화요일": case "화":
                        choice_day = week_name.tuesday;
                        break;
                    case "wednesday": case "wednes": case "수요일": case "수":
                        choice_day = week_name.wednesday;
                        break;
                    case "thursday": case "thurs": case "목요일": case "목":
                        choice_day = week_name.thursday;
                        break;
                    case "friday": case "fri": case "금요일": case "금":
                        choice_day = week_name.friday;
                        break;
                    case "saturday": case "satur": case "토요일": case "토":
                        choice_day = week_name.saturday;
                        break;
                    case "sunday": case "sun": case "일요일": case "일":
                        choice_day = week_name.sunday;
                        break;
                    default:
                        choice_day = week_name.not;
                        break;
                }
                DayOutput(choice_day);
            }
        }

        private void Monday_CheckedChanged(object sender, EventArgs e)
        {
            InputTxt.Text = "monday";
            InputButton.PerformClick();
        }
        private void Tuesday_CheckedChanged(object sender, EventArgs e)
        {
            InputTxt.Text = "tuesday";
            InputButton.PerformClick();
        }
        private void Wednesday_CheckedChanged(object sender, EventArgs e)
        {
            InputTxt.Text = "wednesday";
            InputButton.PerformClick();
        }
        private void Thursday_CheckedChanged(object sender, EventArgs e)
        {
            InputTxt.Text = "thursday";
            InputButton.PerformClick();
        }
        private void Friday_CheckedChanged(object sender, EventArgs e)
        {
            InputTxt.Text = "friday";
            InputButton.PerformClick();
        }
        private void Saturday_CheckedChanged(object sender, EventArgs e)
        {
            InputTxt.Text = "saturday";
            InputButton.PerformClick();
        }
        private void Sunday_CheckedChanged(object sender, EventArgs e)
        {
            InputTxt.Text = "sunday";
            InputButton.PerformClick();
        }

        private void DayOutput(week_name choice_day)
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
            }
        }
    }
}
