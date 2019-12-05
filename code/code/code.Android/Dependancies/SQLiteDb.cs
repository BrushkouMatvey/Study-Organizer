using System.IO;
using code.Interfaces;
using code.Droid.Dependancies;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteDb))]
namespace code.Droid.Dependancies
{
    class SQLiteDb : ISQLiteDb
    {
        public SQLiteConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");
            return new SQLiteConnection(path);
        }
    }
}