using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.Contracts.Service;
using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Services
{
    public class RatingSevice : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingSevice(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public async Task<bool> CreateAsync(Rating rating, CancellationToken cancellationToken)
        => await _ratingRepository.CreateAsync(rating, cancellationToken);

        public async Task<bool> DeleteAsync(Rating rating, CancellationToken cancellationToken)
        => await _ratingRepository.DeleteAsync(rating, cancellationToken);

        public async Task<Rating?> GetRatingByIdAsync(int id, CancellationToken cancellationToken)
        => await _ratingRepository.GetRatingByIdAsync(id, cancellationToken);

        public async Task<Rating?> GetRatingByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
        => await _ratingRepository.GetRatingByIdWithDetailsAsync(id, cancellationToken);

        public async Task<List<Rating>?> GetRatingsAsync(CancellationToken cancellationToken)
        => await _ratingRepository.GetRatingsAsync(cancellationToken);

        public async Task<List<Rating>> GetRatingsWithDetailsAsync(CancellationToken cancellationToken)
        => await _ratingRepository.GetRatingsWithDetailsAsync(cancellationToken);

        public async Task<bool> IsDelete(int ratingId, CancellationToken cancellationToken)
        => await _ratingRepository.IsDelete(ratingId, cancellationToken);

        public async Task<bool> UpdateAsync(Rating rating, CancellationToken cancellationToken)
        => await _ratingRepository.UpdateAsync(rating, cancellationToken);

        public async Task<bool> UpdateStatusAsync(int ratingId, bool newStatus, CancellationToken cancellationToken)
        => await _ratingRepository.UpdateStatusAsync(ratingId, newStatus, cancellationToken);
    }
}
