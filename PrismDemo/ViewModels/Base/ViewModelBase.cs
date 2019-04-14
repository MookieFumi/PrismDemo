using Prism.Mvvm;
using Prism.Navigation;

namespace PrismDemo.ViewModels.Base
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible, IConfirmNavigation
    {
        protected readonly INavigationService NavigationService;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public void Destroy()
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public virtual bool CanNavigate(INavigationParameters parameters)
        {
            return true;
        }
    }
}
