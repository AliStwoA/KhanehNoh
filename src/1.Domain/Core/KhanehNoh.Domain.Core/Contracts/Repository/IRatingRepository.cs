using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Repository
{
    public interface IRatingRepository
    {
        Task<List<Rating>> GetAllAsync();

        Task<Rating> GetByIdAsync(int id);

        Task AddAsync(Rating rating);

        Task UpdateAsync(Rating rating);

        Task DeleteAsync(int id);
    }
}
