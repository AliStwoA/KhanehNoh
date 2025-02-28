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
    public class BaseDataRepository : IBaseDataRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public BaseDataRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<City>> GetCitiesAsync(CancellationToken cancellationToken) =>await  _dbContext.Cities.ToListAsync();
        
    }
}
