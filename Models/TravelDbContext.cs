using AppIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace TicketProject.Models
{
    public class TravelDbContext:IdentityDbContext
    {

        public   DbSet<Travel> Travels { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Tickets{ get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public TravelDbContext (DbContextOptions<TravelDbContext> options) : base(options)
        {

        }
    }
}
