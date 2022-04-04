using MvvmHelpers;
using MvvmHelpers.Commands;
using Plaints.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Plaints.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private INavigationService _navigationService;
        public MainViewModel(INavigationService navigationService)
        {
           _navigationService = navigationService;
            NavigateToRecipeListCommand = new Command<string>(OnNavigateToRecipeListCommand);
            _navigationService = navigationService;
            

            //BreakfastClicked = new Command(OnBreakfastClicked);
            //LunchClicked = new Command(OnLunchClicked);
            //DinnerClicked = new Command(OnDinnerClicked);
            //SnacksClicked = new Command(OnSnacksClicked);
        }

        public ICommand BreakfastClicked { get; }
        public ICommand LunchClicked { get; }
        public ICommand DinnerClicked { get; }
        public ICommand SnacksClicked { get; }

        private void OnNavigateToRecipeListCommand(string category)
        {
            _navigationService.NavigateToRecipeList(category);
        }

        public ICommand NavigateToRecipeListCommand
        {
            get;
            set;
        }

        //private void OnBreakfastClicked()
        //{
        //    _navigationService.NavigateToBreakfast();
        //}

        //private void OnLunchClicked()
        //{
        //    _navigationService.NavigateToLunch();
        //}

        //private void OnDinnerClicked()
        //{
        //    _navigationService.NavigateToDinner();
        //}

        //private void OnSnacksClicked()
        //{
        //    _navigationService.NavigateToSnacks();
        //}
    }
}
