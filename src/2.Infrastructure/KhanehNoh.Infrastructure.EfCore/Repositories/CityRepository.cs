using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.Entities.BaseEntities;
using KhanehNoh.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _db;
        public CityRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(City city)
        {
            await _db.Cities.AddAsync(city);

            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var city = await _db.Cities.FindAsync(id);
            if (city != null)
            {
                _db.Cities.Remove(city);
                await _db.SaveChangesAsync();
            }

        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _db.Cities.ToListAsync();
        }

        public async Task<City> GetByIdAsync(int id)
        {
            return await _db.Cities.FindAsync(id);
        }

        public async Task UpdateAsync(City city)
        {
            _db.Cities.Update(city);
            await _db.SaveChangesAsync();
        }
    }
}
