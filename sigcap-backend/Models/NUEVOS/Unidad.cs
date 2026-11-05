using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Unidad
    {
        public int Id { get; set; }
        public string Descripcion{ get; set; }
        public double Kg_chatarra {  get; set; }
        List<Presupuesto> Presupuestos { get; set; }
        public Unidad()
        {
        }

    }
}
