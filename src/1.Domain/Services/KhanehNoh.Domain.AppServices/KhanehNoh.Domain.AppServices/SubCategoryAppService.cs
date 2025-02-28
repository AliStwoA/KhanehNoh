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
    public class SubCategoryAppService : ISubCategoryAppService
    {
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoryAppService(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        public async Task<List<SubCategory>?> GetSubCategoriesAsync(CancellationToken cancellationToken)
        =>await _subCategoryService.GetSubCategoriesAsync(cancellationToken);

        public async Task<bool> CreateAsync(SubCategory subCategory, CancellationToken cancellationToken)
            =>await _subCategoryService.CreateAsync(subCategory, cancellationToken);

        public async Task<SubCategory?> GetSubCategoryByIdAsync(int id, CancellationToken cancellationToken)
        => await _subCategoryService.GetSubCategoryByIdAsync(id, cancellationToken);

        public async Task<List<SubCategory>?> GetSubCategoriesWithDetailsAsync(CancellationToken cancellationToken)
        => await _subCategoryService.GetSubCategoriesWithDetailsAsync(cancellationToken);

        public async Task<SubCategory?> GetCategoryByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
        => await _subCategoryService.GetCategoryByIdWithDetailsAsync(id, cancellationToken);

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        => await _subCategoryService.DeleteAsync(id, cancellationToken);

        public async Task<bool> UpdateAsync(SubCategory subCategory, CancellationToken cancellationToken)
        => await _subCategoryService.UpdateAsync(subCategory, cancellationToken);

        public async Task<bool> IsDelete(int subCategoryId, CancellationToken cancellationToken)
        => await _subCategoryService.IsDelete(subCategoryId, cancellationToken);
    }
}
