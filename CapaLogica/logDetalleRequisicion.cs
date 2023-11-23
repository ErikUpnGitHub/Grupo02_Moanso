using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logDetalleRequisicion
    {
        private static readonly logDetalleRequisicion instancia = new logDetalleRequisicion();
        public static logDetalleRequisicion Instancia
        {
            get { return logDetalleRequisicion.instancia; }
        }

        public void InsertarDetalleRequisicion(int idMatPrima, int idOrdenRequis, int cantidad)
        {
            try
            {
                datDetalleRequisicion.Instancia.InsertarDetalleRequisicion(idMatPrima, idOrdenRequis, cantidad);
            }
            catch (Exception e)
            { throw e; }
        }

        public DataTable MostrarDetalleRequisicion(int id)
        {
            try
            {
                return datDetalleRequisicion.Instancia.MostrarDetalleRequisicion(id);
            }
            catch (Exception e) { throw e; }
        }

        public void RetirarDetalleRequisicion(int idDetalle)
        {
            try
            {
                datDetalleRequisicion.Instancia.RetirarDetalleRequisicion(idDetalle);
            }
            catch (Exception e)
            { throw e; }
        }
    }
}
