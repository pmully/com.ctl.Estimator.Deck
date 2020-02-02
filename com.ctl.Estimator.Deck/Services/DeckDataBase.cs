using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace com.ctl.Estimator.Deck.Services
{
    public class DeckDataBase
    {
        readonly SQLiteAsyncConnection _database;

        public DeckDataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
        }
    }
}
