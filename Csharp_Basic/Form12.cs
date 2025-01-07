using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Basic
{
    public partial class Form12 : Form
    {
        StreamReader sr;
        public Form12()
        {
            InitializeComponent();
        }

        public async Task<string> ReadFileAsync(string path)
        {
            string content = File.ReadAllText(path);

            return content;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string file_content = await ReadFileAsync(path);
                textBox1.Text = file_content;
            }
            //string path = string.Format(@"{0}", textBox2.Text.Replace("\"", ""));

            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string path = textBox2.Text;
            sr = new StreamReader(path);
            string file_content = await sr.ReadToEndAsync();
        }

    //    OpenFileDialog openFileDialog = new OpenFileDialog();
    //    string fileName = "";
    //    string result = "";

    //        if (openFileDialog.ShowDialog() == DialogResult.OK)
    //        {
    //            fileName = openFileDialog.FileName;

    //            using (StreamReader streamReader = File.OpenText(fileName))
    //            {
    //                result = await streamReader.ReadToEndAsync();
    //}

    //textBox1.Text = result;
    //        }
    }
}
