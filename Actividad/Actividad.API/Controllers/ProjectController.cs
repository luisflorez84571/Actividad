using Actividad.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Controllers
{
    [ApiController]
    [Route("api/Project")]
    public class InvestigationController : ControllerBase
    {
        private readonly DataContext _context;

        public InvestigationController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Projects.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Project project)
        {
            _context.Add(project);
            await _context.SaveChangesAsync();
            return Ok(project);
        }

        [HttpGet("{id}")] // parametro
        public async Task<ActionResult> Get(int id)
        {
            var Investigation = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);
            if (Investigation == null)
            {
                return NotFound();
            }
            return Ok(Investigation);
        }
    }
}
