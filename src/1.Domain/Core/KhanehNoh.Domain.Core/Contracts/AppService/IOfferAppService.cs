using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.AppService
{
    public interface IOfferAppService
    {
        Task<List<Offer>?> GetOfferesAsync(CancellationToken cancellationToken);
        Task<List<Offer>?> GetUserOffersAsync(int expertId, CancellationToken cancellationToken);
        Task<Offer?> GetOfferByIdAsync(int OfferId, CancellationToken cancellationToken);
        Task<Offer?> GetUserOfferByIdAsync(int expertId, int OfferId, CancellationToken cancellationToken);
        Task<List<Offer>> GetOffersWithDetailsAsync(CancellationToken cancellationToken);
        Task<List<Offer>> GetUserOffersWithDetailsAsync(int expertId, CancellationToken cancellationToken);
        Task<Offer?> GeOfferByIdWithDetailsAsync(int id, CancellationToken cancellationToken);
        Task<Offer?> GetUserOfferByIdWithDetailsAsync(int expertId, int OfferId, CancellationToken cancellationToken);
        Task<bool> CreateAsync(Offer Offer, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(Offer Offer, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(Offer Offer, CancellationToken cancellationToken);
        Task<bool> IsDelete(int OfferId, CancellationToken cancellationToken);
        Task<bool> ChangeStatus(OrderStatusEnum status, int OfferId, CancellationToken cancellationToken);
    }
}
