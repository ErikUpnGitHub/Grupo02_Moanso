using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenProduccion
    {
        private int idOrdenProduccion;
        private int idOrdenRequisicion;
        private DateTime fechaEmision;
        private DateTime? fechaInicio;
        private DateTime? fecheFin;
        private Boolean estado;

        public int IdOrdenProduccion { get => idOrdenProduccion; set => idOrdenProduccion = value; }
        public int IdOrdenRequisicion { get => idOrdenRequisicion; set => idOrdenRequisicion = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public DateTime? FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime? FecheFin { get => fecheFin; set => fecheFin = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
