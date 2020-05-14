using Author.Models;
using Author.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Author
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region private fields

        private DataContext _context;

        #endregion

        #region PublicFields
        public DataContext Context;
        public HistoryModel Model;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            InitializeGui();
            InitializeGlobals();

            for (var i = 0; i < 20; ++i)
            {
                var node = new HistoryLine
                {
                    Title = $"Test {i}"
                };
                Model.History.Add(node);
            }

            HistoryControl.ItemsSource = Model.History;

            DataContext = new ActorViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ClearValue(SizeToContentProperty);
            WindowRoot.ClearValue(WidthProperty);
            WindowRoot.ClearValue(HeightProperty);

            Test();
        }

        private void InitializeGlobals()
        {
            Context = _context = new DataContext();
            Model = new HistoryModel();
        }

        private void InitializeGui()
        {
            ActorTab.Focus();
        }

        private void Test()
        {
            AddNewActor(null, null);
            AddNewActor(null, null);
            AddNewActor(null, null);
            AddNewActor(null, null);
            AddNewActor(null, null);
        }
        
        #region TabSwitch

        private void ActorViewSelected(object sender, RoutedEventArgs e)
        {
            DataContext = new ActorViewModel();
            //WindowRoot.Background = Brushes.Red;
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
            _context.historyView.AddHistoryLayer("Test");
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

    public class DataContext
    {
        #region private fields

        private HistoryViewModel _historyView;

        #endregion

        #region PublicFields
        public HistoryViewModel historyView;
        #endregion

        public DataContext()
        {
            historyView = _historyView = new HistoryViewModel();
        }
   
    }

    public class GraphControl : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class MModel
    {
        public ObservableCollection<MNode> Nodes;

        public MModel()
        {
            Nodes = new ObservableCollection<MNode>();
        }
    }

    public class MNode 
    {
        public string Title { get; set; }
    }
}
