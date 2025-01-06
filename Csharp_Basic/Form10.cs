using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.IO;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace Csharp_Basic
{
    //폼에 TextBox, Button, ListBox를 추가하세요.
    //TextBox에 디렉토리 경로를 입력받고, Button을 클릭하면 그 디렉토리와 하위 디렉토리에서 특정 확장자의 파일을 검색하세요.
    //특정 확장자도 TextBox로 입력을 받아주세요.
    //BackgroundWorker를 사용하여 파일 검색 작업을 비동기로 수행하세요.
    //검색된 파일 목록을 ListBox에 표시하세요.
    public partial class Form10 : Form
    {
        BackgroundWorker worker;
        public Form10()
        {
            InitializeComponent();

            this.worker = new BackgroundWorker();
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;

            this.worker.DoWork += new DoWorkEventHandler(Worker_Dowork);
            this.worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_Complete);
        }
        void Worker_Dowork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string[] textBox_input = textBox1.Text.Split(' ');
                string file_directory = string.Format(@"{0}", textBox_input[0]);
                string file_extension = string.Format($"*.{textBox_input[1].ToLower()}");

                // 하위 폴더까지 해당 확장자의 모든 파일을 가져옴
                string[] fileInfos = Directory.GetFiles(file_directory, file_extension, SearchOption.AllDirectories);
                int file_num = fileInfos.Length;

                for (int i = 0; i < file_num; i++)
                {
                    // 현재 디렉토리 기준 앞 내용 제거, 하위 폴더와 파일 디렉토리만 출력
                    int last_index = fileInfos[i].Length;
                    for (int j = 0; j < 2; j++)
                    {
                        last_index = fileInfos[i].LastIndexOf("\\", last_index - 1);
                    }

                    // ReportProgress로 퍼센트와 progress할 내용 입력
                    if (i + 1 < file_num)
                    {
                        this.worker.ReportProgress((100 / file_num) * (i + 1), fileInfos[i].Substring(last_index));
                    }
                    else
                    {
                        this.worker.ReportProgress(100, fileInfos[i].Substring(last_index));
                    }
                    Thread.Sleep(50);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message.ToString());
            }
        }
        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            File_List.Items.Add((string)e.UserState);
        }
        void Worker_Complete(object sender, EventArgs e)
        {
            MessageBox.Show("파일 검색 완료");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.worker.IsBusy)
            {
                this.worker.RunWorkerAsync();
            }
        }
    }
}
