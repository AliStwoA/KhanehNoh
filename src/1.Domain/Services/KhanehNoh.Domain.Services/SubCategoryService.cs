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
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _subCategoryRepository;

        public SubCategoryService(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        public async Task<List<SubCategory>?> GetSubCategoriesAsync(CancellationToken cancellationToken)
        =>await _subCategoryRepository.GetSubCategoriesAsync(cancellationToken);

        public async Task<bool> CreateAsync(SubCategory subCategory, CancellationToken cancellationToken)
            =>await _subCategoryRepository.CreateAsync(subCategory, cancellationToken);

        public async Task<SubCategory?> GetSubCategoryByIdAsync(int id, CancellationToken cancellationToken)
        => await _subCategoryRepository.GetSubCategoryByIdAsync(id, cancellationToken);

        public async Task<List<SubCategory>?> GetSubCategoriesWithDetailsAsync(CancellationToken cancellationToken)
        => await _subCategoryRepository.GetSubCategoriesWithDetailsAsync(cancellationToken);

        public async Task<SubCategory?> GetCategoryByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
        => await _subCategoryRepository.GetCategoryByIdWithDetailsAsync(id, cancellationToken);

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        => await _subCategoryRepository.DeleteAsync(id, cancellationToken);

        public async Task<bool> UpdateAsync(SubCategory subCategory, CancellationToken cancellationToken)
        => await _subCategoryRepository.UpdateAsync(subCategory, cancellationToken);

        public async Task<bool> IsDelete(int subCategoryId, CancellationToken cancellationToken)
        => await _subCategoryRepository.IsDelete(subCategoryId, cancellationToken); 
    }
}
