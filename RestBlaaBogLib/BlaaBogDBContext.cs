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
        public DbSet<Name> Navn { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Phone> Telefon { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Website> HjemmesideLink { get; set; }
        public DbSet<Secretary> Sekretariatet {  get; set; }
        public DbSet<SecretaryRole> SecretaryRole { get; set; }
        public DbSet<BoardMember> BoardMember { get; set; }
        public DbSet<BoardMemberRole> BoardMemberRole { get; set; }
    }
}
