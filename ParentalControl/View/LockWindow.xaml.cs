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
    /// Interaction logic for LockWindow.xaml
    /// </summary>
    public partial class LockWindow : Window
    {
        public LockWindow()
        {
            InitializeComponent();
            this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Input, new Action(() => Focus()));
            this.Closing += new System.ComponentModel.CancelEventHandler(LockWindow_Closing);
        }
        private void LockWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void SecretButton_Click(object sender, RoutedEventArgs e)
        {
            MemeWindow memeWindow = new MemeWindow();
            this.Visibility = Visibility.Collapsed;
            this.Close();
            memeWindow.Show();

        }

        private void NoSecretButton_Click(object sender, RoutedEventArgs e)
        {
            lockTextBlock.Text = "Well, sucks to be you :(";
            LoginWindow loginWindow = new LoginWindow();
            this.Visibility = Visibility.Collapsed;
            loginWindow.ShowDialog();
            if (App.StaticViewModel.CheckCredentials() == true)
            {               
                this.Close();
                Application.Current.Shutdown();
            }
            else
            {
                MessageBox.Show("Do. Or do not. There is no try. (Parent not detected)");
                this.Visibility = Visibility.Visible;
            }

            
           
        }
    }
}
