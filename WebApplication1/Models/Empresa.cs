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
    
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            this.Neumatico = new HashSet<Neumatico>();
            this.Usuario_Perfil = new HashSet<Usuario_Perfil>();
        }
    
        public int Empresa_ID { get; set; }
        public Nullable<int> grupoempresa_id { get; set; }
        public string tipodoc { get; set; }
        public string nrodoc { get; set; }
        public string razonsocial { get; set; }
        public string nombrecom { get; set; }
        public string direccion { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string celular1 { get; set; }
        public string celular2 { get; set; }
        public string email { get; set; }
        public string web { get; set; }
        public string moneda { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public string estado { get; set; }
        public string usureg { get; set; }
        public Nullable<System.DateTime> fecreg { get; set; }
        public string usumod { get; set; }
        public Nullable<System.DateTime> fecmod { get; set; }
    
        public virtual Grupoempresa Grupoempresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Neumatico> Neumatico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario_Perfil> Usuario_Perfil { get; set; }
    }
}