using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinBreakAwayGreekAdventures.Models;

namespace XamarinBreakAwayGreekAdventures.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string name;
        private string country;
        private string description;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(name)
                && !String.IsNullOrWhiteSpace(description)
                && !String.IsNullOrWhiteSpace(country);
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Country
        {
            get => country;
            set => SetProperty(ref country, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Destination newItem = new Destination()
            {
                Name = Name,
                Country = Country,
                Description = Description
            };

            await DataStore.AddDestinationAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
