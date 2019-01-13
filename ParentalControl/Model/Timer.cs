
using System.ComponentModel;

namespace ParentalControl
{
    class Timer : INotifyPropertyChanged
    {
        public int TimeLeft { set; get; }
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
