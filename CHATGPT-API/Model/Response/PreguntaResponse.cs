using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Response
{
    public class PreguntaResponse
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string PreguntaTexto { get; set; }
        public string Tipo { get; set; }
    }
}
