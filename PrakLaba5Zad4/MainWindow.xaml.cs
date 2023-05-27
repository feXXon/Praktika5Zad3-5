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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrakLaba5Zad4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double X = 0.5; 
            int N = 5;
            double result = 0;

            for (int i = 1; i <= N; i++)
            {
                double term = Math.Pow(-1, i - 1) * Math.Pow(X, i) / i;
                result += term;
            }

            result += X;

            txt1.Text = ($"{1 + X}: {result}");
        }
    }
}
