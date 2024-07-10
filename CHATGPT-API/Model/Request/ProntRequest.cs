using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Request
{
    public class ProntRequest
    {
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public DateTime FechaPront { get; set; }
    }
}
