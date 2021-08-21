using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using aec_webapi_ef.Models;
using aec_webapi_ef.Services;

namespace aec_webapi_ef.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfissoesController : ControllerBase
    {
        private readonly DbContexto _context;

        public ProfissoesController(DbContexto context)
        {
            _context = context;
        }

        // GET: api/Profissoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profissao>>> GetProfissoes()
        {
            return await _context.Profissoes.ToListAsync();
        }

        // GET: api/Profissoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profissao>> GetProfissao(int id)
        {
            var profissao = await _context.Profissoes.FindAsync(id);

            if (profissao == null)
            {
                return NotFound();
            }

            return profissao;
        }

        // PUT: api/Profissoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfissao(int id, Profissao profissao)
        {
            if (id != profissao.Id)
            {
                return BadRequest();
            }

            _context.Entry(profissao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfissaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Profissoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Profissao>> PostProfissao(Profissao profissao)
        {
            _context.Profissoes.Add(profissao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfissao", new { id = profissao.Id }, profissao);
        }

        // DELETE: api/Profissoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfissao(int id)
        {
            var profissao = await _context.Profissoes.FindAsync(id);
            if (profissao == null)
            {
                return NotFound();
            }

            _context.Profissoes.Remove(profissao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfissaoExists(int id)
        {
            return _context.Profissoes.Any(e => e.Id == id);
        }
    }
}
