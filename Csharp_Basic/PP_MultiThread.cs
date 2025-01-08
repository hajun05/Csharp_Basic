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
    // 1. 멀티스레드를 생성하는 3가지 방법(Backgroundworker, Thread, async/await) 각각 구현
    // 2. 각 방법들 중 원하는 방법을 골라 파일 검색 실행. 각 방법들에 걸린 시간도 체크
    // 3. 파일 경로 선택, 해당 경로의 특정 확장자의 모든 파일을 조회
    // 4. 조회한 파일 목록을 gridview로 출력
    // 5. 예외처리도 구현
    public partial class PP_MultiThread : Form
    {
        string[] comboboxList;

        public PP_MultiThread()
        {
            InitializeComponent();
            comboboxList = new string[] { "Backgroundworker", "Thread", "async/await" };
            comboBoxMultiThread.Items.AddRange(comboboxList);
        }

        private void buttonStartFileSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                string directoryPath = folderBrowserDialog.SelectedPath;
                string searchMethod = comboBoxMultiThread.SelectedItem as string;
                
                switch (searchMethod)
                {
                    case var method when method == comboboxList[0]:
                        FileSearchBackgroundWorker backgroundWorker 
                            = new FileSearchBackgroundWorker(directoryPath);
                        backgroundWorker.StartWork();
                        break;
                    case var method when method == comboboxList[1]:
                        FileSearchTread thread = new FileSearchTread();
                        break;
                    case var method when method == comboboxList[2]:
                        FileSearchAsyncAwait asyncAwait = new FileSearchAsyncAwait();
                        break;
                    default:
                        throw new Exception("파일 탐색에 사용할 멀티 스레드 방식을 선택하십시요.");
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class FileSearchBackgroundWorker
    {
        BackgroundWorker worker;
        string fileDirectory;

        public FileSearchBackgroundWorker(string fileDirectory)
        {
            this.worker = new BackgroundWorker();
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;

            this.worker.DoWork += new DoWorkEventHandler(Worker_Dowork);
            this.worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_Complete);

            this.fileDirectory = fileDirectory;
        }

        public void StartWork()
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        void Worker_Dowork(object sender, DoWorkEventArgs e)
        {
        }
        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }
        void Worker_Complete(object sender, RunWorkerCompletedEventArgs e)
        { 
        }
    }

    public class FileSearchTread
    {

    }

    public class FileSearchAsyncAwait
    {

    }
}
