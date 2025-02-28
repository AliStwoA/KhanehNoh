using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Contracts.Service;
using KhanehNoh.Domain.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.AppServices
{
    public class BaseDataAppService : IBaseDataAppService
    {
        private readonly IBaseDataService _baseDataService;

        public BaseDataAppService(IBaseDataService baseDataService)
        {
            _baseDataService = baseDataService;
        }

        public async Task <List<City>> GetCitiesAsync(CancellationToken cancellationToken) => await _baseDataService.GetCitiesAsync(cancellationToken);
        
            
        
    }
}
