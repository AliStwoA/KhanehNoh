using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.Contracts.Service;
using KhanehNoh.Domain.Core.DTOs;
using KhanehNoh.Domain.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Services
{

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task <List<UserSummaryDto>> GetAllAsync(CancellationToken cancellationToken) =>await _userRepository.GetAllAsync(cancellationToken);
        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken) => await _userRepository.DeleteAsync(id,cancellationToken);

        public UserDto GetById(int id)
        => _userRepository.GetById(id);

        public async Task<bool> Update(UserDto model, CancellationToken cancellationToken)
        => await _userRepository.Update(model, cancellationToken);
    }
}
