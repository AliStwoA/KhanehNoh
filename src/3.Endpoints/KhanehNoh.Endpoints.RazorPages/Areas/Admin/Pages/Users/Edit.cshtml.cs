using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.DTOs;
using KhanehNoh.Domain.Core.Entities.BaseEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages.Users
{
    public class EditModel : PageModel
    {
        private readonly IBaseDataAppService _baseDataAppService;
        private readonly IUserAppService _userAppService;
        

        public EditModel(IBaseDataAppService baseDataAppService, IUserAppService userAppService)
        {
            _baseDataAppService = baseDataAppService;
            _userAppService = userAppService;
        }

        [BindProperty]
        public UserDto User { get; set; }
        [BindProperty]
        public List<City> Cities { get; set; }

        public async Task OnGetAsync(int id, CancellationToken cancellationToken)
        {
            User = _userAppService.GetById(id);
            Cities =await _baseDataAppService.GetCitiesAsync(cancellationToken);
        }

        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
            await _userAppService.Update(User, cancellationToken);
            return RedirectToPage("Index");
        }
    }
}
