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
    public class OfferRepository : IOfferRepository
    {
        private readonly ApplicationDbContext _db;
        public OfferRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Offer offer)
        {
            await _db.Offers.AddAsync(offer);

            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var offer = await _db.Offers.FindAsync(id);
            if (offer != null)
            {
                _db.Offers.Remove(offer);
                await _db.SaveChangesAsync();
            }

        }

        public async Task<List<Offer>> GetAllAsync()
        {
            return await _db.Offers.ToListAsync();
        }

        public async Task<Offer> GetByIdAsync(int id)
        {
            return await _db.Offers.FindAsync(id);
        }

        public async Task UpdateAsync(Offer offer)
        {
            _db.Offers.Update(offer);
            await _db.SaveChangesAsync();
        }
    }
}
