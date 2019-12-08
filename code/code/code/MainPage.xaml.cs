using code.Helper;
using code.Views;
using code.Views.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace code
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        UserDb userData;
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this.startPage, false);
            userData = new UserDb();
            NavigationPage.SetHasBackButton(this, false);
            userNameEntry.ReturnCommand = new Command(() => passwordEntry.Focus());
            firstPassword.ReturnCommand = new Command(() => secondPassword.Focus());
            var forgetpassword_tap = new TapGestureRecognizer();
        }
       
        string logesh;
        private async void userIdCheckEvent(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(useridValidationEntry.Text)) || (string.IsNullOrWhiteSpace(useridValidationEntry.Text)))
            {
                await DisplayAlert("Alert", "Enter Mail Id", "OK");
            }
            else
            {
                logesh = useridValidationEntry.Text;
                var textresult = userData.updateUserValidation(useridValidationEntry.Text);
                if (textresult)
                {
                    popupLoadingView.IsVisible = false;
                    passwordView.IsVisible = true;
                }
                else
                {
                    await DisplayAlert("User Mail Id Not Exist", "Enter Correct User Name", "OK");
                }
            }
        }
        private async void Password_ClickedEvent(object sender, EventArgs e)
        {
            if (!string.Equals(firstPassword.Text, secondPassword.Text))
            {
                warningLabel.Text = "Enter Same Password";
                warningLabel.TextColor = Color.IndianRed;
                warningLabel.IsVisible = true;
            }
            else if ((string.IsNullOrWhiteSpace(firstPassword.Text)) || (string.IsNullOrWhiteSpace(secondPassword.Text)))
            {
                await DisplayAlert("Alert", " Enter Password", "OK");
            }
            else
            {
                try
                {
                    var return1 = userData.updateUser(logesh, firstPassword.Text);
                    passwordView.IsVisible = false;
                    if (return1)
                    {
                        await DisplayAlert("Password Updated", "User Data updated", "OK");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private async void LoginValidation_ButtonClicked(object sender, EventArgs e)
        {
            if (userNameEntry.Text != null && passwordEntry.Text != null)
            {
                var validData = userData.LoginValidate(userNameEntry.Text, passwordEntry.Text);
                if (validData)
                {
                    popupLoadingView.IsVisible = false;
                    App.Current.MainPage = new MasterPage();
                }
                else
                {
                    popupLoadingView.IsVisible = false;
                    await DisplayAlert("Login Failed", "Username or Password Incorrect", "OK");
                }
            }
            else
            {
                popupLoadingView.IsVisible = false;
                await DisplayAlert("He He", "Enter User Name and Password Please", "OK");
            }
        }
        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}
