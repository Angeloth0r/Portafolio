using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class AgendaDAO: ICrud<Agenda>
    {
        public bool Create(Agenda o)
        {
            try
            {
                //CommonBC.ModeloCentroMedico.AGENDA_INSERT(o.Id, o.Fecha, o.HoraInicio, o.HoraTermino, o.IdMedico);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Delete(int id)
        {
            try
            {
                //CommonBC.ModeloCentroMedico.AGENDA_DELETE(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Agenda Read(int id)
        {
            try
            {
                Agenda age = CommonBC.ModeloCentroMedico.AGENDA.First(f => f.ID == id);
                Agenda agenda = new Agenda(age.Id, age.Fecha, age.HoraInicio, age.HoraTermino, age.IdMedico);

                return agenda;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Agenda> ReadAll()
        {
            List<Agenda> lista = null;
            try
            {
                var res = CommonBC.ModeloCentroMedico.AGENDA;

                lista = new List<Agenda>();

                foreach (DALC.AGENDA item in res.ToList())
                {
                    Agenda age = new Agenda();
                    age.Id = item.ID;
                    age.Fecha = item.FECHA;
                    age.HoraInicio = item.HORA_INICIO;
                    age.HoraTermino = item.HORA_TERMINO;
                    age.IdMedico = item.MEDICO_ID;

                    lista.Add(age);
                }
                return lista;
            }
            catch (Exception)
            {

                return lista;
            }
        }

        public bool Update(Agenda o)
        {
            try
            {
                //CommonBC.ModeloCentroMedico.AGENDA_UPDATE(o.Id, o.Fecha, o.HoraInicio, o.HoraTermino, o.IdMedico);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
