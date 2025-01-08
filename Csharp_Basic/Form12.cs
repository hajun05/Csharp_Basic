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
    // 1. 멀티스레드를 생성하는 3가지 방법(backgroundworker, Thread, async) 각각 구현
    // 2. 각 방법들 중 원하는 방법을 골라 파일 검색 실행. 각 방법들에 걸린 시간도 체크
    // 3. OpenFileDialog로 파일 경로 선택, 해당 경로의 특정 확장자의 모든 파일을 조회
    // 4. 조회한 파일 목록을 gridview로 출력
    // 5. 예외처리도 구현

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
            try
            {
                textBox1.Text = "";
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;
                    string file_content = await ReadFileAsync(path);
                    textBox1.Text = file_content;
                }
                //string path = string.Format(@"{0}", textBox2.Text.Replace("\"", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }

            
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
