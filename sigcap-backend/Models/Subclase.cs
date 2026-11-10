using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Subclase
    {
        public int Id { get; set; }
        public int Cod_subclase { get; set; }
        public string Descripcion{ get; set; }
        public Clase clase{ get; set; }
        public Subclase()
        {
        }

    }
}
