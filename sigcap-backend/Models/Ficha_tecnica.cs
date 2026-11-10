using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Ficha_tecnica
    {
        public int Id { get; set; }
        public Estado_operativo Estado_operativo{ get; set; }
        public Estado_afectacion Estado_afectacion { get; set; }
        public Combustible Combustible { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public List<Tarjeta_combustible>? Tarjetas_combustible {  get; set; }
        public List<Dispositivo_telepase>? Dispositivos_telepase { get; set; }
        public List<Mantenimiento>? Mantenimientos { get; set; }
        public List<Registro_fotografico>? Registros_forograficos { get; set; }
        public Ficha_tecnica()
        {
        }

    }
}
