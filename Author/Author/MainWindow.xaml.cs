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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ClearValue(SizeToContentProperty);
            WindowRoot.ClearValue(WidthProperty);
            WindowRoot.ClearValue(HeightProperty);
        }

        private void InitializeGlobals()
        {
        }

        private void InitializeGui()
        {
            ActorTab.Focus();
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
            ActorStackPanel.Children.Add(CreateActorRow());
        }

        private void AddNewGeneral(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewRelation(object sender, RoutedEventArgs e)
        {

        }

        #endregion

        #region TabItemFunctions

        public void LoadActorPage(string guid)
        {

        }

        #endregion

        #region helpers
        string GenerateUID()
        {
            var guid = Guid.NewGuid();

            return guid.ToString();
        }
        
        UIElement CreateActorRow()
        {
            var elt = new StackPanel();
            var row = new Button();

            elt.Uid = GenerateUID();
            row.Content = "New Actor";
            row.Click += new RoutedEventHandler((e,sender) => LoadActorPage(elt.Uid));

            elt.HorizontalAlignment = HorizontalAlignment.Center;

            elt.Children.Add(row);

            return elt;
        }
        #endregion
    }

    public class GraphControl : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        
    }
}
