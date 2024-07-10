using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Response
{
    public class DetalleResponse
    {
        public int Id { get; set; }
        public int ProntId { get; set; }
        public int PreguntaId { get; set; }
        public int RespuestaId { get; set; }
        public string RespuestaTexto { get; set; }
    }
}
