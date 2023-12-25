using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;
using TicketProject.Models;

namespace TicketProject.Controllers
{
    [Authorize(Roles = "Admin")]

    public class TravelController : Controller
    {

       

       public  TravelDbContext _TravelDB;
        public TravelController (TravelDbContext TravelDB)
        {
            _TravelDB = TravelDB;
        }
        public IActionResult AddTravel()
        {
            return View();
        }

        public IActionResult Information() { 
        
           return View(_TravelDB.Travels.ToList());
        
        }
         public IActionResult Deletetravel(int id)
        {
            var delete=_TravelDB.Travels.FirstOrDefault(d=>d.TravelID==id);
            return View(delete);

        }

        public IActionResult UpdateTravel(int id)
        {
            var Update = _TravelDB.Travels.FirstOrDefault(d => d.TravelID == id);
            return View(Update);

        }







        [HttpPost]

        public async  Task<IActionResult> Addtravel(Travel travel)
        {
             _TravelDB.Add(travel);

            await  _TravelDB.SaveChangesAsync();    

            return RedirectToAction("AddTravel");
        }

        [HttpPost]

        public async Task<IActionResult> Deletetravel(Travel travel)
        {
            _TravelDB.Remove(travel);

            await _TravelDB.SaveChangesAsync();

            return RedirectToAction("Information");
        }

        [HttpPost]

        public async Task<IActionResult> UpdateTravel(Travel travel)
        {
            _TravelDB.Update(travel);

            await _TravelDB.SaveChangesAsync();

            return RedirectToAction("AddTravel");
        }
    }
}
