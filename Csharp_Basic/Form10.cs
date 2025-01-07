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

        string[] extension = new string[] // combobox 확장자
        {
                    "*.bmp","*.jpg","*.tif", "*.gif","*.png","*.txt","*.pdf"
        };

        public Form10()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(extension); // combobox 확장자 초기화

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
                //string[] textBox_input = textBox1.Text.Split(' ');
                //string file_directory = string.Format(@"{0}", textBox_input[0]);
                //string file_extension = string.Format($"*.{textBox_input[1].ToLower()}");
                string file_directory = textBox1.Text;
                string file_extension = comboBox1.SelectedItem as string; // 직접 입력 대신 combobox로 확장자 입력

                // 하위 폴더까지 해당 확장자의 모든 파일을 가져옴
                string[] fileInfos = Directory.GetFiles(file_directory, file_extension, SearchOption.AllDirectories);
                int file_num = fileInfos.Length;

                if (file_num == 0)
                {
                    e.Result = "Zero";
                }
                else
                {
                    for (int i = 0; i < file_num; i++)
                    {
                        // 현재 디렉토리 기준 앞 내용 제거, 하위 폴더와 파일 디렉토리만 출력
                        int last_index = fileInfos[i].Length;
                        for (int j = 0; j < 2; j++)
                        {
                            last_index = fileInfos[i].LastIndexOf("\\", last_index - 1);
                        }

                        // 마지막에 progress가 100이 되도록 round 반올림 -> 소수점 연산은 정수 연산보다 느림
                        //this.worker.ReportProgress((int)Math.Round((100.0 / file_num) * (i + 1)), fileInfos[i].Substring(last_index));
                        // ReportProgress로 퍼센트와 progress할 내용 입력
                        // 곱하기가 나누기보다 앞에 나와야 소수점 문제 방지.
                        this.worker.ReportProgress((i + 1) * 100 / file_num, fileInfos[i].Substring(last_index + 1));
                        Thread.Sleep(50);
                    }
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
            }
        }
        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            // Dowork에서 UI 컨트롤을 직접 업데이터하려고 하면 UI스레드와 충돌, 크로스 스레드 오류 발생.
            // 가능한 UI 컨트롤 업데이트는 ProgressChanged에서 처리
            File_List.Items.Add(e.UserState.ToString());
        }
        void Worker_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("다시 입력해주세요");
            }
            else if (e.Result.ToString() == "Zero")
            {

                MessageBox.Show("찾는 형식의 파일이 존재하지 않습니다.");
            }
            else
            {
                MessageBox.Show("작업 완료");
            }
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
