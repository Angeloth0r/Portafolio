using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class CalendarioBaseDAO: ICrud<CalendarioBase>
    {
        public bool Create(CalendarioBase o)
        {
            try
            {
                //CommonBC.ModeloCentroMedico.CALENDARIO_BASE_INSERT(o.Fecha, o.Motivo, o.IdCentroMedico);
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
                //CommonBC.ModeloCentroMedico.CALENDARIO_BASE_DELETE(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public CalendarioBase Read(int id)
        {
            try
            {
                CalendarioBase cb = CommonBC.ModeloCentroMedico.CALENDARIO_BASE.First(f => f.ID == id);
                CalendarioBase calendarioBase = new CalendarioBase(cb.Id, cb.Fecha, cb.Motivo, cb.IdCentroMedico);

                return calendarioBase;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<CalendarioBase> ReadAll()
        {
            List<CalendarioBase> lista = null;
            try
            {
                var res = CommonBC.ModeloCentroMedico.CALENDARIO_BASE;

                lista = new List<CalendarioBase>();

                foreach (DALC.CALENDARIO_BASE item in res.ToList())
                {
                    CalendarioBase cb = new CalendarioBase();
                    cb.Id = item.ID;
                    cb.Fecha = item.FECHA;
                    cb.Motivo = item.MOTIVO;
                    cb.IdCentroMedico = item.CENTRO_MEDICO_ID;


                    lista.Add(cb);
                }
                return lista;
            }
            catch (Exception)
            {

                return lista;
            }
        }

        public bool Update(CalendarioBase o)
        {
            try
            {
                CommonBC.ModeloCentroMedico.CALENDARIO_BASE_UPDATE(o.Id, o.Fecha, o.Motivo, o.IdCentroMedico);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
