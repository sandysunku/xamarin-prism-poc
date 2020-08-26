using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinPrismDemo.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            ClickCommand = new Command(NavigateToSecondPage);
        }

        public ICommand ClickCommand { get; set; }

        private void NavigateToSecondPage()
        {
            _navigationService.NavigateAsync("SecondPage");
        }


        private string _sample = "Hello Prism";
        private readonly INavigationService _navigationService;

        public string Sample
        {
            get => _sample;
            set => SetProperty(ref _sample, value);
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
