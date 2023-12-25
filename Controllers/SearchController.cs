using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketProject.Models;

namespace TicketProject.Controllers
{
    public class SearchController : Controller
    {
        public TravelDbContext _TravelDB;
        public SearchController(TravelDbContext TravelDB)
        {
            _TravelDB = TravelDB;
        }
        public IActionResult Index()
        {
            return View();  
        }
    }
}
