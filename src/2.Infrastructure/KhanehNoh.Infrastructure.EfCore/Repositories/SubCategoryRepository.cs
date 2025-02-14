using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.Entities.Categories;
using KhanehNoh.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Repositories
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public SubCategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(SubCategory subCategory)
        {
            await _db.SubCategories.AddAsync(subCategory);

            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var subCategory = await _db.SubCategories.FindAsync(id);
            if (subCategory != null)
            {
                _db.SubCategories.Remove(subCategory);
                await _db.SaveChangesAsync();
            }

        }

        public async Task<List<SubCategory>> GetAllAsync()
        {
            return await _db.SubCategories.ToListAsync();
        }

        public async Task<SubCategory> GetByIdAsync(int id)
        {
            return await _db.SubCategories.FindAsync(id);
        }

        public async Task UpdateAsync(SubCategory subCategory)
        {
            _db.SubCategories.Update(subCategory);
            await _db.SaveChangesAsync();
        }
    }
}
