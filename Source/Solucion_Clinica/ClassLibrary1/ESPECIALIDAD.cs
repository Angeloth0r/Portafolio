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
    
    public partial class ESPECIALIDAD
    {
        public ESPECIALIDAD()
        {
            this.MEDICO = new HashSet<MEDICO>();
        }
    
        public decimal ESP_ID { get; set; }
        public string ESP_NOMBRE { get; set; }
    
        public virtual ICollection<MEDICO> MEDICO { get; set; }
    }
}
