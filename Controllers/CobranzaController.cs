using INVERSER_Cobranza_API.Data;
using INVERSER_Cobranza_API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace INVERSER_Cobranza_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CobranzaController : ControllerBase
    {
        private readonly ILogger<CobranzaController> _logger;
        private readonly DataContext _context;

        public CobranzaController(ILogger<CobranzaController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("GetCobranza")]
        public async Task<ActionResult<IEnumerable<Cobranza>>> GetCobranza()
        {
            return await _context.Cobranza.ToListAsync();
        }

        [HttpGet("GetCobranzaById/{id}")]
        public async Task<ActionResult<Cobranza>> GetCobranzaById(int id){
            var cobranza = await _context.Cobranza.FindAsync(id);

            if(cobranza == null){
                return NotFound();
            }
            
            return cobranza;
        }

        [HttpPost]
        public async Task<ActionResult<Cobranza>> Save(Cobranza item){
            _context.Cobranza.Add(item);
            await _context.SaveChangesAsync();

            return new CreatedAtRouteResult("GetCobranza", new {id = item.Id}, item);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Cobranza item){
            if(id != item.Id){
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Cobranza>> Delete(int id)
        {
            var cobranza = await _context.Cobranza.FindAsync(id);

            if(cobranza == null){
                return NotFound();
            }

            _context.Cobranza.Remove(cobranza);
            await _context.SaveChangesAsync();

            return cobranza;
        }
    }
}