using System.Collections.Generic;
using AdventureSports.Core.Models;
using AdventureSports.Models;

namespace AdventureSports.Models.ViewModels {

    public class ProductsListViewModel {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
