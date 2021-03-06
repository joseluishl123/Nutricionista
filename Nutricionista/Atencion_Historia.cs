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
    
    public partial class Atencion_Historia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Atencion_Historia()
        {
            this.AntecedentePersonal = new HashSet<AntecedentePersonal>();
            this.AntecednteFamiliar = new HashSet<AntecednteFamiliar>();
            this.Antropometria = new HashSet<Antropometria>();
            this.Frecuencia_Consmo = new HashSet<Frecuencia_Consmo>();
            this.HabitoDetalle = new HashSet<HabitoDetalle>();
            this.HistorialPeso = new HashSet<HistorialPeso>();
            this.Recordatorio = new HashSet<Recordatorio>();
        }
    
        public int Entr_Numero { get; set; }
        public string Entr_IdPaciente { get; set; }
        public System.DateTime Entr_FechaEntrada { get; set; }
        public Nullable<System.TimeSpan> Entr_Hora { get; set; }
        public string Entr_Diagnostico { get; set; }
        public int Entr_Concepto_Codigo { get; set; }
        public string Entr_Recomendacion { get; set; }
        public bool Entr_Reubicacion { get; set; }
        public Nullable<int> Entr_TipoExamenCodigo { get; set; }
        public Nullable<int> Ent_Enfasis { get; set; }
        public Nullable<int> Ent_Estado { get; set; }
        public string Ent_conceptoAptitud { get; set; }
        public Nullable<int> Ent_CodEPS { get; set; }
        public Nullable<int> Ent_CodARL { get; set; }
        public string Ent_MotivoConsulta { get; set; }
        public string Ent_CodMedico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AntecedentePersonal> AntecedentePersonal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AntecednteFamiliar> AntecednteFamiliar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Antropometria> Antropometria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Frecuencia_Consmo> Frecuencia_Consmo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HabitoDetalle> HabitoDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialPeso> HistorialPeso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recordatorio> Recordatorio { get; set; }
    }
}
