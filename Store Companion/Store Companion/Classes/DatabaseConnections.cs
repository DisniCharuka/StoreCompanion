using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.IO;

namespace Store_Companion.Classes
{
    class DatabaseConnections
    {
        string path;
        SQLite.Net.SQLiteConnection conn;

        public DatabaseConnections() {
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,
              "dbo_StoreCompanion.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            //conn.CreateTable<Items>();
            //conn.CreateTable<Item>();
            //conn.CreateTable<ProductType.ItemTypes>();
            //conn.CreateTable<Suppliers>();

        }
    
        
    }
}



/*
List<Tables.SongsTable> Songs = (from p in App.conn.Table<Tables.SongsTable>()
                                                 select p).ToList();
*/