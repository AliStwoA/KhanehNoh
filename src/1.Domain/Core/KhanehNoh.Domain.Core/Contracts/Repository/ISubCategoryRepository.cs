using KhanehNoh.Domain.Core.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Repository
{
    public interface ISubCategoryRepository
    {
        Task<List<SubCategory>> GetAllAsync();

        Task<SubCategory> GetByIdAsync(int id);

        Task AddAsync(SubCategory subCategory);

        Task UpdateAsync(SubCategory subCategory);

        Task DeleteAsync(int id);
    }
}
