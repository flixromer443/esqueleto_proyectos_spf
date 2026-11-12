using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string Contrasenia{ get; set; }
        public Perfil perfil { get; set; }
        public Estado_sesion estado_sesion { get; set; }
        public Estado_usuario estado_usuario { get; set; }
        public Usuario()
        {
        }

    }
}
