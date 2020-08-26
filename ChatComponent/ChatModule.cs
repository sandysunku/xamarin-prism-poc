using ChatComponent.ViewModels;
using ChatComponent.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ChatComponent
{
    public class ChatModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ChatPage, ChatPageViewModel>();
        }
    }
}
