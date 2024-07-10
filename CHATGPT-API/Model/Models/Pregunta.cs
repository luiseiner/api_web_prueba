using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Pregunta
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string PreguntaTexto { get; set; }
        public string Tipo { get; set; }

        public Categoria Categoria { get; set; }
        public ICollection<Respuesta> Respuestas { get; set; }
        public ICollection<Detalle> Detalles { get; set; }
    }
}
