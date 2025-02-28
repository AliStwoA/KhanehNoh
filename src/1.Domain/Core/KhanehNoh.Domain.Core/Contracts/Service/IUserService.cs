using KhanehNoh.Domain.Core.DTOs;
using KhanehNoh.Domain.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Service
{
    public interface IUserService
    {
        Task<List<UserSummaryDto>> GetAllAsync(CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);

        UserDto GetById(int id);
        Task<bool> Update(UserDto model, CancellationToken cancellationToken);
    }
}
