using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ICategoryAppService _categoryApp;

        public CreateModel(ICategoryAppService categoryApp)
        {
            _categoryApp = categoryApp;
        }

        [BindProperty]
        public Category category { get; set; }
       

        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
          
        }

        public async Task<IActionResult> OnPostAsync(Category category, CancellationToken cancellationToken)
        {
            await _categoryApp.CreateAsync(category, cancellationToken);
            return RedirectToPage("Index");
        }
    }
}
