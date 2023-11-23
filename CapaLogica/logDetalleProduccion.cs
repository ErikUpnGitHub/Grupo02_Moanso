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
    public class logDetalleProduccion
    {
        private static readonly logDetalleProduccion instancia = new logDetalleProduccion();
        public static logDetalleProduccion Instancia
        {
            get { return logDetalleProduccion.instancia; }
        }

        public void InsertarDetalleProduccion(int idOrdenProduccion, int idProd_Term, int cantidad)
        {
            try
            {
                datDetalleProduccion.Instancia.InsertarDetalleProduccion(idOrdenProduccion, idProd_Term, cantidad);
            }
            catch (Exception e)
            { throw e; }
        }

        public DataTable MostrarDetalleProduccion(int idOrdenProduccion)
        {
            try
            {
                return datDetalleProduccion.Instancia.MostrarDetalleProduccion(idOrdenProduccion);
            }
            catch (Exception e) { throw e; }
        }

        public void RetirarDetalleProduccion(int idOrdenProduccion)
        {
            try
            {
                datDetalleProduccion.Instancia.RetirarDetalleProduccion(idOrdenProduccion);
            }
            catch (Exception e)
            { throw e; }
        }

        public void AnadirFechaProduccion(int idOrdenProduccion)
        {
            try
            {
                datDetalleProduccion.Instancia.AnadirFechaProduccion(idOrdenProduccion);
            }
            catch (Exception e)
            { throw e; }
        }

        public void ActualizarFechaVencimiento(int idOrdenProduccion, DateTime fechaVencimiento)
        {
            try
            {
                datDetalleProduccion.Instancia.ActualizarFechaVencimiento(idOrdenProduccion, fechaVencimiento);
            }
            catch (Exception e)
            { throw e; }
        }

        public DataTable MostrarDetallesProduccion(int idOrdenProduccion)
        {
            try
            {
                return datDetalleProduccion.Instancia.MostrarDetallesProduccion(idOrdenProduccion);
            }
            catch (Exception e) { throw e; }
        }
    }
}
