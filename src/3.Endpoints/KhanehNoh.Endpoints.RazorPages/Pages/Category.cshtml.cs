using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly ICategoryAppService _categoryApp;
        private readonly ISubCategoryAppService _subCategoryApp;

        public CategoryModel(ICategoryAppService categoryApp, ISubCategoryAppService subCategoryApp)
        {
            _categoryApp = categoryApp;
            _subCategoryApp = subCategoryApp;
        }

        [BindProperty]
        public List<Category> Categories { get; set; }
        [BindProperty]
        public List<SubCategory> SubCategories { get; set; }


        public async Task OnGetAsync(int categoryId, CancellationToken cancellationToken)
        {
            Categories = await _categoryApp.GetCategoriesAsync(cancellationToken);

            //if(id > 0)
            //{
            //    SubCategories =await _subCategoryApp.GetSubCategoryByIdAsync(id, cancellationToken);    
            //}


        }


    }
}