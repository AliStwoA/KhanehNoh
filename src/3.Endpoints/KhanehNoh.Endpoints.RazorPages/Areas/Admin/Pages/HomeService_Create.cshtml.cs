using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages
{
    public class HomeService_CreateModel : PageModel
    {
        private readonly IHomeServiceAppService _homeServiceApp;
        private readonly ISubCategoryAppService _subCategoryApp;

        public HomeService_CreateModel(IHomeServiceAppService homeServiceApp, ISubCategoryAppService subCategoryApp)
        {
            _homeServiceApp = homeServiceApp;
            _subCategoryApp = subCategoryApp;
        }

        [BindProperty]
        public HomeService HomeService { get; set; }
        [BindProperty]
        public List<SubCategory> SubCategories { get; set; }
        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            SubCategories = await _subCategoryApp.GetSubCategoriesAsync(cancellationToken);
        }

        public async Task<IActionResult> OnPostAsync(HomeService homeService, CancellationToken cancellationToken)
        {
            await _homeServiceApp.CreateAsync(homeService, cancellationToken);
            return RedirectToPage("HomeServiceList");
        }
    }
}
