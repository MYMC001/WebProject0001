using MessagePack;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace TicketProject.Models
{
    public class Ticket
    {

        
        public int TicketID { get; set; }
        [Required]
        [Display(Name = "CustomerID")]
       
        public int CustomerID { get; set; }
        [Required]
        [Display(Name = "TravelID")]

        public int TravelID { get; set; }   
        public Travel Travel { get; set; }

        public Customer Customer { get; set; }
    }
}
