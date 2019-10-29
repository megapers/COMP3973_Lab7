using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab7.Data;
using Lab7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace Lab7.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("PartyPolicy")] 
    public class PartiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PartiesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Parties
        [HttpGet("GetAllParties")]
        public async Task<ActionResult<IEnumerable<Party>>> GetAllPartiesAsync()
        {
            return await _context.Parties.ToListAsync();
        }
    }
}
