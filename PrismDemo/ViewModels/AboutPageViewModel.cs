using Prism.Navigation;
using PrismDemo.ViewModels.Base;

namespace PrismDemo.ViewModels
{
    public class AboutPageViewModel : ViewModelBase
    {
        public AboutPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "About page";
        }
    }
}
