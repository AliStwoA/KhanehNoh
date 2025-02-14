using KhanehNoh.Domain.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Repository
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetAllAsync();

        Task<Role> GetByIdAsync(int id);

        Task AddAsync(Role role);

        Task UpdateAsync(Role role);

        Task DeleteAsync(int id);
    }
}
