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
        private uint[] win_loss_count = new uint[2] { 0, 0 }; // 승률 계산을 위한 승패 count 배열.

        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonClick_InputToOutput(object sender, EventArgs e) // input 버튼 클릭 이벤트.
        {
            if (textBox_input.Text.Length > 0) // textBox_input에 문자열이 입력된 경우
            {
                bool prediction_coin_side = false;
                if (bool.TryParse(textBox_input.Text, out prediction_coin_side)) // textBox_input에 입력된 문자열을 bool로 변환, 예측값 산출
                {
                    bool result_coin_side = CoinTossGame(prediction_coin_side); // 결과값 산출
                    CoinTossGameOutput(prediction_coin_side, result_coin_side); // 예측값과 결과값 비교, 결과 출력
                }
                else // string -> bool 변환 실패
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
            bool toss_result_bool = (random_coin_toss.Next(0, 2) == 1) ? true : false; // 0 -> false, 1 -> ture로 변환

            if (prediction_coin_side == toss_result_bool) // 예측값과 결과값 비교
                return true;
            else
                return false;
        }

        void CoinTossGameOutput(bool prediction_coin_toss, bool result_coin_side)
        {
            if (prediction_coin_toss == true) // 예측값 출력
            {
                textBox_result.Text = "입력하신 값은 True입니다.\r\n";
            }
            else
            {
                textBox_result.Text = "입력하신 값은 False입니다.\r\n";
            }

            textBox_result.Text += "동전 던지기 결과 ...\r\n";
            if (result_coin_side == prediction_coin_toss)  // 예측값과 결과값 비교 출력
            {
                textBox_result.Text += "승리!\r\n";
                win_loss_count[0]++; // 승리 횟수 추가
            }
            else
            {
                textBox_result.Text += "패배!\r\n";
                win_loss_count[1]++; // 패배 횟수 추가
            }

            // 승률 계산. 분자(승리 횟수)에 미리 100을 곱해 float형을 사용하지 않고도 승률 계산 용이
            uint winnig_rate = win_loss_count[0] * 100 / (win_loss_count[0] + win_loss_count[1]); 
            textBox_result.Text += string.Format("승패 횟수 : {0} / {1}\r\n", win_loss_count[0], win_loss_count[1]);
            textBox_result.Text += string.Format("승률 : {0}%\r\n", winnig_rate);
            textBox_input.Text = ""; // textBox_input에 입력된 값 초기화.
            // textBox_input.Text = ""; // branch merge conflict 확인용. conflict 유발, 수동 수정
        }
    }
}
