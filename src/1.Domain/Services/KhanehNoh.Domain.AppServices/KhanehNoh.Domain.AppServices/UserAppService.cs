using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Contracts.Service;
using KhanehNoh.Domain.Core.DTOs;
using KhanehNoh.Domain.Core.Entities.Users;
using KhanehNoh.Domain.Core.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.AppServices
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserAppService(IUserService userService, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userService = userService;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<List<UserSummaryDto>> GetAllAsync(CancellationToken cancellationToken) => await _userService.GetAllAsync(cancellationToken);
        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken) => await _userService.DeleteAsync(id, cancellationToken);
        public async Task<IdentityResult> Register(UserDto model, CancellationToken cancellationToken)
        {
            var role = string.Empty;
            var user = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                CityId = model.CityId,
                FirstName = model.FirstName,
                LastName = model.LastName,

            };
            if (model.Role == RoleEnum.Admin)
            {
                user.Admin = new Admin();
                role = "Admin";

            }
            if (model.Role == RoleEnum.Expert)
            {
                user.Expert = new Expert();
                role = "Expert";

            }
            if (model.Role == RoleEnum.Customer)
            {
                user.Customer = new Customer();
                role = "Customer";
            }


            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {

                await _userManager.AddToRoleAsync(user, role);


                if (model.Role == RoleEnum.Expert)
                {
                    var userExpertId = user.Expert!.Id;
                    await _userManager.AddClaimAsync(user, new Claim("userExpertId", userExpertId.ToString()));
                }

                if (model.Role == RoleEnum.Customer)
                {
                    var userCustomerId = user.Customer!.Id;
                    await _userManager.AddClaimAsync(user, new Claim("userCustomerId", userCustomerId.ToString()));
                }

                await _signInManager.PasswordSignInAsync(user.UserName, model.Password, true, false);

            }
            return result;


        }
        public async Task<IdentityResult> Login(string username, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(username, password, true, false);
            return result.Succeeded ? IdentityResult.Success : IdentityResult.Failed();
        }

        public UserDto GetById(int id)
        => _userService.GetById(id);

        public async Task<bool> Update(UserDto model, CancellationToken cancellationToken)
        => await _userService.Update(model, cancellationToken);


    }
    
}
