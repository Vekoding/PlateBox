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
        private int counter = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            var mergetDictionaries =
                Application.Current.Resources.MergedDictionaries;
            mergetDictionaries.Clear();
            
        }
    }
}
