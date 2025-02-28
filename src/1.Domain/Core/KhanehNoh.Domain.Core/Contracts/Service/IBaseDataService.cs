using KhanehNoh.Domain.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Service
{
    public interface IBaseDataService
    {
        Task<List<City>> GetCitiesAsync(CancellationToken cancellationToken);
    }
}
