using Microsoft.AspNetCore.Mvc;

namespace HFS.GeVe.Web.Controllers
{
    public class ApartamentoController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
