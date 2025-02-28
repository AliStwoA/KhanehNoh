using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Contracts.Service;
using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.AppServices
{
    public class RatingAppService : IRatingAppService
    {
        private readonly IRatingService _ratingService;

        public RatingAppService(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        public async Task<bool> CreateAsync(Rating rating, CancellationToken cancellationToken)
        => await _ratingService.CreateAsync(rating, cancellationToken);

        public async Task<bool> DeleteAsync(Rating rating, CancellationToken cancellationToken)
        => await _ratingService.DeleteAsync(rating, cancellationToken);

        public async Task<Rating?> GetRatingByIdAsync(int id, CancellationToken cancellationToken)
        => await _ratingService.GetRatingByIdAsync(id, cancellationToken);

        public async Task<Rating?> GetRatingByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
        => await _ratingService.GetRatingByIdWithDetailsAsync(id, cancellationToken);

        public async Task<List<Rating>?> GetRatingsAsync(CancellationToken cancellationToken)
        => await _ratingService.GetRatingsAsync(cancellationToken);

        public async Task<List<Rating>> GetRatingsWithDetailsAsync(CancellationToken cancellationToken)
        => await _ratingService.GetRatingsWithDetailsAsync(cancellationToken);

        public async Task<bool> IsDelete(int ratingId, CancellationToken cancellationToken)
        => await _ratingService.IsDelete(ratingId, cancellationToken);

        public async Task<bool> UpdateAsync(Rating rating, CancellationToken cancellationToken)
        => await _ratingService.UpdateAsync(rating, cancellationToken);

        public async Task<bool> UpdateStatusAsync(int ratingId, bool newStatus, CancellationToken cancellationToken)
        => await _ratingService.UpdateStatusAsync(ratingId, newStatus, cancellationToken);
    }
}
