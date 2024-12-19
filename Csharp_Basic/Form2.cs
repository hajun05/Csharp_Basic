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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonClick_InputToOutput(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length > 0)
            {
                bool prediction_coin_side = false;
                if (bool.TryParse(textBox_input.Text, out prediction_coin_side))
                {
                    bool result_coin_side = CoinTossGame(prediction_coin_side);
                    CoinTossGameOutput(prediction_coin_side, result_coin_side);
                }
                else
                {
                    textBox_result.Text = "잘못된 값을 입력하셨습니다.\r\nfalse 혹은 true를 입력해 주십시오.\r\n";
                }
            }
        }

        private void FalseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length == 0)
            {
                if (FalseButton.Checked == true)
                {
                    textBox_input.Text = "false";
                    button_input.PerformClick(); // buttion_input의 click event 실행. 잘만 응용하면 다른 이벤트들간 반복되는 코드 생략 가능.

                    //bool prediction_coin_side = false;
                    //bool result_coin_side = CoinTossGame(prediction_coin_side);
                    //CoinTossGameOutput(prediction_coin_side, result_coin_side);
                }
            }
        }

        private void TrueButton_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length == 0)
            {
                if (TureButton.Checked == true)
                {
                    textBox_input.Text = "true";
                    button_input.PerformClick(); // buttion_input의 click event 실행. 잘만 응용하면 다른 이벤트들간 반복되는 코드 생략 가능.

                    //bool prediction_coin_side = true;
                    //bool result_coin_side = CoinTossGame(prediction_coin_side);
                    //CoinTossGameOutput(prediction_coin_side, result_coin_side);
                }
            }
        }

        bool CoinTossGame(bool prediction_coin_side)
        {
            Random random_coin_toss = new Random();
            bool toss_result_bool = (random_coin_toss.Next(0, 2) == 1) ? true : false;

            if (prediction_coin_side == toss_result_bool)
                return true;
            else
                return false;
        }

        void CoinTossGameOutput(bool prediction_coin_toss, bool result_coin_side)
        {
            if (prediction_coin_toss == true)
            {
                textBox_result.Text = "입력하신 값은 True입니다.\r\n";
            }
            else
            {
                textBox_result.Text = "입력하신 값은 False입니다.\r\n";
            }

            textBox_result.Text += "동전 던지기 결과 ...\r\n";
            if (result_coin_side == prediction_coin_toss)
                textBox_result.Text += "승리!\r\n";
            else
                textBox_result.Text += "패배!\r\n";

            textBox_input.Text = "";
        }
    }
}
