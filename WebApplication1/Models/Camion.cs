//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Camion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Camion()
        {
            this.Camion_neumaticos = new HashSet<Camion_neumaticos>();
            this.Lectura = new HashSet<Lectura>();
        }
    
        public int camion_ID { get; set; }
        public Nullable<int> empresa_id { get; set; }
        public string placa { get; set; }
        public string tag { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public Nullable<int> ejes { get; set; }
        public Nullable<int> num_llantas { get; set; }
        public Nullable<decimal> carga_util { get; set; }
        public Nullable<decimal> carga_neta { get; set; }
        public Nullable<decimal> Kilometraje { get; set; }
        public string estado { get; set; }
        public string usureg { get; set; }
        public Nullable<System.DateTime> fecreg { get; set; }
        public string usumod { get; set; }
        public Nullable<System.DateTime> fecmod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Camion_neumaticos> Camion_neumaticos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lectura> Lectura { get; set; }
    }
}
