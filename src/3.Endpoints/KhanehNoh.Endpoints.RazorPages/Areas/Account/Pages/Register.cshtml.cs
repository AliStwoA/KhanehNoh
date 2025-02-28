using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.DTOs;
using KhanehNoh.Domain.Core.Entities.BaseEntities;
using KhanehNoh.Domain.Core.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace KhanehNoh.Endpoints.RazorPages.Areas.Account

{
    [Area("Account")]
    public class RegisterModel : PageModel
    {
        private readonly IBaseDataAppService _baseDataAppService;
        private readonly IUserAppService _userAppService;
        private readonly SignInManager<User> _signInManager;

        public RegisterModel(IBaseDataAppService baseDataAppService, IUserAppService userAppService, SignInManager<User> signInManager)
        {
            _baseDataAppService = baseDataAppService;
            _userAppService = userAppService;
            _signInManager = signInManager;
        }

        [BindProperty]
        public UserDto User { get; set; }

        [BindProperty]
        public List<City> Cities { get; set; }

        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            Cities = await _baseDataAppService.GetCitiesAsync(cancellationToken);
        }


        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
          var result = await _userAppService.Register(User, cancellationToken);
            
            return RedirectToPage("Index");
        }
    }
}
