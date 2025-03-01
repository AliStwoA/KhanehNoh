using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages
{
    public class HomeServiceListModel : PageModel
    {
        private readonly IHomeServiceAppService _homeServiceApp;

        public HomeServiceListModel(IHomeServiceAppService homeServiceApp)
        {
            _homeServiceApp = homeServiceApp;
        }

        public List<HomeService> HomeServices { get; set; }
        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            HomeServices = await _homeServiceApp.GetHomeServicesAsync(cancellationToken);
        }

        public async Task<IActionResult> OnPostDelete(int id, CancellationToken cancellationToken)
        {
            await _homeServiceApp.DeleteAsync(id, cancellationToken);
            return RedirectToPage();
        }
    }
}
