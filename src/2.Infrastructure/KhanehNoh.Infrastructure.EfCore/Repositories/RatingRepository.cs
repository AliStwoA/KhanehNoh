using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.Entities.Orders;
using KhanehNoh.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly ApplicationDbContext _db;
        public RatingRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Rating rating)
        {
            await _db.Ratings.AddAsync(rating);

            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var rating = await _db.Ratings.FindAsync(id);
            if (rating != null)
            {
                _db.Ratings.Remove(rating);
                await _db.SaveChangesAsync();
            }

        }

        public async Task<List<Rating>> GetAllAsync()
        {
            return await _db.Ratings.ToListAsync();
        }

        public async Task<Rating> GetByIdAsync(int id)
        {
            return await _db.Ratings.FindAsync(id);
        }

        public async Task UpdateAsync(Rating rating)
        {
            _db.Ratings.Update(rating);
            await _db.SaveChangesAsync();
        }
    }
}
