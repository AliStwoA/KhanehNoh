using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.DTOs;
using KhanehNoh.Domain.Core.Entities.BaseEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages
{
    public class User_CreateModel : PageModel
    {
        private readonly IBaseDataAppService _baseDataAppService;
        private readonly IUserAppService _userAppService;

        public User_CreateModel(IBaseDataAppService baseDataAppService, IUserAppService userAppService)
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


        public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
        {
            await _userAppService.Register(User, cancellationToken);
            return RedirectToPage("UserList");
        }
    }
}
