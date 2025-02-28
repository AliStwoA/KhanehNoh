using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.Contracts.Service;
using KhanehNoh.Domain.Core.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<Category>> GetCategoriesAsync(CancellationToken cancellationToken)

            => await _categoryRepository.GetCategoriesAsync(cancellationToken);

        public async Task<bool> CreateAsync(Category category, CancellationToken cancellationToken)

              => await _categoryRepository.CreateAsync(category, cancellationToken);

        public async Task<Category?> GetCategoryByIdAsync(int id, CancellationToken cancellationToken)
        => await _categoryRepository.GetCategoryByIdAsync(id, cancellationToken);

        public async Task<List<Category>> GetCategoriesWithDetailsAsync(CancellationToken cancellationToken)
        => await _categoryRepository.GetCategoriesWithDetailsAsync(cancellationToken);

        public async Task<Category?> GetCategoryByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
        => await _categoryRepository.GetCategoryByIdWithDetailsAsync(id, cancellationToken);

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        => await _categoryRepository.DeleteAsync(id, cancellationToken);

        public async Task<bool> UpdateAsync(Category category, CancellationToken cancellationToken)
        => await _categoryRepository.UpdateAsync(category, cancellationToken);

        public async Task<bool> IsDelete(int categoryId, CancellationToken cancellationToken)
        => await _categoryRepository.IsDelete(categoryId, cancellationToken);

    }
}
