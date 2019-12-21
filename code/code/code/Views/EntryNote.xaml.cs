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
    public partial class EntryNote : ContentPage
    {
        public EntryNote()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            note.Date = DateTime.UtcNow;
            App.NoteDb.SaveNote(note);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            App.NoteDb.DeleteNote(note.ID);
            await Navigation.PopAsync();
        }
    }
}