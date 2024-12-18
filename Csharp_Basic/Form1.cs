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

            //TestVariableAndCasting();

            //TestStringAndArray();

            //TestString("멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자");

            //int divisor = 123;
            //int dividend = 5;
            //int[] division = TestFuntion_Division(divisor, dividend);
            //textBox_print.Text = 
            //    String.Format($"{divisor} / {dividend} -> 몫 : {division[0].ToString()}, 나머지 : {division[1].ToString()}\r\n");

            bool prediction_coin_side = false;
            textBox_print.Text = "동전 면 예측 : ";
            if (prediction_coin_side == false)
                textBox_print.Text += "뒷면\r\n";
            else
                textBox_print.Text += "앞면\r\n";

            textBox_print.Text += "동전 던지기 실행.\r\n";
            bool result_coin_side = CoinTossPredictionGame(prediction_coin_side);
            if (result_coin_side == false)
                textBox_print.Text += "예측 실패, 패배.\r\n";
            else
                textBox_print.Text += "예측 성공, 승리.\r\n";
        }

        void TestVariableAndCasting() // 실습. 변수 및 캐스팅
        {
            byte locket_engine_num = 4;
            short locket_try_num = 3;
            int locket_boarding_people = 3;
            float locket_feul_mount = 100000.5f;
            double locket_power = 300000.582;
            decimal locket_spending_money = 54294553.299845m;

            textBox_print.Text
                += (locket_engine_num.GetType() +
                " locket_engine_num : " +
                locket_engine_num.ToString() + "\r\n");

            textBox_print.Text
                += (locket_try_num.GetType() +
                " locket_try_num : " +
                locket_try_num.ToString() + "\r\n");

            textBox_print.Text
                += (locket_boarding_people.GetType() +
                " locket_boarding_people : " +
                locket_boarding_people.ToString() + "\r\n");

            textBox_print.Text
                += (locket_feul_mount.GetType() +
                " locket_feul_mount : " +
                locket_feul_mount.ToString() + "\r\n");

            textBox_print.Text
                += (locket_power.GetType() +
                " locket_power : " +
                locket_power.ToString() + "\r\n");

            textBox_print.Text
                += (locket_spending_money.GetType() +
                " locket_spending_money : " +
                locket_spending_money.ToString() + "\r\n");
        }
        void TestStringAndArray() // 실습. 문자열 및 배열
        {
            string[] str = new string[10];
            str[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            str[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            str[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            str[3] = "그 사람의 그림자는 그랬다".Replace("그", "이");
            str[4] = "삼성 갤럭시".Insert(2, " 애플");
            str[5] = "오늘은 왠지 더 배고프다.".Remove(7, 1);
            char[] ch = new char[2] { ',', ' ' };
            string[] sub_str = "이름, 나이, 전화번호".Split(ch, 3, StringSplitOptions.RemoveEmptyEntries);
            str[6] = sub_str[0];
            str[7] = sub_str[1];
            str[8] = sub_str[2];
            str[9] = "우리 나라 만세".Substring(3, 2);

            textBox_print.Text = str[0] + "\r\n";
            textBox_print.Text += str[1] + "\r\n";
            textBox_print.Text += str[2] + "\r\n";
            textBox_print.Text += str[3] + "\r\n";
            textBox_print.Text += str[4] + "\r\n";
            textBox_print.Text += str[5] + "\r\n";
            textBox_print.Text += str[6] + "\r\n";
            textBox_print.Text += str[7] + "\r\n";
            textBox_print.Text += str[8] + "\r\n";
            textBox_print.Text += str[9];
        }
        void TestString(string str) // 실습. 문자열
        {
            string str1;
            string[] str2 = new string[3];
            string str3;

            // 1번 항목 수행
            int special_ch = str.IndexOf("-공자");
            str1 = str.Remove(special_ch);

            // 2번 항목 수행
            special_ch = str.IndexOf("얼마나");
            if (special_ch > -1)
            {
                str2 = str.Substring(special_ch, 11).Split(' ');
            }

            // 3번 항목 수행
            str3 = str.Replace(".", "");
            str3 = str3.Replace("-", "");
            str3 = str3.Replace(" ", ",");

            // 출력
            textBox_print.Text = str1 + "\r\n";
            textBox_print.Text += str2[0] + "\r\n";
            textBox_print.Text += str2[1] + "\r\n";
            textBox_print.Text += str2[2] + "\r\n";
            textBox_print.Text += str3 + "\r\n";
        }
        int[] TestFuntion_Division(int divisor, int dividend) // 실습. 함수
        {
            int[] result = new int[2];
            result[0] = divisor / dividend;
            result[1] = divisor % dividend;

            return result;
        }
        bool CoinTossPredictionGame(bool prediction_coin_side)
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
    }
}
