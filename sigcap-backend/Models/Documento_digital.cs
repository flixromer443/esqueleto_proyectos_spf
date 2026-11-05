using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Documento_digital
    {
        public int Id { get; set; }
        public string Descripcion{ get; set; }
        public string Uri_archivo{ get; set; }
        public Tipo_documento_digital Tipo {  get; set; }
        public Documento_digital()
        {
        }

    }
}
