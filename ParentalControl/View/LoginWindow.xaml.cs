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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.DataContext = App.StaticViewModel;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = (MainWindow)Application.Current.MainWindow; //Casting the current MainWindow state to an object
            if (App.StaticViewModel.CheckCredentials() == true)
            {   
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong credentials. Try again...");
            }
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {   
            App.StaticViewModel.Password = passwordBox.Password;
            LoginButton.IsEnabled = (String.IsNullOrWhiteSpace(passwordBox.Password)) ? false : true;    
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
