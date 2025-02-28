using KhanehNoh.Domain.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Entities.Orders
{
    public class Rating
    {
        #region Properties
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Status { get; set; } = false;
        public bool IsDeleted { get; set; } = false;            
        #endregion

        #region NavigationProperties
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ExpertId { get; set; }
        public Expert Expert { get; set; }
        #endregion
    }
}
