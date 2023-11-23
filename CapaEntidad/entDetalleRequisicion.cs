using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleRequisicion
    {
        private int idDetalle;
        private int idOrdenRequisicion;
        private int idMateriaPrima;
        private int cantidad;

        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public int IdOrdenRequisicion { get => idOrdenRequisicion; set => idOrdenRequisicion = value; }
        public int IdMateriaPrima { get => idMateriaPrima; set => idMateriaPrima = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
