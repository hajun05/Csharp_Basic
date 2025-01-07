using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Csharp_Basic
{
    public partial class Form11 : Form
    {
        Thread[] thread_racer = new Thread[5];
        ProgressBar[] progressBars = new ProgressBar[5];
        int[] race_spand_time = new int[5];
        Random random = new Random();

        public Form11()
        {
            InitializeComponent();

            this.progressBars[0] = progressBar1;
            this.progressBars[1] = progressBar2;
            this.progressBars[2] = progressBar3;
            this.progressBars[3] = progressBar4;
            this.progressBars[4] = progressBar5;

            for (int i = 0; i < 5; i++)
            {
                // 람다식에서의 클로저 문제. 람다식 내부에서는 i 변수의 참조를 캡처, 마지막 루프 당시의 i를 참조하기 때문
                int racerIndex = i;
                thread_racer[racerIndex] = new Thread(() => ThreadRace(racerIndex));
            }

            for(int j = 0; j < 5; j++)
            {
                int racerIndex = j;
                thread_racer[racerIndex].Start();
            }

            // 메인 스레드를 대기시켜버리며 invoke가 재대로 수행 불가
            //for (int i = 0; i < 5; i++)
            //{
            //    thread_racer[i].Join();
            //}
        }

        public void ThreadRace(int racer_num)
        {
            //progressBar.Invoke(new Action(() =>
            //{
            //    progressBar.Value = nprogress;
            //    if (nprogress == 100)
            //    {
            //        textBox.Invoke(new Action(() => textBox.Text += $"{playerNumber} arrival time : {s[playerNumber]}ms\r\n"));
            //    }
            //}));

            while (true)
            {
                int race_time_ms = random.Next(100, 1001);
                race_spand_time[racer_num] += race_time_ms;
                if (progressBars[racer_num].InvokeRequired)
                {
                    if (progressBars[racer_num].Value < 100)
                    {
                        Thread.Sleep(race_time_ms);
                        progressBars[racer_num].Invoke(new MethodInvoker(() =>
                        {
                            progressBars[racer_num].Value += 5;
                        }));
                    }
                    else
                    {
                        int s = race_spand_time[racer_num] / 1000;
                        int ms = race_spand_time[racer_num] % 1000;
                        progressBars[racer_num].Invoke(new MethodInvoker(() =>
                        {  
                            textBox1.Text += string.Format($"Thread {racer_num + 1}가 도착했습니다. " +
                            $"소모 시간 {s}.{ms}초.\r\n");
                        }));
                        break;
                    }
                }
                else
                {
                    if (progressBars[racer_num].Value < 100)
                    {
                        Thread.Sleep(race_time_ms);
                        progressBars[racer_num].Value += 5;
                    }
                    else
                    {
                        TimeSpan timeSpan = TimeSpan.FromMilliseconds(race_spand_time[racer_num]);
                        textBox1.Text += string.Format($"Thread {racer_num + 1}가 도착했습니다. " +
                            $"소모 시간 {timeSpan.TotalSeconds}.{timeSpan.TotalMilliseconds:D3}초.\r\n");
                        break;
                    }
                }
            }
        }
    }
}
