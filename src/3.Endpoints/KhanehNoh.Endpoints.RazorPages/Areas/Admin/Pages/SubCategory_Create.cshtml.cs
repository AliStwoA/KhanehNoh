using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages
{
    public class SubCategory_CreateModel : PageModel
    {
        private readonly ICategoryAppService _categoryApp;
        private readonly ISubCategoryAppService _subCategoryApp;

        public SubCategory_CreateModel(ICategoryAppService categoryApp, ISubCategoryAppService subCategoryApp)
        {
            _categoryApp = categoryApp;
            _subCategoryApp = subCategoryApp;
        }

        [BindProperty]
        public SubCategory subCategory { get; set; }
        [BindProperty]
        public List<Category> Categories { get; set; }
        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            Categories = await _categoryApp.GetCategoriesAsync(cancellationToken);
        }

        public async Task<IActionResult> OnPostAsync(SubCategory subCategory, CancellationToken cancellationToken)
        {
            await _subCategoryApp.CreateAsync(subCategory, cancellationToken);
            return RedirectToPage("SubCategoryList");
        }
    }
}
