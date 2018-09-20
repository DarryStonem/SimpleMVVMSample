using System;
using Xamarin.Forms;

namespace DemoApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private string labelTitle;
        public string LabelTitle
        {
            get { return labelTitle; }
            set { SetProperty(ref labelTitle, value); }
        }

        public Command UpdateLabelCommand { get; set; }

        public MainViewModel()
        {
            UpdateLabelCommand = new Command(UpdateLabel);
        }

        private void UpdateLabel(object obj)
        {
            LabelTitle = "Hello world";
            OnPropertyChanged(nameof(LabelTitle));
        }
    }
}