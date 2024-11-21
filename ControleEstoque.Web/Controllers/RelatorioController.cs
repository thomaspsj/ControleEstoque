using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class RelatorioController : Controller
    {
        [Authorize]
        public IActionResult PosicaoEstoque()
        {
            return View();
        }

        [Authorize]
        public IActionResult Ressuprimento()
        {
            return View();
        }
    }
}
