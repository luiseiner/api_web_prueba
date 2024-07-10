using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.Request;
using Model.Response;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespuestasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RespuestasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Respuestas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RespuestaResponse>>> GetRespuestas()
        {
            return await _context.Respuestas
                .Select(r => new RespuestaResponse
                {
                    Id = r.Id,
                    PreguntaId = r.PreguntaId,
                    RespuestaTexto = r.RespuestaTexto
                })
                .ToListAsync();
        }

        // POST: api/Respuestas
        [HttpPost]
        public async Task<ActionResult<RespuestaResponse>> PostRespuesta(RespuestaRequest request)
        {
            var respuesta = new Respuesta
            {
                PreguntaId = request.PreguntaId,
                RespuestaTexto = request.RespuestaTexto
            };

            _context.Respuestas.Add(respuesta);
            await _context.SaveChangesAsync();

            var response = new RespuestaResponse
            {
                Id = respuesta.Id,
                PreguntaId = respuesta.PreguntaId,
                RespuestaTexto = respuesta.RespuestaTexto
            };

            return CreatedAtAction(nameof(GetRespuestas), new { id = respuesta.Id }, response);
        }
    }
}
