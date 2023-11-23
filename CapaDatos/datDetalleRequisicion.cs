using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datDetalleRequisicion
    {
        private static readonly datDetalleRequisicion instancia = new datDetalleRequisicion();
        public static datDetalleRequisicion Instancia
        {
            get { return datDetalleRequisicion.instancia; }
        }

        public Boolean InsertarDetalleRequisicion(int idMatPrima, int idOrdenRequis, int cantidad)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("InsertarDetalleRequisicion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdOrd_Requis", idOrdenRequis);
                cmd.Parameters.AddWithValue("@IdMater_Prim", idMatPrima);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { inserta = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public DataTable MostrarDetalleRequisicion(int id)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection cn = Conexion.Instancia.conectar())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarDetalleRequisicion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOrd_Requis", id);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dataTable.Load(dr);
                    }
                }
            }

            return dataTable;
        }

        public void RetirarDetalleRequisicion(int idDetalleRequisicion)
        {
            using (SqlConnection cn = Conexion.Instancia.conectar())
            {
                cn.Open();

                using (SqlCommand command = new SqlCommand("RetirarDetalleRequisicion", cn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdDetall_Reques", idDetalleRequisicion);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
