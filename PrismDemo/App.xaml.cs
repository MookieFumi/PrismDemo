using Prism;
using Prism.Ioc;
using PrismDemo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PrismDemo
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(Views.MainPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<Views.MainPage>();
            containerRegistry.RegisterForNavigation<AboutPage>();
            containerRegistry.RegisterForNavigation<AuthorPage>();
            containerRegistry.RegisterForNavigation<VersionPage>();
            containerRegistry.RegisterForNavigation<ConfigurationPage>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
