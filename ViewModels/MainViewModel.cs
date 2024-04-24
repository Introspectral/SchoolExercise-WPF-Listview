using Hobby2.Command;
using Hobby2.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Hobby2.ViewModels
{

    public class MainViewModel
    {
        public ObservableCollection<Hobby> Hobbies { get; private set; }

        public ICommand AddHobbyCommand { get; private set; }

        public MainViewModel()
        {
            Hobbies = new ObservableCollection<Hobby>
        {
            new Hobby { Name = "Måleri" },
            new Hobby { Name = "Musik" },
            new Hobby { Name = "Fotografering" }
        };

            AddHobbyCommand = new DelegateCommand(AddHobby);
        }

        private void AddHobby(object parameter)
        {
            if (parameter is string hobbyName && !string.IsNullOrWhiteSpace(hobbyName))
            {
                Hobbies.Add(new Hobby { Name = hobbyName });
            }
        }
    }

}
