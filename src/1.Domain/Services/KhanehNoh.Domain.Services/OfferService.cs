using KhanehNoh.Domain.Core;
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
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;

        public OfferService(IOfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }

        public async Task<bool> ChangeStatus(OrderStatusEnum status, int OfferId, CancellationToken cancellationToken)
        => await _offerRepository.ChangeStatus(status, OfferId,cancellationToken);

        public async Task<bool> CreateAsync(Offer Offer, CancellationToken cancellationToken)
        => await _offerRepository.CreateAsync(Offer, cancellationToken);

        public async Task<bool> DeleteAsync(Offer Offer, CancellationToken cancellationToken)
        => await _offerRepository.DeleteAsync(Offer, cancellationToken);

        public async Task<Offer?> GeOfferByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
        => await _offerRepository.GeOfferByIdWithDetailsAsync(id, cancellationToken);

        public async Task<Offer?> GetOfferByIdAsync(int OfferId, CancellationToken cancellationToken)
        => await _offerRepository.GetOfferByIdAsync(OfferId, cancellationToken);

        public async Task<List<Offer>?> GetOfferesAsync(CancellationToken cancellationToken)
        => await _offerRepository.GetOfferesAsync(cancellationToken);

        public async Task<List<Offer>> GetOffersWithDetailsAsync(CancellationToken cancellationToken)
        => await _offerRepository.GetOffersWithDetailsAsync(cancellationToken);

        public async Task<Offer?> GetUserOfferByIdAsync(int expertId, int OfferId, CancellationToken cancellationToken)
        => await _offerRepository.GetUserOfferByIdAsync(expertId, OfferId, cancellationToken);

        public async Task<Offer?> GetUserOfferByIdWithDetailsAsync(int expertId, int OfferId, CancellationToken cancellationToken)
        => await _offerRepository.GetUserOfferByIdWithDetailsAsync(expertId, OfferId, cancellationToken);

        public async Task<List<Offer>?> GetUserOffersAsync(int expertId, CancellationToken cancellationToken)
        => await _offerRepository.GetUserOffersAsync(expertId, cancellationToken);

        public async Task<List<Offer>> GetUserOffersWithDetailsAsync(int expertId, CancellationToken cancellationToken)
        => await _offerRepository.GetUserOffersWithDetailsAsync(expertId, cancellationToken);

        public async Task<bool> IsDelete(int OfferId, CancellationToken cancellationToken)
        => await _offerRepository.IsDelete(OfferId, cancellationToken);

        public async Task<bool> UpdateAsync(Offer Offer, CancellationToken cancellationToken)
        => await _offerRepository.UpdateAsync(Offer, cancellationToken);
    }
}
