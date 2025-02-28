using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages.HomeServices
{
    public class EditModel : PageModel
    {
        private readonly ISubCategoryAppService _subCategoryApp;
        private readonly IHomeServiceAppService _homeServiceApp;
        public EditModel(ISubCategoryAppService subCategoryApp, IHomeServiceAppService homeServiceApp)
        {
            _subCategoryApp = subCategoryApp;
            _homeServiceApp = homeServiceApp;
        }
        [BindProperty]
        public List<SubCategory> SubCategories { get; set; }
        [BindProperty]
        public HomeService HomeService { get; set; }
        public async Task<IActionResult> OnGetAsync(int id, CancellationToken cancellationToken)
        {
            SubCategories = await _subCategoryApp.GetSubCategoriesAsync(cancellationToken);

            HomeService = await _homeServiceApp.GetHomeServiceByIdAsync(id, cancellationToken);
            if (HomeService == null)
            {
                return NotFound();
            }


            return Page();

        }
        public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
        {
            await _homeServiceApp.UpdateAsync(HomeService, cancellationToken);
            return RedirectToPage("Index");
        }
    }
}
