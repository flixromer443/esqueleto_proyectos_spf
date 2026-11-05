using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Descripcion{ get; set; }
        public List<Rel_perfil_rol>? Perfiles{ get; set; }
        public Rol()
        {
        }

    }
}
