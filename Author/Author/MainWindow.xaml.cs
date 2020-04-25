using Author.Models;
using Author.ViewModels;
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
        #region private fields

        #endregion

        public MainWindow()
        {
            InitializeComponent();
            InitializeGui();
            InitializeGlobals();
        }

        private void InitializeGlobals()
        {
        }

        private void InitializeGui()
        {
            GeneralTab.Focus();
        }

        #region TabSwitch

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

        #endregion

        #region AddTabItem

        private void AddNewFact(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewActor(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewGeneral(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewRelation(object sender, RoutedEventArgs e)
        {

        }

        #endregion
    }

    public class GraphControl : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        
    }
}
