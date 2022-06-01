using Microsoft.AspNetCore.Mvc;

namespace NovaBibiotecaVirtual.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
