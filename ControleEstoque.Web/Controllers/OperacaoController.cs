using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class OperacaoController : Controller
    {
        public IActionResult EntradaEstoque()
        {
            return View();
        }

        public IActionResult SaidaEstoque()
        {
            return View();
        }

        public IActionResult PerdaProduto()
        {
            return View();
        }

        public IActionResult Inventario()
        {
            return View();
        }
    }
}
