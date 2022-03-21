using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Prism;

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
    }
}
