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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            #region 실습. 변수 및 캐스팅
            {
                //byte locket_engine_num = 4;
                //short locket_try_num = 3;
                //int locket_boarding_people = 3;
                //float locket_feul_mount = 100000.5f;
                //double locket_power = 300000.582;
                //decimal locket_spending_money = 54294553.299845m;

                //textBox_print.Text
                //    += (locket_engine_num.GetType() +
                //    " locket_engine_num : " +
                //    locket_engine_num.ToString() + "\r\n");

                //textBox_print.Text
                //    += (locket_try_num.GetType() +
                //    " locket_try_num : " +
                //    locket_try_num.ToString() + "\r\n");

                //textBox_print.Text
                //    += (locket_boarding_people.GetType() +
                //    " locket_boarding_people : " +
                //    locket_boarding_people.ToString() + "\r\n");

                //textBox_print.Text
                //    += (locket_feul_mount.GetType() +
                //    " locket_feul_mount : " +
                //    locket_feul_mount.ToString() + "\r\n");

                //textBox_print.Text
                //    += (locket_power.GetType() +
                //    " locket_power : " +
                //    locket_power.ToString() + "\r\n");

                //textBox_print.Text
                //    += (locket_spending_money.GetType() +
                //    " locket_spending_money : " +
                //    locket_spending_money.ToString() + "\r\n");
            }
            #endregion

            // 실습. 문자열 및 배열
            {
                //string[] str = new string[10];
                //str[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
                //str[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
                //str[2] = "질서 있는 퇴장".Contains("퇴").ToString();
                //str[3] = "그 사람의 그림자는 그랬다".Replace("그", "이");
                //str[4] = "삼성 갤럭시".Insert(2, " 애플");
                //str[5] = "오늘은 왠지 더 배고프다.".Remove(7, 1);
                //char[] ch = new char[2] { ',', ' ' };
                //string[] sub_str = "이름, 나이, 전화번호".Split(ch, 3, StringSplitOptions.RemoveEmptyEntries);
                //str[6] = sub_str[0];
                //str[7] = sub_str[1];
                //str[8] = sub_str[2];
                //str[9] = "우리 나라 만세".Substring(3, 2);

                //textBox_print.Text = str[0] + "\r\n";
                //textBox_print.Text += str[1] + "\r\n";
                //textBox_print.Text += str[2] + "\r\n";
                //textBox_print.Text += str[3] + "\r\n";
                //textBox_print.Text += str[4] + "\r\n";
                //textBox_print.Text += str[5] + "\r\n";
                //textBox_print.Text += str[6] + "\r\n";
                //textBox_print.Text += str[7] + "\r\n";
                //textBox_print.Text += str[8] + "\r\n";
                //textBox_print.Text += str[9];
            }

            #region 실습. 문자열
            {
                string str = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
                int special_ch = str.IndexOf('-');
                if (special_ch > -1)
                {
                    str = str.Remove(special_ch);
                }
                special_ch = str.IndexOf("멈추지");
                if (special_ch > -1)
                {
                    str = str.Remove(special_ch, 9);
                }
                special_ch = str.IndexOf("는 중요하지");
                if (special_ch > -1)
                {
                    str = str.Remove(special_ch);
                }

                string[] split_str = str.Split(' ');
                textBox_print.Text = split_str[0] + "\r\n";
                textBox_print.Text += split_str[1] + "\r\n";
                textBox_print.Text += split_str[2];
            }
            #endregion
        }
    }
}
