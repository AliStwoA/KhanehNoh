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
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;

        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<bool> ChangeStatus(OrderStatusEnum status, int requestId, CancellationToken cancellationToken)
        =>await _requestRepository.ChangeStatus(status, requestId, cancellationToken);


        public async Task<bool> CreateAsync(Request request, CancellationToken cancellationToken)
        => await _requestRepository.CreateAsync(request, cancellationToken);

        public async Task<bool> DeleteAsync(int requestId, CancellationToken cancellationToken)
        => await _requestRepository.DeleteAsync(requestId, cancellationToken);

        public async Task<Request?> GetRequestByIdAsync(int requestId, CancellationToken cancellationToken)
        
            => await _requestRepository.GetRequestByIdAsync(requestId, cancellationToken);


        public async Task<Request?> GetRequestByIdWithDetailsAsync(int requestId, CancellationToken cancellationToken)
        => await GetRequestByIdWithDetailsAsync(requestId, cancellationToken);

        public async Task<List<Request>?> GetRequestsAsync(CancellationToken cancellationToken)
        => await _requestRepository.GetRequestsAsync(cancellationToken);

        public async Task<List<Request>> GetRequestsWithDetailsAsync(CancellationToken cancellationToken)
        => await _requestRepository.GetRequestsWithDetailsAsync(cancellationToken);


        public async Task<Request?> GetUserRequestByIdAsync(int customerId, int requestId, CancellationToken cancellationToken)
        => await _requestRepository.GetUserRequestByIdAsync(customerId, requestId, cancellationToken);

        public async Task<Request?> GetUserRequestByIdWithDetailsAsync(int customerId, int requestId, CancellationToken cancellationToken)
        => await _requestRepository.GetUserRequestByIdAsync(customerId, requestId, cancellationToken);

        public async Task<List<Request>?> GetUserRequestsAsync(int customerId, CancellationToken cancellationToken)
        => await _requestRepository.GetUserRequestsAsync(customerId, cancellationToken);

        public async Task<List<Request>> GetUserRequestsWithDetailsAsync(int customerId, CancellationToken cancellationToken)
        =>await _requestRepository.GetUserRequestsWithDetailsAsync(customerId,cancellationToken);

        public async Task<bool> IsDelete(int requestId, CancellationToken cancellationToken)
        => await _requestRepository.IsDelete(requestId, cancellationToken);

        public async Task<bool> UpdateAsync(Request request, CancellationToken cancellationToken)
        => await _requestRepository.UpdateAsync(request, cancellationToken);
    }
}
