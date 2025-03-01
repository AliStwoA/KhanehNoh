using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Account
{
    [Area("Account")]
    public class LoginModel : PageModel
    {
       
        private readonly IUserAppService _userAppService;

        public LoginModel(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [BindProperty]
        public LoginInputModel Input { get; set; }

        public class LoginInputModel
        {
            [Required]
            public string Username { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //returnUrl ??= Url.Content("~/Admin/Index");

            if (!ModelState.IsValid)
                return Page();
            var IsLogin =await _userAppService.Login(Input.Username, Input.Password);
            
            if (IsLogin.Succeeded)
            {
                //return LocalRedirect(returnUrl);
                return RedirectToPage("Index");
            }
            ModelState.AddModelError(string.Empty, "ورود ناموفق");
            return Page();
        }
    }
}

