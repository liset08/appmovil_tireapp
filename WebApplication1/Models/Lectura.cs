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
    
    public partial class Lectura
    {
        public int LecturaID { get; set; }
        public Nullable<int> sesion { get; set; }
        public Nullable<int> CamionID { get; set; }
        public Nullable<int> NeumaticoID { get; set; }
        public Nullable<decimal> presion { get; set; }
        public Nullable<decimal> desgaste_1 { get; set; }
        public Nullable<decimal> desgaste_2 { get; set; }
        public Nullable<decimal> desgaste_3 { get; set; }
        public Nullable<decimal> prom_desgaste { get; set; }
        public Nullable<decimal> varianza { get; set; }
        public Nullable<decimal> Kilometraje_Neu { get; set; }
        public string observacion { get; set; }
        public string estado { get; set; }
        public string usureg { get; set; }
        public Nullable<System.DateTime> fecreg { get; set; }
        public string usumod { get; set; }
        public Nullable<System.DateTime> fecmod { get; set; }
    
        public virtual Camion Camion { get; set; }
        public virtual Neumatico Neumatico { get; set; }
    }
}
