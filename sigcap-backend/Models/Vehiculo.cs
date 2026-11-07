using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Dominio{ get; set; }
        public double kilometraje { get; set; }
        public string nro_motor{ get; set; }
        public string nro_chasis{ get; set; }
        public int anio{ get; set; }
        public Ficha_tecnica? Ficha_tecnica { get; set; }
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public Seguro seguro {  get; set; }
        public Mueble Mueble { get; set; }
        public Tipo_vehiculo Tipo_vehiculo { get; set; }
        public Vehiculo()
        {
        }

    }
}
