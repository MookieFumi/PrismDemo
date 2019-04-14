using Prism.Navigation;
using PrismDemo.ViewModels.Base;
using Prism.Commands;
using PrismDemo.Views;

namespace PrismDemo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main page";

            GotoAboutCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync($"{nameof(AboutPage)}"));
            GotoAboutAbsoluteCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync($"/{nameof(AboutPage)}"));
            GotoConfigurationCommand = new DelegateCommand(async () => await GotoConfiguration());
        }

        private async System.Threading.Tasks.Task<INavigationResult> GotoConfiguration()
        {
            var parameters = new NavigationParameters { { "Name", "Prism Demo project" } };
            return await NavigationService.NavigateAsync($"{nameof(ConfigurationPage)}", parameters, useModalNavigation: true);
        }

        public DelegateCommand GotoAboutCommand { get; private set; }
        public DelegateCommand GotoAboutAbsoluteCommand { get; private set; }
        public DelegateCommand GotoConfigurationCommand { get; private set; }
    }
}
