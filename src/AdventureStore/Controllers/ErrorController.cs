using Microsoft.AspNetCore.Mvc;

namespace AdventureSports.Controllers {

    public class ErrorController : Controller {

        public ViewResult Error() => View();
    }
}
