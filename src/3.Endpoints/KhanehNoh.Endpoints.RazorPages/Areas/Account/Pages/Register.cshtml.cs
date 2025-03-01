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
      

        public RegisterModel(IBaseDataAppService baseDataAppService, IUserAppService userAppService)
        {
            _baseDataAppService = baseDataAppService;
            _userAppService = userAppService;
            
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
          await _userAppService.Register(User, cancellationToken);
          
            return RedirectToPage("Index");
        }
    }
}
