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
    
    public partial class CAJERO
    {
        public decimal PER_ID { get; set; }
        public decimal CJR_ID { get; set; }
        public decimal CAJA_CAJ_ID { get; set; }
    
        public virtual CAJA CAJA { get; set; }
        public virtual PERSONAL PERSONAL { get; set; }
    }
}