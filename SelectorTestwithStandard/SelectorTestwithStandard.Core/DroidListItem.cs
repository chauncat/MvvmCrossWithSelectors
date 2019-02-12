using MvvmCross.ViewModels;

namespace SelectorTestwithStandard.Core
{
    public class DroidListItem : MvxNotifyPropertyChanged
    {
        private bool _one;
        private bool _two;
        private bool _three;

        public bool One
        {
            get => _one;
            set
            {
                _one = value;
                RaisePropertyChanged();
            }
        }

        public bool Two
        {
            get => _two;
            set
            {
                _two = value;
                RaisePropertyChanged();
            }
        }

        public bool Three
        {
            get => _three;
            set
            {
                _three = value;
                RaisePropertyChanged();
            }
        }
    }
}