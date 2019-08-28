using Microsoft.EntityFrameworkCore;
using TsmContactDirectory.Models;

namespace TsmContactDirectory.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
