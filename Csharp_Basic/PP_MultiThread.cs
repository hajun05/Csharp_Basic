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
        // combobox에 입력할 아이템 리스트. 사용할 멀티 스레드 종류
        string[] comboboxList;

        public PP_MultiThread()
        {
            InitializeComponent();

            // Backgroundworker, Thread, async/await
            comboboxList = new string[] { "BackgroundWorker", "Thread", "async/await" };
            comboBoxMultiThread.Items.AddRange(comboboxList);
        }

        private void buttonStartFileSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // 파일을 탐색할 폴더 경로
                string directoryPath = "";
                // 멀티 스레드를 구현할 방식. 별개의 클래스로 멀티 스레드 구현 수행
                string searchMethod = comboBoxMultiThread.SelectedItem as string;
                
                // 멀티 스레드 구현 방식을 고르지 않은 경우 예외 던짐
                if (!comboboxList.Contains(searchMethod))
                    throw new Exception("파일 탐색에 사용할 멀티 스레드 방식을 선택하십시요.");

                // 선택한 멀티 스레드 구현 방식에 따른 멀티스레드 구현
                switch (searchMethod)
                {
                    case var method when method == comboboxList[0]: // BackgroundWorker
                        DirectoryPath(ref directoryPath);
                        FileSearchBackgroundWorker backgroundWorker 
                            = new FileSearchBackgroundWorker(directoryPath);
                        backgroundWorker.StartWork();
                        break;
                    case var method when method == comboboxList[1]: // Thread
                        DirectoryPath(ref directoryPath);
                        FileSearchTread thread = new FileSearchTread();
                        break;
                    case var method when method == comboboxList[2]: // async/await
                        DirectoryPath(ref directoryPath);
                        FileSearchAsyncAwait asyncAwait = new FileSearchAsyncAwait();
                        break;
                }
                textBoxDirectory.Text = directoryPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 파일을 탐색할 폴더 위치 선정 메소드. FolderBrowserDialog 클래스 사용.
        private void DirectoryPath(ref string directoryPath)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            directoryPath = folderBrowserDialog.SelectedPath;
        }
    }

    // BackgroundWorker 구현 클래스
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

    // Thread 구현 클래스
    public class FileSearchTread
    {

    }

    // async/await 구현 클래스
    public class FileSearchAsyncAwait
    {

    }
}
