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
            this.Closing += new System.ComponentModel.CancelEventHandler(LockWindow_Closing);
        }
        void LockWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void SecretButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NoSecretButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
