using ChatComponent;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using WellBeingComponent;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPrismDemo.ViewModels;
using XamarinPrismDemo.Views;

namespace XamarinPrismDemo
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SecondPage, SecondPageViewModel>();
        }

        protected override void OnInitialized()
        {
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            var chatModuleType = typeof(ChatModule);
            moduleCatalog.AddModule(
                new ModuleInfo()
                {
                    ModuleName = chatModuleType.Name,
                    ModuleType = chatModuleType,
                    InitializationMode = InitializationMode.WhenAvailable
                }
                );

            var wellBeingtModuleType = typeof(WellBeingModule);
            moduleCatalog.AddModule(
                new ModuleInfo()
                {
                    ModuleName = wellBeingtModuleType.Name,
                    ModuleType = wellBeingtModuleType,
                    InitializationMode = InitializationMode.WhenAvailable
                }
                );
        }
    }
}
