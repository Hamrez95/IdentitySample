using Microsoft.AspNetCore.Mvc;

namespace IdentitySample.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
