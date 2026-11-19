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

        [HttpGet]
        public IActionResult GetAllSchools()
        {
            var schools = _dbContext.Skole
                .Include(s => s.Emails)
                .Include(s => s.Telefoner)
                .Include(s => s.Images)
                .ToList();
            return Ok(schools);
        }
    }
}
