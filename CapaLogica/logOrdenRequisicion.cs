using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logOrdenRequisicion
    {
        private static readonly logOrdenRequisicion instancia = new logOrdenRequisicion();
        public static logOrdenRequisicion Instancia
        {
            get { return logOrdenRequisicion.instancia; }
        }

        public List<entOrdenRequisicion> ListarOrden()
        {
            try
            {
                return datOrdenRequisicion.Instancia.ListarOrden();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void InsertarOrdenRequisicion()
        {
            try
            {
                datOrdenRequisicion.Instancia.InsertarOrdenRequisicion();
            }
            catch (Exception e)
            { throw e; }
        }

        public void CambiarEstadoOrdenRequisicion(int idOrden)
        {
            try
            {
                datOrdenRequisicion.Instancia.CambiarEstadoOrdenRequisicion(idOrden);
            }
            catch (Exception e)
            { throw e; }
        }

        public Boolean EditarOrden(entOrdenRequisicion orden)
        {
            try
            {
                return datOrdenRequisicion.Instancia.EditarOrden(orden);
            }
            catch (Exception e) { throw e; }
        }

        public List<entOrdenRequisicion> BuscarOrdenId(int id)
        {
            try
            {
                return datOrdenRequisicion.Instancia.BuscarOrdenId(id);
            }
            catch (Exception e) { throw e; }
        }

        public List<entOrdenRequisicion> ComboBoxRequisicion()
        {
            try
            {
                return datOrdenRequisicion.Instancia.ComboBoxRequisicion();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
