﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Domain.Core.Entities.Categories
{
    public class SubCategory
    {
        #region Propertes
        public int Id { get; set; }
        public string Title { get; set; }
        public string? PictureUrl { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime RegisterAt { get; set; } = DateTime.Now;
        #endregion

        #region NavigationProperties
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<HomeService>? HomeServices { get; set; } = new();
        #endregion
    }
}
