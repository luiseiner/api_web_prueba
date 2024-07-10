using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Pront
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public DateTime FechaPront { get; set; }

        public Usuario Usuario { get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<Detalle> Detalles { get; set; }
    }
}
