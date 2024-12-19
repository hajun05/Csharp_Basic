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

        bool prediction_coin_side = false;
        bool doing_inputtxt = false;

        private void ButtonClick_InputToOutput(object sender, EventArgs e)
        {
            string input_str = textBox_input.Text;
            if (input_str == "false" || input_str == "False")
            {
                textBox_result.Text = "입력하신 값은 False입니다.";
                prediction_coin_side = false;
                doing_inputtxt = true;
            }
            else if (input_str == "true" || input_str == "True")
            {
                textBox_result.Text = "입력하신 값은 True입니다.";
                prediction_coin_side = true;
                doing_inputtxt = true;
            }
            else
            {
                textBox_result.Text = "잘못된 값을 입력하셨습니다.";
                doing_inputtxt = false;
            }
        }

        private void FalseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (doing_inputtxt == false)
            {
                if (FalseButton.Checked == true)
                {
                    textBox_result.Text = "입력하신 값은 False입니다.";
                }
            }
        }

        private void TrueButton_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_input.Text == "")
            {
                if (TureButton.Checked == true)
                {
                    textBox_result.Text = "입력하신 값은 True입니다.";
                }
            }
        }
    }
}
