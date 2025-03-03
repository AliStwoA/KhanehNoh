﻿using KhanehNoh.Domain.Core.Contracts.Repository;
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
        private readonly ApplicationDbContext _appDbContext;

        public SubCategoryRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<SubCategory>?> GetSubCategoriesAsync(CancellationToken cancellationToken)
         => await _appDbContext.SubCategories
            .Include(s => s.Category)
            .Include(s => s.HomeServices)
         .ToListAsync(cancellationToken);

        public async Task<SubCategory?> GetSubCategoryByIdAsync(int id, CancellationToken cancellationToken)
         => await _appDbContext
         .SubCategories
         .FirstOrDefaultAsync(s => s.Id == id, cancellationToken);

        public async Task<List<SubCategory>?> GetSubCategoriesWithDetailsAsync(CancellationToken cancellationToken)
           => await _appDbContext
            .SubCategories
            .Include(s => s.HomeServices)
            .ToListAsync(cancellationToken);

        public async Task<SubCategory?> GetCategoryByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
            => await _appDbContext
             .SubCategories
             .Include(s => s.HomeServices)
             .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);



        public async Task<bool> CreateAsync(SubCategory subCategory, CancellationToken cancellationToken)
        {
            try
            {
                await _appDbContext.SubCategories.AddAsync(subCategory, cancellationToken);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            try
            {
                var subCategory = await _appDbContext.SubCategories
                .Include(x => x.HomeServices)
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

                if (subCategory == null)
                {
                    return false;
                }
                    

                _appDbContext.SubCategories.Remove(subCategory);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                throw new Exception("Logic Errorr");
            }
        }

        public async Task<bool> IsDelete(int subCategoryId, CancellationToken cancellationToken)
        {
            var existSubCategory = await _appDbContext.SubCategories.FirstOrDefaultAsync(r => r.Id == subCategoryId, cancellationToken);
            if (existSubCategory == null)
                return false;
            existSubCategory.IsDeleted = true;
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> UpdateAsync(SubCategory subCategory, CancellationToken cancellationToken)
        {
            try
            {
                var existSubCategory = await _appDbContext.SubCategories.FirstOrDefaultAsync(x => x.Id == subCategory.Id);
                if (existSubCategory == null)
                    return false;

                existSubCategory.Title = subCategory.Title;
                existSubCategory.PictureUrl = subCategory.PictureUrl;
                existSubCategory.CategoryId = subCategory.CategoryId;
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                throw new Exception("Logic error");
            }

        }

    }
}