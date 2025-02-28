using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.DTOs;
using KhanehNoh.Domain.Core.Entities.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages
{
    public class UserListModel : PageModel
    {
        private readonly IUserAppService _userAppService;

        public UserListModel(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [BindProperty]
        public List<UserSummaryDto> users { get; set; }

        public async Task OnGetAsync(CancellationToken cancellationToken)

        {
            
            users = await _userAppService.GetAllAsync(cancellationToken);
        }

        public async Task<IActionResult> OnPostDelete(int id, CancellationToken cancellationToken)
        {
            await _userAppService.DeleteAsync(id, cancellationToken);
            return RedirectToPage();
        }
    }
}
