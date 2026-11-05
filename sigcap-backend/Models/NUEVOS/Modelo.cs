using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Descripcion{ get; set; }
        public Marca Marca { get; set; }
        public Modelo()
        {
        }

    }
}
