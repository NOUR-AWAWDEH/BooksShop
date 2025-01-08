using Microsoft.EntityFrameworkCore;

namespace BookShop.Models.Data
{
    public class ApplicationDbContex : DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options)
        {
        }
        public DbSet<Catagory> TBCatagories { get; set; }
    }
}
