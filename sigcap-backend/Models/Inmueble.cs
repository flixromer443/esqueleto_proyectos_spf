using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Inmueble
    {
        public int Id { get; set; }
        public string Latitud { get; set; }
        public string Longitud{ get; set; }
        public string Calle{ get; set; }
        public string Entre_calle_1{ get; set; }
        public string Entre_calle_2 { get; set; }
        public string Provincia{ get; set; }
        public int Numero{ get; set; }
        public string Cod_postal{ get; set; }
        public Codigo_qr? codigo_Qr { get; set; }
        public Situacion_dominial situacion_Dominial { get; set; }
        public List<Observacion_inmueble>? Observaciones{ get; set;}
        public List<Documento_digital>? Documentos_digitales { get; set;}
        public List<Registro_fotografico>? Registros_fotograficos { get; set;}
        public Inmueble()
        {
        }

    }
}
