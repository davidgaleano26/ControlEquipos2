﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlEquipos2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class controlequiposEntities : DbContext
    {
        public controlequiposEntities()
            : base("name=controlequiposEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<caracteristicas> caracteristicas { get; set; }
        public virtual DbSet<dominios> dominios { get; set; }
        public virtual DbSet<equipos> equipos { get; set; }
        public virtual DbSet<marcas> marcas { get; set; }
        public virtual DbSet<perifericos> perifericos { get; set; }
        public virtual DbSet<personas> personas { get; set; }
        public virtual DbSet<salas> salas { get; set; }
        public virtual DbSet<software> software { get; set; }
        public virtual DbSet<solicitudes> solicitudes { get; set; }
        public virtual DbSet<equipos_caract> equipos_caract { get; set; }
        public virtual DbSet<equipos_software> equipos_software { get; set; }
        public virtual DbSet<solicitud_equipos> solicitud_equipos { get; set; }
    }
}