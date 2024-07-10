using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Detalle
    {
        public int Id { get; set; }
        public int ProntId { get; set; }
        public int PreguntaId { get; set; }
        public int RespuestaId { get; set; }
        public string RespuestaTexto { get; set; }

        public Pront Pront { get; set; }
        public Pregunta Pregunta { get; set; }
        public Respuesta Respuesta { get; set; }
    }
}
