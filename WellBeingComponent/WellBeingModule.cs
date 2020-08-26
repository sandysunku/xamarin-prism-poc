using Prism.Ioc;
using Prism.Modularity;
using WellBeingComponent.ViewModels;
using WellBeingComponent.Views;

namespace WellBeingComponent
{
    public class WellBeingModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<WellbeingPage, WellbeingPageViewModel>();
        }
    }
}
