//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class solicitud_equipos
    {
        public string serial_equipo { get; set; }
        public int nro_solicitud { get; set; }
        public string det_solicitud { get; set; }
    
        public virtual equipos equipos { get; set; }
        public virtual solicitudes solicitudes { get; set; }
    }
}