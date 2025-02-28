using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.DTOs;
using KhanehNoh.Domain.Core.Entities.Users;
using KhanehNoh.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public UserRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
      
        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _appDbContext.Users            
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

                if (user == null)
                {
                    return false;
                }


                _appDbContext.Users.Remove(user);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                throw new Exception("Logic Errorr");
            }
        }

        public async Task <List<UserSummaryDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            var users = _appDbContext.Users
             .Select(u => new UserSummaryDto
             {
                 Id = u.Id,
                 FirstName = u.FirstName,
                 LastName = u.LastName,
                 UserName = u.UserName,
                 PhoneNumber  = u.PhoneNumber,
                 Email = u.Email,
                 RegisterDate = u.RegisterDate,
                 City = u.City.Title,
                 //Role = (RoleEnum)u.RoleId,
                
             }).ToList();

            return users;
        }

        public UserDto GetById(int id)
        {
            var user = _appDbContext.Users
                .Include(x => x.City)
                .FirstOrDefault(x => x.Id == id);

            if (user is null) throw new Exception("user not found");

            var result = new UserDto();

            result.Id = user.Id;
            result.FirstName = user.FirstName;
            result.LastName = user.LastName;
            result.UserName = user.UserName;
            result.PhoneNumber = user.PhoneNumber;
            result.Email = user.Email;
            result.Address = user.Address;
            result.CityId = user.City.Id;
                    
            return result;
        }
        public async Task<bool> Update(UserDto model, CancellationToken cancellationToken)
        {
            var user = await _appDbContext.Users
                .Include(x => x.City)
                .FirstOrDefaultAsync(x => x.Id == model.Id, cancellationToken);

            if (user is null) return false;

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.UserName = model.UserName;
            user.PhoneNumber = model.PhoneNumber;
            user.Email = model.Email;
            user.CityId = model.CityId;
            user.Address = model.Address;
            

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
