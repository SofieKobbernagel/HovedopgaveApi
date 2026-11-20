using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestBlaaBogLib;

namespace HovedopgaveApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlaaBogController : Controller
    {
        private readonly BlaaBogDBContext _dbContext;
        public BlaaBogController(BlaaBogDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("schools")]
        public IActionResult GetAllSchools()
        {
            var schools = _dbContext.Skole
                .Include(s => s.Navn)
                .Include(s => s.Email)
                .Include(s => s.Telefon)
                .Include(s => s.Image)
                .Include(s => s.HjemmesideLink)
                .ToList();
            return Ok(schools);
        }

        [HttpGet("secretariat")]
        public IActionResult GetSecretari()
        {
            var secretari = _dbContext.Sekretariatet;

            return Ok(secretari);
        }
    }
}
