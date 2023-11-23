using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleProduccion
    {
        private int idDetalleProduccion;
        private int ordenProduccion;
        private int idProducto;
        private int cantidad;
        private DateTime? fechaProducido;
        private DateTime? fechaVencimiento;

        public int IdDetalleProduccion { get => idDetalleProduccion; set => idDetalleProduccion = value; }
        public int OrdenProduccion { get => ordenProduccion; set => ordenProduccion = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime? FechaProducido { get => fechaProducido; set => fechaProducido = value; }
        public DateTime? FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
    }
}
