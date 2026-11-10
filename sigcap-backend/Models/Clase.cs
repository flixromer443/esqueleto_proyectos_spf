using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public int Cod_clase { get; set; }
        public string Descripcion{ get; set; }
        public Codigo_presupuestario Codigo_presupuestario{ get; set; }
        public List<Subclase>? Subclases { get; set; }
        public Clase()
        {
        }

    }
}
