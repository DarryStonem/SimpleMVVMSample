using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DemoApp.Model;
using Xamarin.Forms;

namespace DemoApp.ViewModel
{
    public class ItemsFileViewModel : BaseViewModel
    {
        private ObservableCollection<Person> _personItems;
        public ObservableCollection<Person> PersonItems
        {
            get { return _personItems; }
            set { SetProperty(ref _personItems, value); }
        }

        private Person _personSelectedItem;
        public Person PersonSelectedItem
        {
            get { return _personSelectedItem; }
            set
            {
                SetProperty(ref _personSelectedItem, value);
                if (value != null)
                    OnPersonItemSelected(value);
            }
        }

        public Command AddItemsCommand { get; set; }

        public ItemsFileViewModel()
        {
            AddItemsCommand = new Command(AddItems);
        }

        private async void OnPersonItemSelected(Person obj)
        {
            await Application.Current.MainPage.DisplayAlert("Hello!", obj.Name, "Ok");
            PersonSelectedItem = null;
        }

        private void AddItems(object obj)
        {
            FillPersonItems();
        }

        private async void FillPersonItems()
        {
            if (PersonItems == null)
                PersonItems = new ObservableCollection<Person>();
            else
                PersonItems.Clear();

            PersonItems.Add(new Person(){ Name = "Cristian", IsMarried = false });
            await Task.Delay(1000);
            PersonItems.Add(new Person() { Name = "Alberto", IsMarried = true });
            await Task.Delay(1000);
            PersonItems.Add(new Person() { Name = "Ernesto", IsMarried = false });
        }
    }
}