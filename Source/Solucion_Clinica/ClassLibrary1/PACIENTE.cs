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
    
    public partial class PACIENTE
    {
        public PACIENTE()
        {
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public decimal PAC_ID { get; set; }
        public decimal PAC_RUT { get; set; }
        public string PAC_DV { get; set; }
        public string PAC_NOMBRES { get; set; }
        public string PAC_PATERNO { get; set; }
        public string PAC_MATERNO { get; set; }
        public System.DateTime PAC_FNAC { get; set; }
        public string PAC_DIRECCION { get; set; }
        public Nullable<decimal> PAC_CELULAR { get; set; }
        public Nullable<decimal> PAC_TELEFONO { get; set; }
        public decimal PREVISION_PRE_ID { get; set; }
        public decimal USUARIO_USU_ID { get; set; }
    
        public virtual PREVISION PREVISION { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<RESERVA> RESERVA { get; set; }
    }
}