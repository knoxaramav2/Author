﻿using Author.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Author
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            GeneralTab.Focus();
        }

        private void ActorViewSelected(object sender, RoutedEventArgs e)
        {
            DataContext = new ActorViewModel();
        }

        private void FactsViewSelected(object sender, RoutedEventArgs e)
        {
            DataContext = new FactViewModel();
        }

        private void GeneralViewSelected(object sender, RoutedEventArgs e)
        {
            DataContext = new GeneralViewModel();
        }

        private void RelationsViewSelected(object sender, RoutedEventArgs e)
        {
            DataContext = new RelationsViewModel();
        }
    }

    public class GraphControl : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        
    }
}
