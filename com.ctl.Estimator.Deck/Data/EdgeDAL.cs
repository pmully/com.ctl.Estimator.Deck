using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using SQLite;
using com.ctl.Estimator.Deck.Models;
using com.ctl.Estimator.Deck.Services;

namespace com.ctl.Estimator.Deck.Data
{
    class EdgeDAL
    {
        private readonly SQLiteAsyncConnection _database;

        EdgeDAL (SQLiteAsyncConnection database)
        {
            _database = database;
        }

        public Task<List<Edge>> GetEdgeAsync()
        {
            return _database.Table<Edge>().ToListAsync();
        }

  //      public Task<Edge> GetEdgeAsync(String style)
  //      {
  //           return _database.Table<Edge>()
  //                           .Where(i => e.Style == style)
  //                           .FirstOrDefaultAsync();
  //      }

        public Task<int> SaveEdgeAsync(Edge e)
        {
            // In this case of edges, since the PK is the style, there is no update operation, just do insert
            //  if (e.Style != null)
            //{
            //    return _database.UpdateAsync(e);
            //}
            //else
            //
            // 
            //    return _database.InsertAsync(e);
            //}
            return _database.InsertAsync(e);
        }

        public Task<int> DeleteNoteAsync(Edge e)
        {
            return _database.DeleteAsync(e);
        }
    }
}
