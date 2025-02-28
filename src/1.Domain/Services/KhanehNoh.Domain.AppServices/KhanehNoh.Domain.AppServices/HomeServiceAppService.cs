using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Contracts.Service;
using KhanehNoh.Domain.Core.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.AppServices
{
    public class HomeServiceAppService : IHomeServiceAppService
    {
        private readonly IHomeServiceService _homeServiceService;

        public HomeServiceAppService(IHomeServiceService homeServiceService)
        {
            _homeServiceService = homeServiceService;
        }

        public async Task<List<HomeService>?> GetHomeServicesAsync(CancellationToken cancellationToken)
            => await _homeServiceService.GetHomeServicesAsync(cancellationToken);

        public async Task<bool> CreateAsync(HomeService homeService, CancellationToken cancellationToken)
             => await _homeServiceService.CreateAsync(homeService, cancellationToken);

        public async Task<List<HomeService>?> GetHomeServicesWithDetailsAsync(CancellationToken cancellationToken)
        => await _homeServiceService.GetHomeServicesWithDetailsAsync(cancellationToken);

        public async Task<HomeService?> GetHomeServiceByIdAsync(int id, CancellationToken cancellationToken)
        => await _homeServiceService.GetHomeServiceByIdAsync(id, cancellationToken);

        public async Task<HomeService?> GetHomeServiceByIdWithDetailsAsync(int homeServiceId, CancellationToken cancellationToken)
        => await _homeServiceService.GetHomeServiceByIdWithDetailsAsync(homeServiceId, cancellationToken);

        public async Task<bool> DeleteAsync(int homeServiceId, CancellationToken cancellationToken)
        => await _homeServiceService.DeleteAsync(homeServiceId, cancellationToken);

        public async Task<bool> UpdateAsync(HomeService homeService, CancellationToken cancellationToken)
        => await _homeServiceService.UpdateAsync(homeService, cancellationToken);

        public async Task<bool> IsDelete(int homeServiceId, CancellationToken cancellationToken)
        => await _homeServiceService.IsDelete(homeServiceId, cancellationToken);
    }
}
