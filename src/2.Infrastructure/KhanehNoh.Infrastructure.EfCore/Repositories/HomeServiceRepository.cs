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
    public class HomeServiceRepository : IHomeServiceRepository
    {
        private readonly ApplicationDbContext _db;
        public HomeServiceRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(HomeService homeService)
        {
            await _db.HomeServices.AddAsync(homeService);

            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var homeService = await _db.HomeServices.FindAsync(id);
            if (homeService != null)
            {
                _db.HomeServices.Remove(homeService);
                await _db.SaveChangesAsync();
            }

        }

        public async Task<List<HomeService>> GetAllAsync()
        {
            return await _db.HomeServices.ToListAsync();
        }

        public async Task<HomeService> GetByIdAsync(int id)
        {
            return await _db.HomeServices.FindAsync(id);
        }

        public async Task UpdateAsync(HomeService homeService)
        {
            _db.HomeServices.Update(homeService);
            await _db.SaveChangesAsync();
        }
    }
}
