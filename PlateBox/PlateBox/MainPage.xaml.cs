using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Prism;
using PlateBox.View;

namespace PlateBox
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            
            InitializeComponent();
            Task.Run(async () =>
            {
                this.BackgroundColor = Color.Black;

                await Task.Delay(3000);

                this.BackgroundColor = Color.White;

            }).Wait();


        }


        private  void Button_Clicked(object sender, EventArgs e)
        {
            var mergetDictionaries =
                Application.Current.Resources.MergedDictionaries;
            mergetDictionaries.Clear();
            
        }

        private void Breakfast_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Breakfast());

        }
        private void Lunch_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lunch());
        }

        private void Snack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Snack());
        }

        private void Dinner_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dinner());
        }
    }
}
