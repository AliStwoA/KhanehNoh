using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.Contracts.Service;
using KhanehNoh.Domain.Core.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Services
{
    public class HomeServiceService: IHomeServiceService
    {
        private readonly IHomeServiceRepository _homeServiceRepository;

        public HomeServiceService(IHomeServiceRepository homeServiceRepository)
        {
            _homeServiceRepository = homeServiceRepository;
        }

       public async Task<List<HomeService>?> GetHomeServicesAsync(CancellationToken cancellationToken)
            =>await _homeServiceRepository.GetHomeServicesAsync(cancellationToken);

       public async Task<bool> CreateAsync(HomeService homeService, CancellationToken cancellationToken)
            =>await _homeServiceRepository.CreateAsync(homeService, cancellationToken);

        public async Task<List<HomeService>?> GetHomeServicesWithDetailsAsync(CancellationToken cancellationToken)
        => await _homeServiceRepository.GetHomeServicesWithDetailsAsync(cancellationToken);

        public async Task<HomeService?> GetHomeServiceByIdAsync(int id, CancellationToken cancellationToken)
        => await _homeServiceRepository.GetHomeServiceByIdAsync(id, cancellationToken);

        public async Task<HomeService?> GetHomeServiceByIdWithDetailsAsync(int homeServiceId, CancellationToken cancellationToken)
        => await _homeServiceRepository.GetHomeServiceByIdWithDetailsAsync(homeServiceId, cancellationToken);

        public async Task<bool> DeleteAsync(int homeServiceId, CancellationToken cancellationToken)
        => await _homeServiceRepository.DeleteAsync(homeServiceId, cancellationToken);

        public async Task<bool> UpdateAsync(HomeService homeService, CancellationToken cancellationToken)
        => await _homeServiceRepository.UpdateAsync(homeService, cancellationToken);

        public async Task<bool> IsDelete(int homeServiceId, CancellationToken cancellationToken)
        => await _homeServiceRepository.IsDelete(homeServiceId, cancellationToken);
    }
}
