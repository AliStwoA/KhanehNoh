using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages
{
    public class SubCategory_EditModel : PageModel
    {
        private readonly ISubCategoryAppService _subCategoryApp;
        private readonly ICategoryAppService _categoryApp;
        public SubCategory_EditModel(ISubCategoryAppService subCategoryApp, ICategoryAppService categoryApp)
        {
            _subCategoryApp = subCategoryApp;
            _categoryApp = categoryApp;
        }
        [BindProperty]
        public SubCategory SubCategory { get; set; }
        [BindProperty]
        public List<Category> Categories { get; set; }
        public async Task<IActionResult> OnGetAsync(int id, CancellationToken cancellationToken)
        {
            Categories = await _categoryApp.GetCategoriesAsync(cancellationToken);

            SubCategory = await _subCategoryApp.GetSubCategoryByIdAsync(id, cancellationToken);
            if (SubCategory == null)
            {
                return NotFound();
            }


            return Page();

        }
        public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
        {
            await _subCategoryApp.UpdateAsync(SubCategory, cancellationToken);
            return RedirectToPage("SubCategoryList");
        }
    }
}
