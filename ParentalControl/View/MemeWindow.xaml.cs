﻿using System;
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
    /// Interaction logic for MemeWindow.xaml
    /// </summary>
    public partial class MemeWindow : Window
    {
        public MemeWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += (ss, ee) =>
            {
                int F6Counter = 0;
                if (ee.Key == Key.F6 && F6Counter == 0)
                {
                    ImageSource imageSource = new BitmapImage(new Uri("pack://application:,,,/resources/Hackerman.jpg"));
                    memePath.Source = imageSource;
                    this.WindowStyle = WindowStyle.SingleBorderWindow;
                }
                
                
            };
        }
    }
}
