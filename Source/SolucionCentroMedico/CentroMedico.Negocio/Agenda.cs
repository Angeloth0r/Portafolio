using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class Agenda
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public int IdMedico { get; set; }
        
        public Agenda()
        {
            this.Id = 0;
            this.Fecha = new DateTime();
            this.HoraInicio = new DateTime();
            this.HoraTermino = new DateTime();
            this.IdMedico = 0;
            
        }
        public Agenda(int id, DateTime fecha, DateTime horaInicio, DateTime horaTermino, int idMedico)
        {
            this.Id = id;
            this.Fecha = Fecha;
            this.HoraInicio = horaInicio;
            this.HoraTermino = HoraTermino;
            this.IdMedico = idMedico;
        }
    }
}
