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
        private readonly ApplicationDbContext _appDbContext;

        public RatingRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Rating>?> GetRatingsAsync(CancellationToken cancellationToken)
         => await _appDbContext.Ratings
         .ToListAsync(cancellationToken);

        public async Task<Rating?> GetRatingByIdAsync(int id, CancellationToken cancellationToken)
         => await _appDbContext
         .Ratings
         .FirstOrDefaultAsync(s => s.Id == id, cancellationToken);

        public async Task<List<Rating>> GetRatingsWithDetailsAsync(CancellationToken cancellationToken)
              => await _appDbContext
               .Ratings
               .Include(r => r.Expert)
               .Include(r => r.Customer)
               .ToListAsync(cancellationToken);

        public async Task<Rating?> GetRatingByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
              => await _appDbContext
               .Ratings
               .Include(r => r.Expert)
               .Include(r => r.Customer)
               .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);


        public async Task<bool> UpdateStatusAsync(int ratingId, bool newStatus, CancellationToken cancellationToken)
        {
            var rating = await _appDbContext.Ratings.FirstOrDefaultAsync(r => r.Id == ratingId, cancellationToken);

            if (rating == null)
            {
                return false;
            }
                

            rating.Status = newStatus;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> CreateAsync(Rating rating, CancellationToken cancellationToken)
        {
            try
            {
                await _appDbContext.Ratings.AddAsync(rating, cancellationToken);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Rating rating, CancellationToken cancellationToken)
        {
            try
            {
                _appDbContext.Ratings.Remove(rating);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> IsDelete(int ratingId, CancellationToken cancellationToken)
        {
            var existRating = await _appDbContext.Ratings.FirstOrDefaultAsync(r => r.Id == ratingId, cancellationToken);
            if (existRating == null)
                return false;
            existRating.IsDeleted = true;
            _appDbContext.Ratings.Remove(existRating);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> UpdateAsync(Rating rating, CancellationToken cancellationToken)
        {
            try
            {
                var existRating = await _appDbContext.Ratings.FirstOrDefaultAsync(x => x.Id == rating.Id);
                if (existRating == null)
                    return false;

                existRating.Rate = rating.Rate;
                existRating.Comment = rating.Comment;
                existRating.Status = rating.Status;

                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}