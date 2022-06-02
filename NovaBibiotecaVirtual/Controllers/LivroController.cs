using Microsoft.AspNetCore.Mvc;

namespace NovaBibiotecaVirtual.Controllers
{
    public class LivroController : Controller
    {
        //Actions são as páginas e rotas
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }
    }
}
