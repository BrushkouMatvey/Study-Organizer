using code.Interfaces;
using code.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace code.Helper
{
    public class NotesDataBase
    {
        private SQLiteConnection _SQLiteConnection;

        public NotesDataBase(string dbPath)
        {
            _SQLiteConnection = DependencyService.Get<ISQLiteDb>().GetConnection();
            _SQLiteConnection.CreateTable<Note>();
        }

        public IEnumerable<Note> GetNotes()
        {
            return (from u in _SQLiteConnection.Table<Note>()
                    select u).ToList();
        }

        public Note GetNote(int id)
        {
            return _SQLiteConnection.Table<Note>().FirstOrDefault(t => t.ID == id);

        }

        public void SaveNote(Note note)
        {
            var data = _SQLiteConnection.Table<Note>();
            _SQLiteConnection.Insert(note);
        }

        public void DeleteNote(int id)
        {
            _SQLiteConnection.Delete<Note>(id);
        }
    }
}
