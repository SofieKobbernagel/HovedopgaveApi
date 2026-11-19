using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace RestBlaaBogLib
{
    public class BlaaBogDBContext : DbContext
    {
        public BlaaBogDBContext(
            DbContextOptions<BlaaBogDBContext> options
            ) : base(options) { }

        public DbSet<School> Skole { get; set; }
        public DbSet<Navn> Navn { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Telefon> Telefon { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<HjemmesideLink> HjemmesideLink { get; set; }
    }
}
