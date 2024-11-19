using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class GraficoController : Controller
    {

        public IActionResult PerdaMes()
        {
            return View();
        }

        public IActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}
