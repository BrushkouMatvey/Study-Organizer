using code.Helper;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
   

namespace code
{
    public partial class App : Application
    {
        public static NotesDataBase noteDb;
        public static ScheduleDataBase scheduleDb;


        public static ScheduleDataBase ScheduleDb
        {
            get
            {
                if (scheduleDb == null)
                {
                    scheduleDb = new ScheduleDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ScheduleDb.db3"));
                }
                return scheduleDb;
            }
        }

        public static NotesDataBase NoteDb
        {
            get
            {
                if (noteDb == null)
                {
                    noteDb = new NotesDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return noteDb;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
