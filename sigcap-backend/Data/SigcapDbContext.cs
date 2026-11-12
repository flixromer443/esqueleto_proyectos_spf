using Microsoft.EntityFrameworkCore;
using sigcapbackend.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Data
{
    public class SigcapDbContext : DbContext
    {
        public SigcapDbContext(DbContextOptions<SigcapDbContext> options) : base(options)
        {

        }

        public DbSet<Agente_asociado> Agentes_asociados { get; set; }
        public DbSet<Alerta_recuento_fisico> Alertas_recuento_fisico{ get; set; }
        public DbSet<Bien> Bienes { get; set; }
        public DbSet<Bien_de_uso> Bienes_de_uso { get; set; }
        public DbSet<Clase> Clases{ get; set; }
        public DbSet<Codigo_presupuestario> Codigos_presupuestarios { get; set; }
        public DbSet<Codigo_qr> Codigos_qr { get; set; }
        public DbSet <Combustible> Combustibles { get; set; }
        public DbSet<Dispositivo_telepase> Dispositivos_telepase { get; set; }
        public DbSet<Documento_digital> Documentos_digitales { get; set; }
        public DbSet<Estado_afectacion> Estados_afectacion { get; set; }
        public DbSet<Estado_alerta_recuento_fisico> Estados_alerta_recuento_fisico { get; set; }
        public DbSet<Estado_bien_de_uso> Estados_bienes_de_uso{ get; set; }
        public DbSet<Estado_dispositivo_telepase> Estados_dispositivos_telepase { get; set; }
        public DbSet<Estado_operativo> Estados_operativos { get; set; }
        public DbSet<Estado_sesion> Estados_sesion{ get; set; }
        public DbSet<Estado_tarjeta_combustible> Estados_tarjetas_combustible { get; set; }
        public DbSet<Estado_usuario> Estados_usuarios { get; set; }
        public DbSet<Ficha_tecnica> Fichas_tecnicas { get; set; }
        public DbSet<Historico_cambio_unidad_bien_de_uso> Historicos_cambio_unidad_bien_de_uso { get; set; }
        public DbSet<Historico_estado_afectacion> Historicos_estado_afectacion { get; set; }
        public DbSet<Historico_estado_alerta_recuento_fisico> Historicos_estado_alerta_recuento_fisico { get; set; }
        public DbSet<Historico_estado_bien_de_uso> Historicos_estado_bien_de_uso { get; set; }
        public DbSet<Historico_estado_dispositivo_telepase> Historicos_estado_dispositivo_telepase { get; set; }
        public DbSet<Historico_estado_operativo> Historicos_estado_operativo { get; set; }
        public DbSet<Historico_estado_sesion> Historicos_estado_sesion { get; set; }
        public DbSet<Historico_estado_tarjeta_combustible> Historicos_estado_tarjeta_combustible { get; set; }
        public DbSet<Historico_estado_usuario> Historicos_estado_usuario { get; set; }
        public DbSet<Historico_situacion_dominial> Historicos_situacion_dominial { get; set; }
        public DbSet<Inmueble> Inmuebles { get; set; }
        public DbSet<Mantenimiento> Mantenimientos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Mueble> Muebles { get; set; }
        public DbSet<Observacion_bien> Observaciones_bien { get; set; }
        public DbSet<Observacion_inmueble> Observaciones_inmueble { get; set; }
        public DbSet<Observacion_mueble> Observaciones_muebles { get; set; }
        public DbSet<Partida_presupuestaria> Partidas_presupuestarias { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Registro_fotografico> Registros_forograficos { get; set; }
        public DbSet<Rel_perfil_rol> Rel_perfiles_roles { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Situacion_dominial> Situaciones_dominiales { get; set; }
        public DbSet<Subclase> Subclases{ get; set; }
        public DbSet<Subtipo_adquisicion> Subtipos_adquisicion { get; set; }
        public DbSet<Taller_mecanico> Talleres_mecanicos { get; set; }
        public DbSet<Tarjeta_combustible> Tarjetas_combustible { get; set; }
        public DbSet<Tipo_adquisicion> Tipos_adquisicion { get; set; }
        public DbSet<Tipo_baja> Tipos_baja { get; set; }
        public DbSet<Tipo_documento_digital> Tipos_documentos_digitales { get; set; }
        public DbSet<Tipo_estado_historico> Tipos_estado_historicos { get; set; }
        public DbSet<Tipo_vehiculo> Tipos_vehiculos { get; set; }
        public DbSet<Unidad> Unidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Vida_util> Vidas_utiles{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Inmueble>()
                .HasOne(i => i.codigo_Qr)
                .WithOne(cq => cq.inmueble)
                .HasForeignKey<Codigo_qr>("Inmueble_id") 
                .OnDelete(DeleteBehavior.SetNull);      

            modelBuilder.Entity<Mueble>()
                 .HasOne(m => m.codigo_Qr)
                 .WithOne(cq => cq.mueble)
                 .HasForeignKey<Codigo_qr>("Mueble_id") 
                 .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Ficha_tecnica>()
                 .HasOne(v => v.Vehiculo)
                 .WithOne(ft=> ft.Ficha_tecnica)
                 .HasForeignKey<Vehiculo>("Ficha_tecnica_id")
                 .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Vehiculo>()
                 .HasOne(v => v.Mueble)
                 .WithOne(m => m.vehiculo)
                 .HasForeignKey<Mueble>("Vehiculo_id")
                 .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Vida_util>()
                 .HasOne(vu => vu.codigo_presupuestario)
                 .WithOne(cp => cp.vida_util)
                 .HasForeignKey<Codigo_presupuestario>("Vida_util_id")
                 .OnDelete(DeleteBehavior.SetNull);
        }
      
    }
}