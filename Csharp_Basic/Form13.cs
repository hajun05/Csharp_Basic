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

namespace Csharp_Basic
{
    public delegate void EventDelegate(string message);

    public partial class Form13 : Form
    {
        Thread thread;
        EventManager eventManager;

        public Form13()
        {
            InitializeComponent();
            eventManager = new EventManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "이벤트 추가";
            thread = new Thread(() => eventManager.EventAdd(message, ShowMessage));
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "이벤트 추가";
            thread = new Thread(() => eventManager.EventRemove(message, ShowMessage));
            thread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "이벤트 추가";
            thread = new Thread(() => eventManager.EventInvoke(message, ShowMessage));
            thread.Start();
            
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }

    public class EventManager : Form
    {
        public event EventDelegate Event;
        // 이벤트명, 이벤트 대리자 딕셔너리
        public Dictionary<string, EventDelegate> eventDict;

        public EventManager()
        {
            eventDict = new Dictionary<string, EventDelegate>();
        }

        // 이벤트 이름과 대리자(메소드) 추가
        public void EventAdd(string eventName, EventDelegate eventToAdd)
        {
            Event = eventToAdd;
            // 똑같인 키값 존재 여부 확인
            if (!eventDict.ContainsKey(eventName))
            {
                eventDict.Add(eventName, Event);
            }
            else
            {
                eventToAdd("이미 존재하는 이벤트입니다.");
                // eventDict[eventName] += Event // 여러 이벤트 등록도 가능
            }
        }

        public void EventRemove(string eventName, EventDelegate eventToRemove)
        {
            Event = eventToRemove;
            if (eventDict.ContainsKey(eventName))
            {
                eventDict.Remove(eventName);
            }
            else
            {
                eventToRemove("존재하지 않는 이벤트입니다.");
            }
        }

        public void EventInvoke(string eventName, EventDelegate eventToInvoke)
        {
            Event = eventToInvoke;
            if(eventDict.ContainsKey(eventName))
            {
                eventDict[eventName].Invoke(eventName);
                // == eventDict[eventName](eventName);
                // this 안되는 이유 : 대리자.invoke -> 대리자 즉각 실행. 좀더 안전하게 대리자 실행, UI 접근.
            }
            else
            {
                eventToInvoke("존재하지 않는 이벤트입니다.");
            }
        }
    }
}
