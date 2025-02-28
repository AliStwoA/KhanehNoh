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
    public class RequestAppService : IRequestAppService
    {
        private readonly IRequestService _requestService;

        public RequestAppService(IRequestService requestService)
        {
            _requestService = requestService;
        }

        public async Task<bool> ChangeStatus(OrderStatusEnum status, int requestId, CancellationToken cancellationToken)
        => await _requestService.ChangeStatus(status, requestId, cancellationToken);


        public async Task<bool> CreateAsync(Request request, CancellationToken cancellationToken)
        => await _requestService.CreateAsync(request, cancellationToken);

        public async Task<bool> DeleteAsync(int requestId, CancellationToken cancellationToken)
        => await _requestService.DeleteAsync(requestId, cancellationToken);

        public async Task<Request?> GetRequestByIdAsync(int requestId, CancellationToken cancellationToken)

            => await _requestService.GetRequestByIdAsync(requestId, cancellationToken);


        public async Task<Request?> GetRequestByIdWithDetailsAsync(int requestId, CancellationToken cancellationToken)
        => await GetRequestByIdWithDetailsAsync(requestId, cancellationToken);

        public async Task<List<Request>?> GetRequestsAsync(CancellationToken cancellationToken)
        => await _requestService.GetRequestsAsync(cancellationToken);

        public async Task<List<Request>> GetRequestsWithDetailsAsync(CancellationToken cancellationToken)
        => await _requestService.GetRequestsWithDetailsAsync(cancellationToken);


        public async Task<Request?> GetUserRequestByIdAsync(int customerId, int requestId, CancellationToken cancellationToken)
        => await _requestService.GetUserRequestByIdAsync(customerId, requestId, cancellationToken);

        public async Task<Request?> GetUserRequestByIdWithDetailsAsync(int customerId, int requestId, CancellationToken cancellationToken)
        => await _requestService.GetUserRequestByIdAsync(customerId, requestId, cancellationToken);

        public async Task<List<Request>?> GetUserRequestsAsync(int customerId, CancellationToken cancellationToken)
        => await _requestService.GetUserRequestsAsync(customerId, cancellationToken);

        public async Task<List<Request>> GetUserRequestsWithDetailsAsync(int customerId, CancellationToken cancellationToken)
        => await _requestService.GetUserRequestsWithDetailsAsync(customerId, cancellationToken);

        public async Task<bool> IsDelete(int requestId, CancellationToken cancellationToken)
        => await _requestService.IsDelete(requestId, cancellationToken);

        public async Task<bool> UpdateAsync(Request request, CancellationToken cancellationToken)
        => await _requestService.UpdateAsync(request, cancellationToken);
    }
}
