using Microsoft.AspNetCore.Mvc;

namespace GGHospital.UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
