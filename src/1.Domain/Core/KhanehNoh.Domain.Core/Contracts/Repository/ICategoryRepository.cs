﻿using KhanehNoh.Domain.Core.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Repository
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategoriesAsync(CancellationToken cancellationToken);
        Task<Category?> GetCategoryByIdAsync(int id, CancellationToken cancellationToken);
        Task<List<Category>> GetCategoriesWithDetailsAsync(CancellationToken cancellationToken);
        Task<Category?> GetCategoryByIdWithDetailsAsync(int id, CancellationToken cancellationToken);
        Task<bool> CreateAsync(Category category, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(Category category, CancellationToken cancellationToken);
        Task<bool> IsDelete(int categoryId, CancellationToken cancellationToken);
    }
}
