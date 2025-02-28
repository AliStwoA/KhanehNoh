using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly ICategoryAppService _categoryApp;

        public EditModel(ICategoryAppService categoryApp)
        {
            _categoryApp = categoryApp;
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int id, CancellationToken cancellationToken)
        {
            Category = await _categoryApp.GetCategoryByIdAsync(id, cancellationToken);
            if(Category == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(CancellationToken cancellationToken)
        {
            await _categoryApp.UpdateAsync(Category, cancellationToken);
            return RedirectToPage("Index");
        }

    }
}
