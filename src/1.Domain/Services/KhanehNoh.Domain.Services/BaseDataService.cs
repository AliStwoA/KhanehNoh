using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.Contracts.Service;
using KhanehNoh.Domain.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Services
{
    public class BaseDataService : IBaseDataService
    {
        private readonly IBaseDataRepository _baseDataRepository;

        public BaseDataService(IBaseDataRepository baseDataRepository)
        {
            _baseDataRepository = baseDataRepository;
        }

        public async Task <List<City>> GetCitiesAsync(CancellationToken cancellationToken) => await _baseDataRepository.GetCitiesAsync(cancellationToken);
        
    }
}
