using KhanehNoh.Domain.Core.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Repository
{
    public interface IHomeServiceRepository
    {
        Task<List<HomeService>> GetAllAsync();

        Task<HomeService> GetByIdAsync(int id);

        Task AddAsync(HomeService homeService);

        Task UpdateAsync(HomeService homeService);

        Task DeleteAsync(int id);
    }
}
