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
using System.Diagnostics;

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

            // 메인 스레드를 대기시켜버리면 invoke가 재대로 수행 불가
            //for (int i = 0; i < 5; i++)
            //{
            //    thread_racer[i].Join();
            //}
        }

        public void ThreadRace(int racer_num)
        {
            // 정확한 소모시간 계산 위한 객체 선언
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (true)
            {
                int race_time_ms = random.Next(100, 1001);
                //race_spand_time[racer_num] += race_time_ms;

                // 스레드 경쟁상태 방지.
                // main이 아닌 스레드에서 호출할 것이 확실한 상황에선 굳이 현재 메소드를 호출한 스레드를 확인할 필요 없음.
                //bool check = progressBars[racer_num].InvokeRequired;
                //if (check)
                {
                    if (progressBars[racer_num].Value < 100)
                    {
                        Thread.Sleep(race_time_ms);
                        // UI 자체 지정(this)
                        this.Invoke(new MethodInvoker(() =>
                        {
                            progressBars[racer_num].Value += 5;
                        }));
                    }
                    else
                    {
                        //int s = race_spand_time[racer_num] / 1000;
                        //int ms = race_spand_time[racer_num] % 1000;
                        stopwatch.Stop();
                        double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
                        // UI의 특정 요소 콕 집어서 지정(this { progressBars })
                        progressBars[racer_num].Invoke(new MethodInvoker(() =>
                        {  
                            textBox1.Text += string.Format($"Thread {racer_num + 1}가 도착했습니다. " +
                            $"소모 시간 {elapsedSeconds:F2}초.\r\n");
                        }));
                        break;
                    }
                }
                //else
                //{
                //    if (progressBars[racer_num].Value < 100)
                //    {
                //        Thread.Sleep(race_time_ms);
                //        progressBars[racer_num].Value += 5;
                //    }
                //    else
                //    {
                //        TimeSpan timeSpan = TimeSpan.FromMilliseconds(race_spand_time[racer_num]);
                //        textBox1.Text += string.Format($"Thread {racer_num + 1}가 도착했습니다. " +
                //            $"소모 시간 {timeSpan.TotalSeconds}.{timeSpan.TotalMilliseconds:D3}초.\r\n");
                //        break;
                //    }
                //}
            }

        }
    }
}
