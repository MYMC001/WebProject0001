using Microsoft.AspNetCore.Mvc;

namespace TicketProject.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
