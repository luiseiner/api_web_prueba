using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Respuesta
    {
        public int Id { get; set; }
        public int PreguntaId { get; set; }
        public string RespuestaTexto { get; set; }

        public Pregunta Pregunta { get; set; }
        public ICollection<Detalle> Detalles { get; set; }
    }
}
