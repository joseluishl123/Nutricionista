//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nutricionista
{
    using System;
    using System.Collections.Generic;
    
    public partial class HORARIOS
    {
        public int ID { get; set; }
        public int MEDICOID { get; set; }
        public System.DateTime FECHAATENCION { get; set; }
        public System.TimeSpan INICIOATENCION { get; set; }
        public System.TimeSpan FINATENCION { get; set; }
        public bool ACTIVO { get; set; }
        public System.DateTime FECHAREGISTRO { get; set; }
    
        public virtual MEDICOS MEDICOS { get; set; }
    }
}
