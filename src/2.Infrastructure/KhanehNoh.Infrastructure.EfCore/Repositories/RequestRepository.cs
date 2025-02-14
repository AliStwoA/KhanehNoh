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
        private readonly ApplicationDbContext _db;
        public RequestRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Request request)
        {
            await _db.Requests.AddAsync(request);

            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var request = await _db.Requests.FindAsync(id);
            if (request != null)
            {
                _db.Requests.Remove(request);
                await _db.SaveChangesAsync();
            }

        }

        public async Task<List<Request>> GetAllAsync()
        {
            return await _db.Requests.ToListAsync();
        }

        public async Task<Request> GetByIdAsync(int id)
        {
            return await _db.Requests.FindAsync(id);
        }

        public async Task UpdateAsync(Request request)
        {
            _db.Requests.Update(request);
            await _db.SaveChangesAsync();
        }
    }
}
