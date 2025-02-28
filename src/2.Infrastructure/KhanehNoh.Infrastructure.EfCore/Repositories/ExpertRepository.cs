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
    public class ExpertRepository : IExpertRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public ExpertRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Expert>> GetExpertsAsync(CancellationToken cancellationToken)
            => await _appDbContext.Experts.AsNoTracking()
            .ToListAsync(cancellationToken);

        public async Task<Expert?> GetExpertByIdAsync(int id, CancellationToken cancellationToken)
         => await _appDbContext
         .Experts
         .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

        public async Task<List<Expert>> GetExpertsWithDetailsAsync(CancellationToken cancellationToken)
           => await _appDbContext
            .Experts
            .Include(e => e.User)
            .Include(e => e.HomeServices)
            .ThenInclude(e => e.SubCategory)
            .ThenInclude(e => e.Category)
            .Include(e => e.Offers)
            .ToListAsync(cancellationToken);

        public async Task<Expert?> GetExpertByIdWithDetailsAsync(int id, CancellationToken cancellationToken)
            => await _appDbContext
            .Experts
            .Include(e => e.User)
            .Include(e => e.HomeServices)
            .ThenInclude(e => e.SubCategory)
            .ThenInclude(e => e.Category)
            .Include(e => e.Offers)
            .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);



        public async Task<bool> CreateAsync(Expert expert, CancellationToken cancellationToken)
        {
            try
            {
                await _appDbContext.Experts.AddAsync(expert, cancellationToken);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Expert expert, CancellationToken cancellationToken)
        {
            try
            {
                _appDbContext.Experts.Remove(expert);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Expert expert, CancellationToken cancellationToken)
        {
            try
            {
                var existExpert = await _appDbContext.Experts.Include(a => a.User).FirstOrDefaultAsync(c => c.Id == expert.Id, cancellationToken);

                if (existExpert == null)
                    return false;

                existExpert.User.Address = expert.User.Address;
                existExpert.User.FirstName = expert.User.FirstName;
                existExpert.User.LastName = expert.User.LastName;
                existExpert.User.Email = expert.User.Email;
                existExpert.User.CityId = expert.User.CityId;
                existExpert.User.PictureUrl = expert.User.PictureUrl;
                existExpert.User.PhoneNumber = expert.User.PhoneNumber;

                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                throw new Exception("Logic Errorr!!!");
            }
        }
    }
}
