using KhanehNoh.Domain.Core.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Repository
{
    public interface IRequestRepository
    {
        Task<List<Request>> GetAllAsync();

        Task<Request> GetByIdAsync(int id);

        Task AddAsync(Request request);

        Task UpdateAsync(Request request);

        Task DeleteAsync(int id);
    }
}
