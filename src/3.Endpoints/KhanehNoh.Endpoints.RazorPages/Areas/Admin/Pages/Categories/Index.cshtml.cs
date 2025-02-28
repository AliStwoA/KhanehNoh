using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryAppService _categoryApp;

        public IndexModel(ICategoryAppService categoryApp)
        {
            _categoryApp = categoryApp;
        }

        public List<Category> Categories { get; set; }
        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            Categories = await _categoryApp.GetCategoriesAsync(cancellationToken);
        }

        public async Task<IActionResult> OnPostDelete(int id, CancellationToken cancellationToken)
        {
            await _categoryApp.DeleteAsync(id, cancellationToken);
            return RedirectToPage();
        }
    }
}
