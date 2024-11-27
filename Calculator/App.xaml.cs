﻿using System.Configuration;
using System.Data;
using System.Windows;
using Calculator.ViewModels;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            

            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = new MainViewModel();


            mainWindow.Show();
            base.OnStartup(e);
        }

    }

}
