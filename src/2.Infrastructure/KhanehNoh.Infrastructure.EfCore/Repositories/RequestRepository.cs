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
    public class RequestRepository : IRequestRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public RequestRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Request>?> GetRequestsAsync(CancellationToken cancellationToken)
           => await _appDbContext.Requests
           .ToListAsync(cancellationToken);

        public async Task<List<Request>?> GetUserRequestsAsync(int customerId, CancellationToken cancellationToken)
           => await _appDbContext.Requests
            .Where(r => r.CustomerId == customerId)
            .ToListAsync(cancellationToken);

        public async Task<Request?> GetRequestByIdAsync(int requestId, CancellationToken cancellationToken)
         => await _appDbContext
         .Requests
         .FirstOrDefaultAsync(s => s.Id == requestId, cancellationToken);

        public async Task<Request?> GetUserRequestByIdAsync(int customerId, int requestId, CancellationToken cancellationToken)
        => await _appDbContext
        .Requests
        .FirstOrDefaultAsync(s => s.CustomerId == customerId && s.Id == requestId, cancellationToken);

        public async Task<List<Request>> GetRequestsWithDetailsAsync(CancellationToken cancellationToken)
              => await _appDbContext
               .Requests
               .Include(r => r.HomeService)
               .Include(r => r.City)              
               .Include(r => r.Offers)
               .ToListAsync(cancellationToken);

        public async Task<List<Request>> GetUserRequestsWithDetailsAsync(int customerId, CancellationToken cancellationToken)
             => await _appDbContext
              .Requests
              .Where(r => r.CustomerId == customerId)
              .Include(r => r.HomeService)
              .Include(r => r.City)
              .Include(r => r.Offers)
              .ToListAsync(cancellationToken);

        public async Task<Request?> GetRequestByIdWithDetailsAsync(int requestId, CancellationToken cancellationToken)
              => await _appDbContext
               .Requests
               .Include(r => r.HomeService)
               .Include(r => r.City)
               .Include(r => r.Offers)
               .FirstOrDefaultAsync(e => e.Id == requestId, cancellationToken);

        public async Task<Request?> GetUserRequestByIdWithDetailsAsync(int customerId, int requestId, CancellationToken cancellationToken)
              => await _appDbContext
               .Requests
               .Include(r => r.HomeService)
               .Include(r => r.City)             
               .Include(r => r.Offers)
               .FirstOrDefaultAsync(r => r.CustomerId == customerId && r.Id == requestId, cancellationToken);



        public async Task<bool> CreateAsync(Request request, CancellationToken cancellationToken)
        {
            try
            {
                await _appDbContext.Requests.AddAsync(request, cancellationToken);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> DeleteAsync(int requestId, CancellationToken cancellationToken)
        {
            try
            {
                var request = await _appDbContext.Requests           
                .Include(x => x.Offers)
                .FirstOrDefaultAsync(x => x.Id == requestId, cancellationToken);

                if (request == null)
                    return false;

                _appDbContext.Requests.Remove(request);
                await _appDbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw new Exception("Logic Errorr");
            }

        }

        public async Task<bool> IsDelete(int requestId, CancellationToken cancellationToken)
        {
            var existRequest = await _appDbContext.Requests.FirstOrDefaultAsync(r => r.Id == requestId, cancellationToken);
            if (existRequest == null)
                return false;
            existRequest.IsDeleted = true;
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> ChangeStatus(OrderStatusEnum status, int requestId, CancellationToken cancellationToken)
        {
            var existRequest = await _appDbContext.Requests.FirstOrDefaultAsync(r => r.Id == requestId);
            if (existRequest == null)
            {
                return false;
            }
                
            existRequest.RequestStatus = status;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> UpdateAsync(Request request, CancellationToken cancellationToken)
        {
            try
            {
                var existRequest = await _appDbContext.Requests.FirstOrDefaultAsync(x => x.Id == request.Id);
                if (existRequest == null)
                    return false;

                existRequest.Title = request.Title;
                existRequest.Description = request.Description;
                existRequest.StartTime = request.StartTime;
                existRequest.EndTime = request.EndTime;
                existRequest.RequestStatus = request.RequestStatus;
                existRequest.CityId = request.CityId;

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
