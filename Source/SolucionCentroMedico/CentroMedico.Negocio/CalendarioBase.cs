using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class CalendarioBase
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public int IdCentroMedico { get; set; }

        public CalendarioBase()
        {
            this.Id = 0;
            this.Fecha = new DateTime();            
            this.Motivo = string.Empty;
            this.IdCentroMedico = 0;

        }
        public CalendarioBase(int id, DateTime fecha, string motivo, int idCentroMedico)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.Motivo = motivo;
            this.IdCentroMedico = idCentroMedico;

        }
    }
}
