using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace TicketProject.Models
{
    public class Customer
    {
       
        public int CustomerID { get; set; }
        [Required]
        [Display(Name = "Location")]
        [MaxLength(100)]
        public  string?  FirstName {  get; set; }
        [Required]
        [Display(Name = "Location")]
        [MaxLength(100)]
        public string? LastName { get; set; }

        public Travel? Travel { get; set; } 

    }
}
