using System;
using System.Collections.Generic;
using System.Windows.Threading;


namespace ParentalControl
{
    class TimerViewModel : BaseViewModel
    {
        public int TimeLeft { get; set; } = App.StaticTimer.TimeLeft;

        public TimerViewModel()
            {   
                DispatcherTimer dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Tick += DispatcherTimer_Tick;
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Start();
             }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            TimeLeft--;
        }


    }
}
