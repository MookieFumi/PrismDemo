using Prism.Navigation;

namespace PrismDemo.ViewModels.Base
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main page";
        }
    }
}
