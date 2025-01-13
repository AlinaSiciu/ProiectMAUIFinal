using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ProiectMAUIFinal.Models;

namespace ProiectMAUIFinal.Data
{
    public class ReviewsDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public ReviewsDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Reviews>().Wait();
            _database.CreateTableAsync<Cal>().Wait();
            _database.CreateTableAsync<Instructor>().Wait();
        }
        public Task<List<Reviews>> GetReviewsAsync()
        {
            return _database.Table<Reviews>().ToListAsync();
        }
        public Task<Reviews> GetReviewsAsync(int id)
        {
            return _database.Table<Reviews>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveReviewAsync(Reviews review)
        {
            if (review.ID != 0)
            {
                return _database.UpdateAsync(review);
            }
            else
            {
                return _database.InsertAsync(review);
            }
        }
        public Task<int> DeleteReviewAsync(Reviews review)
        {
            return _database.DeleteAsync(review);
        }
        public Task<List<Cal>> GetCaiAsync()
        {
            return _database.Table<Cal>().ToListAsync();
        }
        public Task<Cal> GetCaiAsync(int id)
        {
            return _database.Table<Cal>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCalAsync(Cal cal)
        {
            if (cal.ID != 0)
            {
                return _database.UpdateAsync(cal);
            }
            else
            {
                return _database.InsertAsync(cal);
            }
        }
        public Task<int> DeleteCalAsync(Cal cal)
        {
            return _database.DeleteAsync(cal);
        }
        public Task<List<Instructor>> GetInstructorAsync()
        {
            return _database.Table<Instructor>().ToListAsync();
        }
        public Task<Instructor> GetInstructoriAsync(int id)
        {
            return _database.Table<Instructor>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveInstructorAsync(Instructor instr)
        {
            if (instr.ID != 0)
            {
                return _database.UpdateAsync(instr);
            }
            else
            {
                return _database.InsertAsync(instr);
            }
        }
        public Task<int> DeleteInstructorAsync(Instructor instr)
        {
            return _database.DeleteAsync(instr);
        }

    }
}
