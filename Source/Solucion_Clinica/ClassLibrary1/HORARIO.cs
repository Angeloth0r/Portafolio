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
    
    public partial class HORARIO
    {
        public HORARIO()
        {
            this.CALENDARIO = new HashSet<CALENDARIO>();
        }
    
        public decimal HOR_ID { get; set; }
        public decimal HOR_LUNES { get; set; }
        public decimal HOR_MARTES { get; set; }
        public decimal HOR_MIERCOLES { get; set; }
        public decimal HOR_JUEVES { get; set; }
        public decimal HOR_VIERNES { get; set; }
        public decimal HOR_SABADO { get; set; }
        public decimal HOR_DOMINGO { get; set; }
        public System.DateTime HOR_INICIO { get; set; }
        public System.DateTime HOR_TERMINO { get; set; }
        public decimal MEDICO_MED_ID { get; set; }
    
        public virtual ICollection<CALENDARIO> CALENDARIO { get; set; }
        public virtual MEDICO MEDICO { get; set; }
    }
}