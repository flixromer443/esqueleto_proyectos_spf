using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Subtipo_adquisicion
    {
        public int Id { get; set; }
        public string Tipo{ get; set; }
        public Tipo_adquisicion Tipo_Adquisicion { get; set; }
        public Subtipo_adquisicion()
        {
        }

    }
}
