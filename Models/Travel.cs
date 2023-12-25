using System.ComponentModel.DataAnnotations;

namespace TicketProject.Models
{
    public class Travel
    {
        

        public int TravelID { get; set; }
        
        [Required]
        [Display(Name = "Location")]
        [MaxLength(100)]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Destination")]
        [MaxLength(100)]
        public string Destination { get; set; }
        [Required]
        [Display(Name = "Duration")]
        public TimeSpan duration { get; set; }
        [Required]
        [Display(Name = "DepartDate")]
        public DateTime Start { get; set; }
        [Required]
        [Display(Name = "ArrivelDate")]
        public DateTime End { get; set; }
        [Required]
        [Display(Name = "Passengers")]
        public int passengers { get; set; }
        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }

        public ICollection<Ticket> Tickets { get;}

        public ICollection<Customer> Customers { get; set; }    

    }
}
