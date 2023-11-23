using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenRequisicion
    {
        private int idOrdenRequisicion;
        private DateTime fechaEmision;
        private DateTime? fechaFin;
        private Boolean estado;

        public int IdOrdenRequisicion { get => idOrdenRequisicion; set => idOrdenRequisicion = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public DateTime? FechaFin { get => fechaFin; set => fechaFin = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
