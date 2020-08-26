using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChatComponent.ViewModels
{
    public class ChatPageViewModel : BindableBase
    {
        public string Title => "Welcome to Chat Page Prism!";
        private readonly INavigationService _navigationService;

        public ChatPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToWellBeingPageCommand = new Command(NavigateToWellBeingPage);
        }

        public ICommand NavigateToWellBeingPageCommand { get; set; }

        private void NavigateToWellBeingPage()
        {
            _navigationService.NavigateAsync("WellbeingPage");
        }
    }
}
