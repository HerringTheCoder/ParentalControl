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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParentalControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = App.StaticViewModel;
            
        }


        private void ShowLoginButton_Click(object sender, RoutedEventArgs e)
        {   LoginWindow MyLoginWindow = new LoginWindow();
            this.Visibility = Visibility.Collapsed;
            MyLoginWindow.ShowDialog();
            this.Visibility = Visibility.Visible;

        }
        

        private void LockActivationButton_Click(object sender, RoutedEventArgs e)
        {

            MainViewModel.UpdateTimer();
            TimerWindow timerWindow = new TimerWindow();
            this.Close();
            timerWindow.ShowDialog();
        }

        
    }
}
