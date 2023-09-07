using Actividad.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Actividad.API.Controllers
{
    [ApiController]
    [Route("api/Researcher")]
    public class ResearcherController : ControllerBase
    {
        private readonly DataContext _context;

        public ResearcherController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Researcher.ToListAsync());
        }

        private ActionResult Ok(object value)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> Post(ResearcherController researcher)
        {
            _context.Add(researcher);
            await _context.SaveChangesAsync();
            return Ok(researcher);
        }

        [HttpGet("{id}")] // parametro
        public async Task<ActionResult> Get(int id)
        {
            int Id;

            var Researcher = await _context.Researcher.FirstOrDefaultAsync(x => x.Id == id);
            if (Researcher == null)
            {
                return NotFound();
            }
            return Ok(Researcher);
        }
    }
}