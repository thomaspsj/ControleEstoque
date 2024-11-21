using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class OperacaoController : Controller
    {
        [Authorize]
        public IActionResult EntradaEstoque()
        {
            return View();
        }

        [Authorize]
        public IActionResult SaidaEstoque()
        {
            return View();
        }

        [Authorize]
        public IActionResult PerdaProduto()
        {
            return View();
        }

        [Authorize]
        public IActionResult Inventario()
        {
            return View();
        }
    }
}
