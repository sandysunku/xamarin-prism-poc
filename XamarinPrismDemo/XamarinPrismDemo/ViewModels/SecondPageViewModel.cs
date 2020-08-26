using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinPrismDemo.ViewModels
{
    public class SecondPageViewModel : BindableBase
    {

        public string Title => "Welcome to Second Page";

        private readonly INavigationService _navigationService;

        public SecondPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateChatPageCommand = new Command(NavigateToChatPage);
        }

        public ICommand NavigateChatPageCommand { get; set; }

        private void NavigateToChatPage()
        {
            _navigationService.NavigateAsync("ChatPage");
        }
    }
}
