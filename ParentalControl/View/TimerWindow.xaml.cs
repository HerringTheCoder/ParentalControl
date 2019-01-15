using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ParentalControl
{
    /// <summary>
    /// Interaction logic for TimerWindow.xaml
    /// </summary>
    public partial class TimerWindow : Window
    {
        public TimerWindow()
        {
            TimerViewModel timerViewModel = new TimerViewModel();
            InitializeComponent();
            DataContext = timerViewModel;
        }

        private void TimerBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToInt32(TimerBox.Text) == 0)
            {
                LockWindow lockWindow = new LockWindow();
                this.Close();
                lockWindow.Show();
            }
        }
    }
}
