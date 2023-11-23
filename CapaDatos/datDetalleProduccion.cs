using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datDetalleProduccion
    {
        private static readonly datDetalleProduccion instancia = new datDetalleProduccion();
        public static datDetalleProduccion Instancia
        {
            get { return datDetalleProduccion.instancia; }
        }

        public Boolean InsertarDetalleProduccion(int idOrdenProduccion, int idProd_Term, int cantidad)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("InsertarDetalleProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdOrden_Pro", idOrdenProduccion);
                cmd.Parameters.AddWithValue("@IdProd_Term", idProd_Term);
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

        public DataTable MostrarDetalleProduccion(int idOrdenProduccion)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection cn = Conexion.Instancia.conectar())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarDetalleProduccion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOrden_Pro", idOrdenProduccion);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dataTable.Load(dr);
                    }
                }
            }

            return dataTable;
        }

        public void RetirarDetalleProduccion(int idDetalleProduccion)
        {
            using (SqlConnection cn = Conexion.Instancia.conectar())
            {
                cn.Open();

                using (SqlCommand command = new SqlCommand("RetirarDetalleProduccion", cn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdDetall_Pro", idDetalleProduccion);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AnadirFechaProduccion(int idDetalleProduccionProduccion)
        {
            using (SqlConnection cn = Conexion.Instancia.conectar())
            {
                cn.Open();

                using (SqlCommand command = new SqlCommand("AnadirFechaProduccion", cn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdDetall_Pro", idDetalleProduccionProduccion);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarFechaVencimiento(int idDetalleProduccionProduccion, DateTime fechaVencimiento)
        {
            using (SqlConnection cn = Conexion.Instancia.conectar())
            {
                cn.Open();

                using (SqlCommand command = new SqlCommand("ActualizarFechaVencimiento", cn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdDetall_Pro", idDetalleProduccionProduccion);
                    command.Parameters.AddWithValue("@Fecha_Venc", fechaVencimiento);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable MostrarDetallesProduccion(int idOrdenProduccion)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection cn = Conexion.Instancia.conectar())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarDetallesProduccion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOrdenPro", idOrdenProduccion);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dataTable.Load(dr);
                    }
                }
            }

            return dataTable;
        }
    }
}
