using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Repository
{
    public interface IOfferRepository
    {
        Task<List<Offer>> GetAllAsync();

        Task<Offer> GetByIdAsync(int id);

        Task AddAsync(Offer offer);

        Task UpdateAsync(Offer offer);

        Task DeleteAsync(int id);
    }
}
