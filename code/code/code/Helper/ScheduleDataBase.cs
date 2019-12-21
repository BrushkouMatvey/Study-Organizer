using code.Interfaces;
using code.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace code.Helper
{
    public class ScheduleDataBase
    {
        private SQLiteConnection _SQLiteConnection;

        public ScheduleDataBase(string dataBasePath)
        {
            _SQLiteConnection = DependencyService.Get<ISQLiteDb>().GetConnection();
            _SQLiteConnection.CreateTable<Lesson>();
        }


        public IEnumerable<Lesson> GetLessons()
        {
            return (from u in _SQLiteConnection.Table<Lesson>()
                    select u).ToList();
        }

        public Lesson GetLesson(int id)
        {
            return _SQLiteConnection.Table<Lesson>().FirstOrDefault(t => t.ID == id);

        }

        public void SaveLesson(Lesson lesson)
        {
            var data = _SQLiteConnection.Table<Lesson>();
            _SQLiteConnection.Insert(lesson);
        }

        public void DeleteLesson(int id)
        {
            _SQLiteConnection.Delete<Lesson>(id);
        }
    }
}
