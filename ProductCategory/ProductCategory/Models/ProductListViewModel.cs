using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCategory.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
    }
}