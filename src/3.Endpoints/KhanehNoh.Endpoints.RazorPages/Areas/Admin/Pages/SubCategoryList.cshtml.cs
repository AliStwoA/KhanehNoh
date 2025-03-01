using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages
{
    public class SubCategoryListModel : PageModel
    {
        private readonly ISubCategoryAppService _subCategoryApp;

        public SubCategoryListModel(ISubCategoryAppService subCategoryApp)
        {
            _subCategoryApp = subCategoryApp;
        }

        public List<SubCategory> SubCategories { get; set; }
        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            SubCategories = await _subCategoryApp.GetSubCategoriesAsync(cancellationToken);
        }

        public async Task<IActionResult> OnPostDelete(int id, CancellationToken cancellationToken)
        {
            await _subCategoryApp.DeleteAsync(id, cancellationToken);
            return RedirectToPage();
        }
    }
}
