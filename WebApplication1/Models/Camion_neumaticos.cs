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
    
    public partial class Camion_neumaticos
    {
        public int camion_neum_ID { get; set; }
        public Nullable<int> camion_id { get; set; }
        public Nullable<int> neumatico_id { get; set; }
        public Nullable<decimal> Kilometraje_act { get; set; }
        public string posicion { get; set; }
        public string estadouso { get; set; }
        public string usureg { get; set; }
        public Nullable<System.DateTime> fecreg { get; set; }
        public string usumod { get; set; }
        public Nullable<System.DateTime> fecmod { get; set; }
    
        public virtual Camion Camion { get; set; }
        public virtual Neumatico Neumatico { get; set; }
    }
}
