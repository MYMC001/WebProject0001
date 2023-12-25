using Microsoft.AspNetCore.Mvc;

namespace TicketProject.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
