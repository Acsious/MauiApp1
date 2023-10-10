using SQLite;

namespace MauiApp1.Data
{
    public class DatabaseContext
    {
        private const string DbName = "MyDatabase.db3";
        private static string DbPath => Path.Combine(FileSystem.AppDataDirectory, DbName);

        private SQLiteAsyncConnection _connection;
        private SQLiteAsyncConnection Database =>
            (_connection ??= new SQLiteAsyncConnection(DbPath,
                SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache));

    }
}
