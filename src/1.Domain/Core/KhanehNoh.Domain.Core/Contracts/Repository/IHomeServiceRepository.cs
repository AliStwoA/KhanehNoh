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
        Task<List<HomeService>?> GetHomeServicesAsync(CancellationToken cancellationToken);
        Task<List<HomeService>?> GetHomeServicesWithDetailsAsync(CancellationToken cancellationToken);
        Task<HomeService?> GetHomeServiceByIdAsync(int id, CancellationToken cancellationToken);
        Task<HomeService?> GetHomeServiceByIdWithDetailsAsync(int homeServiceId, CancellationToken cancellationToken);
        Task<bool> CreateAsync(HomeService homeService, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int homeServiceId, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(HomeService homeService, CancellationToken cancellationToken);
        Task<bool> IsDelete(int homeServiceId, CancellationToken cancellationToken);
    }
}
