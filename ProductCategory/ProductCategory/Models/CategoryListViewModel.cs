using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCategory.Models
{
    public class CategoryListViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;
    }
}