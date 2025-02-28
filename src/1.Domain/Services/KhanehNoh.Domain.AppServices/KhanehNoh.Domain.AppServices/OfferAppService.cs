using KhanehNoh.Domain.Core;
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
    public class OfferAppService : IOfferAppService
    {
        private readonly IOfferService _offerService;

        public OfferAppService(IOfferService offerService)
        {
            _offerService = offerService;
        }

        public async Task<bool> ChangeStatus(OrderStatusEnum status, int OfferId, CancellationToken cancellationToken)
        => await _offerService.ChangeStatus(status, OfferId, cancellationToken);

        public async Task<bool> CreateAsync(Offer Offer, CancellationToken cancellationToken)
        => await _offerService.CreateAsync(Offer, cancellationToken);

        public async Task<bool> DeleteAsync(Offer Offer, CancellationToken cancellationToken)
        => await _offerService.DeleteAsync(Offer, cancellationToken);

        public async Task<Offer?> GeOfferByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
        => await _offerService.GeOfferByIdWithDetailsAsync(id, cancellationToken);

        public async Task<Offer?> GetOfferByIdAsync(int OfferId, CancellationToken cancellationToken)
        => await _offerService.GetOfferByIdAsync(OfferId, cancellationToken);

        public async Task<List<Offer>?> GetOfferesAsync(CancellationToken cancellationToken)
        => await _offerService.GetOfferesAsync(cancellationToken);

        public async Task<List<Offer>> GetOffersWithDetailsAsync(CancellationToken cancellationToken)
        => await _offerService.GetOffersWithDetailsAsync(cancellationToken);

        public async Task<Offer?> GetUserOfferByIdAsync(int expertId, int OfferId, CancellationToken cancellationToken)
        => await _offerService.GetUserOfferByIdAsync(expertId, OfferId, cancellationToken);

        public async Task<Offer?> GetUserOfferByIdWithDetailsAsync(int expertId, int OfferId, CancellationToken cancellationToken)
        => await _offerService.GetUserOfferByIdWithDetailsAsync(expertId, OfferId, cancellationToken);

        public async Task<List<Offer>?> GetUserOffersAsync(int expertId, CancellationToken cancellationToken)
        => await _offerService.GetUserOffersAsync(expertId, cancellationToken);

        public async Task<List<Offer>> GetUserOffersWithDetailsAsync(int expertId, CancellationToken cancellationToken)
        => await _offerService.GetUserOffersWithDetailsAsync(expertId, cancellationToken);

        public async Task<bool> IsDelete(int OfferId, CancellationToken cancellationToken)
        => await _offerService.IsDelete(OfferId, cancellationToken);

        public async Task<bool> UpdateAsync(Offer Offer, CancellationToken cancellationToken)
        => await _offerService.UpdateAsync(Offer, cancellationToken);
    }
}
