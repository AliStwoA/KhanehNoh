using KhanehNoh.Domain.Core.Entities.BaseEntities;
using KhanehNoh.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Contracts.Repository
{
    public interface IBaseDataRepository
    {
        Task <List<City>> GetCitiesAsync(CancellationToken cancellationToken);
        
    }
}
