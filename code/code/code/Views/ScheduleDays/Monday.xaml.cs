using code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace code.Views.ScheduleDays
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Monday : ContentPage
    {
        public Monday()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = App.ScheduleDb.GetLessons();
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryLesson
            {
                BindingContext = new Lesson()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new EntryLesson
                {
                    BindingContext = e.SelectedItem as Note
                });
            }
        }
    }
}