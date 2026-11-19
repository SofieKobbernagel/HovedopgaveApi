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

    }
}
