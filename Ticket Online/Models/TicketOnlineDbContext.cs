using Microsoft.EntityFrameworkCore;
using Ticket_Online.Areas.Admin.Models;

namespace Ticket_Online.Models
{
    public class TicketOnlineDbContext: DbContext
    {
        public TicketOnlineDbContext(DbContextOptions<TicketOnlineDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { set; get; }

    }
}
