using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Contracts.Service;
using KhanehNoh.Domain.Core.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.AppServices
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryService _categoryService;

        public CategoryAppService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<List<Category>> GetCategoriesAsync(CancellationToken cancellationToken)

            => await _categoryService.GetCategoriesAsync(cancellationToken);

        public async Task<bool> CreateAsync(Category category, CancellationToken cancellationToken)

              => await _categoryService.CreateAsync(category, cancellationToken);

        public async Task<Category?> GetCategoryByIdAsync(int id, CancellationToken cancellationToken)
        => await _categoryService.GetCategoryByIdAsync(id, cancellationToken);

        public async Task<List<Category>> GetCategoriesWithDetailsAsync(CancellationToken cancellationToken)
        => await _categoryService.GetCategoriesWithDetailsAsync(cancellationToken);

        public async Task<Category?> GetCategoryByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
        => await _categoryService.GetCategoryByIdWithDetailsAsync(id, cancellationToken);

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        => await _categoryService.DeleteAsync(id, cancellationToken);

        public async Task<bool> UpdateAsync(Category category, CancellationToken cancellationToken)
        => await _categoryService.UpdateAsync(category, cancellationToken);

        public async Task<bool> IsDelete(int categoryId, CancellationToken cancellationToken)
        => await _categoryService.IsDelete(categoryId, cancellationToken);
    }
}
