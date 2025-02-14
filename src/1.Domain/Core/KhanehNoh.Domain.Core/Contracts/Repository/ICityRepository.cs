using KhanehNoh.Domain.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Repository
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllAsync();

        Task<City> GetByIdAsync(int id);

        Task AddAsync(City city);

        Task UpdateAsync(City city);

        Task DeleteAsync(int id);
    }
}
