using Prism.Navigation;
using PrismDemo.ViewModels.Base;
using Prism.Commands;
using PrismDemo.Views;
using System.Threading.Tasks;

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
            GotoVersionCommand = new DelegateCommand(async () => await GotoVersion());
            GotoAuthorCommand = new DelegateCommand(async () => await GotoAuthor());
        }

        public DelegateCommand GotoAboutCommand { get; private set; }
        public DelegateCommand GotoAboutAbsoluteCommand { get; private set; }
        public DelegateCommand GotoConfigurationCommand { get; private set; }
        public DelegateCommand GotoVersionCommand { get; private set; }
        public DelegateCommand GotoAuthorCommand { get; private set; }

        private async Task GotoVersion()
        {
            var path = "AboutPage?selectedTab=VersionPage";
            await NavigationService.NavigateAsync(path);
        }

        private async Task GotoAuthor()
        {
            var path = "AboutPage?selectedTab=AuthorPage";
            await NavigationService.NavigateAsync(path);
        }

        private async Task<INavigationResult> GotoConfiguration()
        {
            var parameters = new NavigationParameters { { "Name", "Prism Demo project" } };
            return await NavigationService.NavigateAsync($"{nameof(ConfigurationPage)}", parameters, useModalNavigation: true);
        }
    }
}
