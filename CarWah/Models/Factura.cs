//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarWah.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        public int Codigo { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> EmpleadoId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual FacturaDetail FacturaDetail { get; set; }
    }
}
