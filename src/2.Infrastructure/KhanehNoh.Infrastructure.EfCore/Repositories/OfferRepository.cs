using KhanehNoh.Domain.Core;
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
        private readonly ApplicationDbContext _appDbContext;

        public OfferRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Offer>?> GetOfferesAsync(CancellationToken cancellationToken)
        => await _appDbContext.Offers
             .Include(s => s.Request)
        .ToListAsync(cancellationToken);

        public async Task<List<Offer>?> GetUserOffersAsync(int expertId, CancellationToken cancellationToken)
        => await _appDbContext.Offers
            .Where(s => s.ExpertId == expertId)
            .ToListAsync(cancellationToken);


        public async Task<Offer?> GetOfferByIdAsync(int OfferId, CancellationToken cancellationToken)
         => await _appDbContext
         .Offers
         .FirstOrDefaultAsync(s => s.Id == OfferId, cancellationToken);

        public async Task<Offer?> GetUserOfferByIdAsync(int expertId, int OfferId, CancellationToken cancellationToken)
        => await _appDbContext.Offers
            .FirstOrDefaultAsync(s => s.ExpertId == expertId && s.Id == OfferId, cancellationToken);


        public async Task<List<Offer>> GetOffersWithDetailsAsync(CancellationToken cancellationToken)
              => await _appDbContext
               .Offers
               .Include(s => s.Request)
               .ThenInclude(s => s.HomeService)
               .Include(s => s.Expert)
               .ThenInclude(s => s.User)
               .ToListAsync(cancellationToken);

        public async Task<List<Offer>> GetUserOffersWithDetailsAsync(int expertId, CancellationToken cancellationToken)
         => await _appDbContext
             .Offers
             .Where(s => s.ExpertId == expertId)

             .Include(s => s.Request)
             .ThenInclude(s => s.HomeService)
             .Include(s => s.Expert)
             .ThenInclude(s => s.User)
             .ToListAsync(cancellationToken);


        public async Task<Offer?> GeOfferByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
            => await _appDbContext
            .Offers
             .Include(s => s.Request)
             .ThenInclude(s => s.HomeService)
             .Include(s => s.Expert)
             .ThenInclude(s => s.User)
            .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

        public async Task<Offer?> GetUserOfferByIdWithDetailsAsync(int expertId, int OfferId, CancellationToken cancellationToken)
        => await _appDbContext
            .Offers
             .Include(s => s.Request)
             .ThenInclude(s => s.HomeService)
             .Include(s => s.Expert)
             .ThenInclude(s => s.User)
            .FirstOrDefaultAsync(s => s.ExpertId == expertId && s.Id == OfferId, cancellationToken);

        public async Task<bool> ChangeStatus(OrderStatusEnum status, int OfferId, CancellationToken cancellationToken)
        {
            var existOffer = await _appDbContext.Offers.FindAsync(OfferId, cancellationToken);
            if (existOffer == null)
            {
                return false;
            }
                
            existOffer.OfferStatus = status;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> CreateAsync(Offer Offer, CancellationToken cancellationToken)
        {
            try
            {
                await _appDbContext.Offers.AddAsync(Offer, cancellationToken);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> DeleteAsync(Offer Offer, CancellationToken cancellationToken)
        {
            try
            {
                _appDbContext.Offers.Remove(Offer);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> IsDelete(int OfferId, CancellationToken cancellationToken)
        {
            var existOffer = await _appDbContext.Offers.FirstOrDefaultAsync(r => r.Id == OfferId, cancellationToken);
            if (existOffer == null)
                return false;
            existOffer.IsDeleted = true;
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
        public async Task<bool> UpdateAsync(Offer Offer, CancellationToken cancellationToken)
        {
            try
            {

                var existOffer = await _appDbContext.Offers.FirstOrDefaultAsync(x => x.Id == Offer.Id);
                if (existOffer == null)
                    return false;

                existOffer.RegisterDate = Offer.RegisterDate;
                existOffer.Description = Offer.Description;
                existOffer.DeliveryDate = Offer.DeliveryDate;
                existOffer.Price = Offer.Price;
                existOffer.RequestId = Offer.RequestId;

                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;

            }
            catch
            {
                throw new Exception("Logic Error");
            }

        }

    }
}
