using KhanehNoh.Domain.Core.DTOs;
using KhanehNoh.Domain.Core.Entities.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.AppService
{
    public interface IUserAppService
    {
       Task <List<UserSummaryDto>> GetAllAsync(CancellationToken cancellationToken);

        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
        Task<IdentityResult> Register(UserDto model, CancellationToken cancellationToken);

        Task<IdentityResult> Login(string username, string password);

        UserDto GetById(int id);
    Task<bool> Update(UserDto model, CancellationToken cancellationToken);
    }
}
