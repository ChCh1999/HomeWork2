using System;

namespace HomeWork4._1
{
    //参数：当前时间
    public class TimeOfNow : EventArgs
    {
        public System.DateTime Today = DateTime.Now;
    }
    //声明委托
    public delegate void AlarmOfTime(object sender, TimeOfNow e);
    public class Clock
    {
        public event AlarmOfTime alarm;
        public int AlarmHour { set; get; }
        public int AlarmMinute { set; get; }
        //输入时间设置闹钟
        public void SetClock()
        {
            Console.WriteLine("设置闹钟");
            SetHour();
            SetMinute();
        }
        private void SetHour()
        {
            Console.WriteLine("输入时间（时0~23）： ");
            AlarmHour = int.Parse(Console.ReadLine());
            if (AlarmHour < 0 || AlarmHour > 23)
            {
                Console.WriteLine("时间（时）输入无效");
                Console.Write("重新");
                SetHour();
            }
            return;
        }
        private void SetMinute()
        {
            Console.WriteLine("输入时间（分0~59）： ");
            AlarmMinute = int.Parse(Console.ReadLine());
            if (AlarmMinute < 0 || AlarmMinute > 59)
            {
                Console.WriteLine("时间（分）输入无效");
                Console.Write("重新");
                SetMinute();
            }
            return;
        }
        //监听时间
        public void WatchTime()
        {
            TimeOfNow time = new TimeOfNow();
            int Hour = time.Today.Hour;
            int Minute = time.Today.Minute;
            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                time.Today = DateTime.Now;
                alarm(this, time);
            }
            else
            {
                System.Threading.Thread.Sleep(10000);
                WatchTime();
            }
        }
    }
    public class useAlarmClock
    {
        static void Main()
        {
            //创建时钟对象
            var clock = new Clock();
            clock.SetClock();
            clock.alarm += myAlarm;
            clock.WatchTime();
        }
        static void myAlarm(object sender,TimeOfNow t)
        {
            Console.WriteLine(t.Today.Hour+":"+t.Today.Minute+" 到了！！");
        }
    }
}
