using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.Entities.Users;
using KhanehNoh.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _db;
        public RoleRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Role role)
        {
            await _db.Roles.AddAsync(role);

            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var role = await _db.Roles.FindAsync(id);
            if (role != null)
            {
                _db.Roles.Remove(role);
                await _db.SaveChangesAsync();
            }

        }

        public async Task<List<Role>> GetAllAsync()
        {
            return await _db.Roles.ToListAsync();
        }

        public async Task<Role> GetByIdAsync(int id)
        {
            return await _db.Roles.FindAsync(id);
        }

        public async Task UpdateAsync(Role role)
        {
            _db.Roles.Update(role);
            await _db.SaveChangesAsync();
        }
    }
}
