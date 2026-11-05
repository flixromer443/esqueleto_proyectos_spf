using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Rel_perfil_rol
    {
        public int Id { get; set; }

        public Perfil perfil{ get; set; }
        public Rol rol { get; set; }
        public Rel_perfil_rol()
        {
        }

    }
}
