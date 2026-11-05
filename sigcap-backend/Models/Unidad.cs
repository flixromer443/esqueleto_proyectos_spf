using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Unidad
    {
        public int Id { get; set; }
        public string Descripcion{ get; set; }
        public double Kg_chatarra {  get; set; }
        List<Presupuesto>? Presupuestos { get; set; }
        List<Alerta_recuento_fisico>? alerta_Recuento_Fisicos { get; set; }
        public Unidad()
        {
        }

    }
}
