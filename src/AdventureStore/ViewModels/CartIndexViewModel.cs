using AdventureSports.Core.Models;
using AdventureSports.Models;

namespace AdventureSports.Models.ViewModels {

    public class CartIndexViewModel {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
