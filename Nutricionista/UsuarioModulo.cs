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
    
    public partial class UsuarioModulo
    {
        public string UsuMod_Usuario { get; set; }
        public int UsuMod_Modulo { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
