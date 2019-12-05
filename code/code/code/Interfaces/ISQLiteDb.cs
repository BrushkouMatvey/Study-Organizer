using SQLite;

namespace code.Interfaces
{
    public interface ISQLiteDb
    {
        SQLiteConnection GetConnection();
    }
}
