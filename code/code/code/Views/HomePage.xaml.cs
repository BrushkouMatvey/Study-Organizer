using code.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace code.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        UserDb userData = new UserDb();
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            var sourceData = userData.GetUsers();
            listUser.ItemsSource = sourceData;
        }
        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Quit", "You want Quit", "OK");
            Application.Current.Quit();
        }
    }
}