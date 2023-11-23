using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logOrdenProduccion
    {
        private static readonly logOrdenProduccion instancia = new logOrdenProduccion();
        public static logOrdenProduccion Instancia
        {
            get { return logOrdenProduccion.instancia; }
        }

        public List<entOrdenProduccion> ListarOrden()
        {
            try
            {
                return datOrdenProduccion.Instancia.ListarOrden();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Boolean EditarOrden(entOrdenProduccion orden)
        {
            try
            {
                return datOrdenProduccion.Instancia.EditarOrden(orden);
            }
            catch (Exception e) { throw e; }
        }

        public void InsertarOrdenRequisicion(int idOrden)
        {
            try
            {
                datOrdenProduccion.Instancia.InsertarOrdenProduccion(idOrden);
            }
            catch (Exception e)
            { throw e; }
        }

        public void AnadirFechaInicioOrdenProduccion(int idOrdenProduccion)
        {
            try
            {
                datOrdenProduccion.Instancia.AnadirFechaInicioOrdenProduccion(idOrdenProduccion);
            }
            catch (Exception e)
            { throw e; }
        }

        public void AnadirFechaFinOrdenProduccion(int idOrdenProduccion)
        {
            try
            {
                datOrdenProduccion.Instancia.AnadirFechaFinOrdenProduccion(idOrdenProduccion);
            }
            catch (Exception e)
            { throw e; }
        }

        public List<entOrdenProduccion> ComboBoxOrdenProduccion()
        {
            try
            {
                return datOrdenProduccion.Instancia.ComboBoxOrdenProduccion();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
