using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Codigo_presupuestario
    {
        public int Id { get; set; }
        public int Codigo{ get; set; }
        public string Descripcion{ get; set; }
        public List<Clase>? Clases { get; set; }
        public Codigo_presupuestario()
        {
        }

    }
}
