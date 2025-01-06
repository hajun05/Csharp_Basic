using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace Csharp_Basic
{
    public partial class Form9 : Form
    {
        BackgroundWorker worker;

        public Form9()
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
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(30);
                this.worker.ReportProgress(i);
            }
        }
        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value += 1;
            // e.ProgressPercentage에 worker.ReportProgress의 반환값이 저장.
            progressBar1.Value = e.ProgressPercentage;
        }
        void Worker_Complete(object sender, EventArgs e)
        {
            MessageBox.Show("완료됨");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 단일 스레드. 반복문 실행시 반복마다 Context Switching 발생
            //while (true)
            //{
            //    if (progressBar1.Value < 100)
            //    {
            //        progressBar1.Value += 1;
            //    }
            //}

            // BackgroundWorker 동작, BackgroundWorker가 실행중이 아니라면
            if (!this.worker.IsBusy)
            {
                this.worker.RunWorkerAsync();
            }

            //if (timer1.Enabled)
            //{
            //    timer1.Stop();
            //}
            //else
            //{
            //    progressBar1.Value = 0;
            //    timer1.Start();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
            }
        }
    }
}
