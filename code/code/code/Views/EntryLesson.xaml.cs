using code.Models;
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
    public partial class EntryLesson : ContentPage
    {
        public EntryLesson()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var lesson = (Lesson)BindingContext;
            App.ScheduleDb.SaveLesson(lesson);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var lesson = (Lesson)BindingContext;
            App.ScheduleDb.DeleteLesson(lesson.ID);
            await Navigation.PopAsync();
        }
    }
}