using Microsoft.AspNetCore.Mvc;
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
            var schools = _dbContext.skole.ToList();
            return Ok(schools);
        }
    }
}
