using Microsoft.Extensions.DependencyInjection;
using Plaints.DataAccess;
using Plaints.Service;
using Plaints.Services;
using Plaints.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Lora-Regular.ttf", Alias = "LoraRegular")]
[assembly: ExportFont("Lora-Medium.ttf", Alias = "LoraMedium")]

namespace Plaints
{
    public partial class App : Application
    {

        private static ViewModelLocator _viewLocator;
        public App()
        {
            SetupServices();
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage { BindingContext = Locator.MainViewModel});
        }

        internal static ViewModelLocator Locator
        {
            get
            {
                if (_viewLocator is null)
                {
                    _viewLocator = new ViewModelLocator(ServiceProvider);
                }
                return _viewLocator;
            }
        } 

        protected static IServiceProvider ServiceProvider
        {
            get;
            set;
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private void SetupServices() 
        { 
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<MainViewModel>();
            serviceCollection.AddTransient<RecipeDetailsViewModel>();
            serviceCollection.AddTransient<RecipeListViewModel>();
            serviceCollection.AddSingleton<INavigationService, NavigationService>();
            serviceCollection.AddSingleton<IRecipeRepository, RecipeRepository>();
            
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
