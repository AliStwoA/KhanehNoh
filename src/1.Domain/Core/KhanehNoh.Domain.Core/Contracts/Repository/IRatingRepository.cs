﻿using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Repository
{
    public interface IRatingRepository
    {
        Task<List<Rating>?> GetRatingsAsync(CancellationToken cancellationToken);
        Task<Rating?> GetRatingByIdAsync(int id, CancellationToken cancellationToken);
        Task<List<Rating>> GetRatingsWithDetailsAsync(CancellationToken cancellationToken);
        Task<Rating?> GetRatingByIdWithDetailsAsync(int id, CancellationToken cancellationToken);
        Task<bool> CreateAsync(Rating rating, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(Rating rating, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(Rating rating, CancellationToken cancellationToken);
        Task<bool> UpdateStatusAsync(int ratingId, bool newStatus, CancellationToken cancellationToken);
        Task<bool> IsDelete(int ratingId, CancellationToken cancellationToken);
    }
}
