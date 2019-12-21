using code.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace code.Views.ScheduleDays
{
    class ListViewPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private IList<Lesson> birdsList;
        bool isRefreshing;
        private bool isEmpty;

        public bool IsEmpty
        {
            get { return isEmpty; }
            set { isEmpty = value; OnPropertyChanged(); }
        }
        public IList<Lesson> BirdsList
        {
            get { return birdsList; }
            set { birdsList = value; OnPropertyChanged(); }
        }


        public bool IsRefreshing
        {
            get
            {
                return isRefreshing;
            }

            set
            {
                isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public Command RefreshCommand { get; set; }
        public ListViewPageViewModel()
        {
            BirdsList = new ObservableCollection<Lesson>();
            RefreshCommand = new Command(() => GetData());
            GetData();
        }

        void GetData()
        {
            IsRefreshing = true;
            birdsList.Clear();
            Random random = new Random();
            int number = random.Next(0, 4);
            for (int i = 0; i < number; i++)
            {
                BirdsList.Add(new Lesson
                {
                    Class = 4,
                    TeacherName = "David"                  
                });
            }
            IsEmpty = BirdsList.Count == 0;
            IsRefreshing = false;
        }
    }
}
