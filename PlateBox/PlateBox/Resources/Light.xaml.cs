using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlateBox.Resources
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Light 
    {
        public Light()
        {
            //Da li moze da ima samo jedna inicijalna komponenta
            InitializeComponent();
        }

      
    }
}