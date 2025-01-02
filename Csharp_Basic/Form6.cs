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
    public partial class Form6 : Form
    {
        public void RefArray(ref int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i;
            }
        }

        public void OutArray(out int[] ints, int n)
        {
            ints = new int[n];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = -i;
            }
        }

        public Form6()
        {
            InitializeComponent();

            int[] ref_ints = new int[5];
            RefArray(ref ref_ints);
            for (int i = 0; i < ref_ints.Length; i++)
            {
                textBox1.Text += string.Format($"{ref_ints[i]} ");
            }

            OutArray(out int[] out_ints, 5);
            for (int i = 0; i < out_ints.Length; i++)
            {
                textBox2.Text += string.Format($"{out_ints[i]} ");
            }
        }
    }
}
