using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Bien
    {
        public int Id { get; set; }
        public DateTime F_adq { get; set; }
        public double Valor_unitario { get; set; }
        public string Descripcion { get; set; }
        public string Nro_expediente { get; set; }
        public Subtipo_adquisicion Subtipo_adquisicion { get; set; }
        public Tipo_adquisicion Tipo_adquisicion{ get; set; }
        public Codigo_presupuestario Codigo_presupuestario { get; set; }
        public Presupuesto Presupuesto{ get; set; }
        List<Observacion_bien> Observacion_bien { get; set;}
        List<Bien_de_uso> Bien_de_uso {  get; set;}
        public Bien()
        {
        }

    }
}
