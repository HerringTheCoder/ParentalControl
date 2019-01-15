using System;
using System.Collections.Generic;
using System.Windows.Threading;


namespace ParentalControl
{
    class TimerViewModel : BaseViewModel
    {
        public int TimeLeft { get; set; } = App.StaticTimer.TimeLeft;
       public DispatcherTimer DispatchTimer { get; set; }= new DispatcherTimer();
        public TimerViewModel()
            {
              DispatchTimer.Tick += DispatcherTimer_Tick;          
              DispatchTimer.Interval = new TimeSpan(0, 0, 1);
              DispatchTimer.Start();
             }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (TimeLeft != 0)
            {
                TimeLeft--;
            }
        //    else
        //    {
        //        DispatchTimer.Stop();
        //    }
        }


    }
}
