//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class FORMA_PAGO
    {
        public FORMA_PAGO()
        {
            this.ATENCION = new HashSet<ATENCION>();
        }
    
        public decimal FPA_ID { get; set; }
        public string FPA_NOMBRE { get; set; }
    
        public virtual ICollection<ATENCION> ATENCION { get; set; }
    }
}
