using KhanehNoh.Domain.Core.Entities.Orders;
using KhanehNoh.Domain.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Entities.BaseEntities
{
    public class City
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        #endregion

        #region NavigationProperties
        public List<User>? Users { get; set; } = new();
        public List<Request>? Requests { get; set; } = new();
        #endregion
    }
}
