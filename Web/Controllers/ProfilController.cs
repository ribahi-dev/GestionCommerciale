using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ProfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
