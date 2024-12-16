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

            byte rocket_engine_num = 4;
            short rocket_try_num = 3;
            int rocket_boarding_people = 3;
            float rocket_feul_mount = 100000.5f;
            double rocket_spending_money_all_Korea = 300003009220.582;
            decimal rocket_spending_money_all_America = 54293593857332111454553.299845m;

            textBox_print.Text
                += (rocket_engine_num.GetType() +
                " locket_engine_num : " +
                rocket_engine_num.ToString() + "\r\n");

            textBox_print.Text
                += (rocket_try_num.GetType() +
                " locket_try_num : " +
                rocket_try_num.ToString() + "\r\n");

            textBox_print.Text
                += (rocket_boarding_people.GetType() +
                " locket_boarding_people : " +
                rocket_boarding_people.ToString() + "\r\n");

            textBox_print.Text
                += (rocket_feul_mount.GetType() +
                " locket_feul_mount : " +
                rocket_feul_mount.ToString() + "\r\n");

            textBox_print.Text
                += (rocket_spending_money_all_Korea.GetType() +
                " locket_power : " +
                rocket_spending_money_all_Korea.ToString() + "\r\n");

            textBox_print.Text
                += (rocket_spending_money_all_America.GetType() +
                " locket_spending_money : " +
                rocket_spending_money_all_America.ToString() + "\r\n");
        }
    }
}
