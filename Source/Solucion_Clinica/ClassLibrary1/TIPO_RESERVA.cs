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
    
    public partial class TIPO_RESERVA
    {
        public TIPO_RESERVA()
        {
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public decimal TRE_ID { get; set; }
        public string TRE_NOMBRE { get; set; }
    
        public virtual ICollection<RESERVA> RESERVA { get; set; }
    }
}