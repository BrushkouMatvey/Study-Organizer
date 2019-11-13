using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Code
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent(); 
        }
        private async void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("", "Привет Хабр!", "OK");
        }

    }
}
