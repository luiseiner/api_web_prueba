using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using Model.Request;
using Model.Response;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreguntasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PreguntasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Preguntas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PreguntaResponse>>> GetPreguntas()
        {
            return await _context.Preguntas
                .Select(p => new PreguntaResponse
                {
                    Id = p.Id,
                    CategoriaId = p.CategoriaId,
                    PreguntaTexto = p.PreguntaTexto,
                    Tipo = p.Tipo
                })
                .ToListAsync();
        }

        // POST: api/Preguntas
        [HttpPost]
        public async Task<ActionResult<PreguntaResponse>> PostPregunta(PreguntaRequest request)
        {
            var pregunta = new Pregunta
            {
                CategoriaId = request.CategoriaId,
                PreguntaTexto = request.PreguntaTexto,
                Tipo = request.Tipo
            };

            _context.Preguntas.Add(pregunta);
            await _context.SaveChangesAsync();

            var response = new PreguntaResponse
            {
                Id = pregunta.Id,
                CategoriaId = pregunta.CategoriaId,
                PreguntaTexto = pregunta.PreguntaTexto,
                Tipo = pregunta.Tipo
            };

            return CreatedAtAction(nameof(GetPreguntas), new { id = pregunta.Id }, response);
        }
    }
}
