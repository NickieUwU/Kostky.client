﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kostky.server;

namespace Kostky.client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Dice.MakeCube(canvas);
            Dice.MakeDots(canvas);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new();
            Dice.Throw(canvas, random);
        }
    }
}