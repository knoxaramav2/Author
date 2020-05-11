using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;

namespace Author.Models
{
    public class HistoryModel : IAuthorModel
    {
        #region private fields
        private ObservableCollection<HistoryLine> _history;
        #endregion

        #region public fields
        public ObservableCollection<HistoryLine> History
        {
            get
            {
                return _history;
            }

            set
            {
                if (_history == value) return;
                _history = value;
                RaisePropertyChangedEvent("History");
            }
        }
        #endregion

        public HistoryModel()
        {
            _history = new ObservableCollection<HistoryLine>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddNewHistoryLine()
        {
            
        }

        private void RaisePropertyChangedEvent(string propertyName)
        {
            if (PropertyChanged == null) return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class HistoryLine
    {
        private List<KeyFrame> _frames;

        internal Brush _color;

        internal HistoryLine()
        {
            _color = Brushes.White;
            _frames = new List<KeyFrame>();
        }

        internal bool SetKeyFrame()
        {

            return true;
        }

        internal List<KeyFrame> GetKeyFrames()
        {

            return null;
        }


    }

    public class KeyFrame
    {

    }
}
