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
    
    public partial class AntecedentesP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AntecedentesP()
        {
            this.AntecedentePersonal = new HashSet<AntecedentePersonal>();
        }
    
        public int AnteP_Codigo { get; set; }
        public string AnteP_Descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AntecedentePersonal> AntecedentePersonal { get; set; }
    }
}
