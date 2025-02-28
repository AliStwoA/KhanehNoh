using KhanehNoh.Domain.Core.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Service
{
    public interface ISubCategoryService
    {
        Task<List<SubCategory>?> GetSubCategoriesAsync(CancellationToken cancellationToken);
        Task<SubCategory?> GetSubCategoryByIdAsync(int id, CancellationToken cancellationToken);
        Task<List<SubCategory>?> GetSubCategoriesWithDetailsAsync(CancellationToken cancellationToken);
        Task<SubCategory?> GetCategoryByIdWithDetailsAsync(int id, CancellationToken cancellationToken);
        Task<bool> CreateAsync(SubCategory subCategory, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(SubCategory subCategory, CancellationToken cancellationToken);
        Task<bool> IsDelete(int subCategoryId, CancellationToken cancellationToken);
    }
}
