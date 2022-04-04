using Plaints.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Plaints.Services
{
    internal class NavigationService : INavigationService
    {
        public void NavigateBack()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }

        public void NavigateToRecipeDetails()
        {
            
        }

        public void NavigateToRecipeList(string category)
        {
            var vm = App.Locator.RecipeListViewModel;
            vm.LoadRecipes(category);
            Application.Current
                  .MainPage
                  .Navigation
                  .PushAsync(new RecipeListView { BindingContext = vm });
        }

        //public void NavigateToBreakfast()
        //{
        //    var vm = App.Locator.ListBreakfast;
        //    Application.Current.MainPage.Navigation.PushModalAsync(new ListBreakfast { BindingContext = vm });
        //}

        //public void NavigateToLunch()
        //{
        //    var tl = App.Locator.ListLunch;
        //    Application.Current.MainPage.Navigation.PushModalAsync(new ListLunch { BindingContext = tl });
        //}

        //public void NavigateToDinner()
        //{
        //    var td = App.Locator.ListDinner;
        //    Application.Current.MainPage.Navigation.PushModalAsync(new ListDinner { BindingContext = td });
        //}

        //public void NavigateToSnacks()
        //{
        //    var ts = App.Locator.ListSnacks;
        //    Application.Current.MainPage.Navigation.PushModalAsync(new ListSnacks { BindingContext = ts });
        //}
    }
}
