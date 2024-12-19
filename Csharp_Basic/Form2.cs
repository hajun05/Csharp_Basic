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

        private bool prediction_coin_side = false;
        private bool do_prediction = false;
        private bool txt_input = false;

        private void ButtonClick_InputToOutput(object sender, EventArgs e)
        {
            string input_str = textBox_input.Text;
            if (input_str != "")
            {
                txt_input = true;
            }

            if (input_str == "false" || input_str == "False")
            {
                textBox_result.Text = "입력하신 값은 False입니다.\r\n";
                prediction_coin_side = false;
                do_prediction = true;
            }
            else if (input_str == "true" || input_str == "True")
            {
                textBox_result.Text = "입력하신 값은 True입니다.\r\n";
                prediction_coin_side = true;
                do_prediction = true;
            }
            else
            {
                textBox_result.Text = "잘못된 값을 입력하셨습니다.\r\n";
                do_prediction = false;
            }
            
            if (do_prediction == true)
            {
                bool result_coin_side = CoinTossGame(prediction_coin_side);
                CoinTossGameOutput(prediction_coin_side, result_coin_side);
            }
        }

        private void FalseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_input == false)
            {
                if (FalseButton.Checked == true)
                {
                    textBox_result.Text = "입력하신 값은 False입니다.\r\n";
                    do_prediction = true;

                    bool result_coin_side = CoinTossGame(prediction_coin_side);
                    CoinTossGameOutput(prediction_coin_side, result_coin_side);
                }
            }
        }

        private void TrueButton_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_input == false)
            {
                if (TureButton.Checked == true)
                {
                    textBox_result.Text = "입력하신 값은 True입니다.\r\n";
                    do_prediction = true;

                    bool result_coin_side = CoinTossGame(prediction_coin_side);
                    CoinTossGameOutput(prediction_coin_side, result_coin_side);
                }
            }
        }

        bool CoinTossGame(bool prediction_coin_side)
        {
            Random random_coin_toss = new Random();
            int toss_result_int = random_coin_toss.Next() % 2;
            bool toss_result_bool = false;
            if (toss_result_int == 1)
                toss_result_bool = true;

            if (prediction_coin_side == toss_result_bool)
                return true;
            else
                return false;
        }

        void CoinTossGameOutput(bool prediction_coin_toss, bool result_coin_side)
        {
            textBox_result.Text += "동전 던지기 결과 ...\r\n";
            if (result_coin_side == prediction_coin_toss)
                textBox_result.Text += "승리!\r\n";
            else
                textBox_result.Text += "패배!\r\n";

            do_prediction = false;
        }
    }
}
