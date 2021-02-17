using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDemoAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoTestPage : ContentPage
    {
        public DemoTestPage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}