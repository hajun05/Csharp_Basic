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
    }
}
