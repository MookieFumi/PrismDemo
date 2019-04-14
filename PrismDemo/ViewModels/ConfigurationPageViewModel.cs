using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using PrismDemo.ViewModels.Base;

namespace PrismDemo.ViewModels
{
    public class ConfigurationPageViewModel : ViewModelBase
    {
        public ConfigurationPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Configuration page";
            SaveCommand = new DelegateCommand(async () => await Save(), SaveCanExecute).ObservesProperty(() => Name);
        }

        private bool SaveCanExecute()
        {
            return !string.IsNullOrEmpty(Name);
        }

        private async Task<INavigationResult> Save()
        {
            return await NavigationService.GoBackAsync();
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public DelegateCommand SaveCommand { get; private set; }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            Name = parameters.GetValue<string>(nameof(Name));
        }
    }
}
