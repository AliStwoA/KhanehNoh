﻿using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Service
{
    public interface IRequestService
    {
        Task<List<Request>?> GetRequestsAsync(CancellationToken cancellationToken);
        Task<List<Request>?> GetUserRequestsAsync(int customerId, CancellationToken cancellationToken);
        Task<Request?> GetRequestByIdAsync(int requestId, CancellationToken cancellationToken);
        Task<Request?> GetUserRequestByIdAsync(int customerId, int requestId, CancellationToken cancellationToken);
        Task<List<Request>> GetRequestsWithDetailsAsync(CancellationToken cancellationToken);
        Task<List<Request>> GetUserRequestsWithDetailsAsync(int customerId, CancellationToken cancellationToken);
        Task<Request?> GetRequestByIdWithDetailsAsync(int requestId, CancellationToken cancellationToken);
        Task<Request?> GetUserRequestByIdWithDetailsAsync(int customerId, int requestId, CancellationToken cancellationToken);
        Task<bool> CreateAsync(Request request, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int requestId, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(Request request, CancellationToken cancellationToken);
        Task<bool> IsDelete(int requestId, CancellationToken cancellationToken);
        Task<bool> ChangeStatus(OrderStatusEnum status, int requestId, CancellationToken cancellationToken);
    }
}
