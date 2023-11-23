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
    public class datOrdenProduccion
    {
        private static readonly datOrdenProduccion instancia = new datOrdenProduccion();
        public static datOrdenProduccion Instancia
        {
            get { return datOrdenProduccion.instancia; }
        }

        public List<entOrdenProduccion> ListarOrden()
        {
            SqlCommand cmd = null;
            List<entOrdenProduccion> lista = new List<entOrdenProduccion>();

            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("ListarOrdenProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entOrdenProduccion or = new entOrdenProduccion();

                    or.IdOrdenProduccion = Convert.ToInt32(dr["IdOrden_Pro"]);
                    or.IdOrdenRequisicion = Convert.ToInt32(dr["IdOrd_Requis"]);
                    or.FechaEmision = Convert.ToDateTime(dr["Fecha_Emis"]);

                    try
                    { or.FechaInicio = Convert.ToDateTime(dr["Fecha_Inic"]); }
                    catch (Exception)
                    { or.FechaInicio = null; }

                    try
                    { or.FecheFin = Convert.ToDateTime(dr["Fecha_Fin"]); }
                    catch (Exception)
                    { or.FecheFin = null; }

                    or.Estado = Convert.ToBoolean(dr["Estado_Orden"]);

                    lista.Add(or);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

            return lista;
        }

        public Boolean InsertarOrdenProduccion(int idRequisicion)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("InsertarOrdenProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOrd_Requis", idRequisicion);

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

        public Boolean EditarOrden(entOrdenProduccion orden)
        {

            SqlCommand cmd = null;
            Boolean Edito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("EditarOrdenProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdOrden_Pro", orden.IdOrdenProduccion);
                cmd.Parameters.AddWithValue("@IdOrd_Requis", orden.IdOrdenRequisicion);
                cmd.Parameters.AddWithValue("@Fecha_Emis", orden.FechaEmision);
                cmd.Parameters.AddWithValue("@Fecha_Inic", orden.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha_Fin", orden.FecheFin);
                cmd.Parameters.AddWithValue("@EstadoOrden", orden.Estado);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { Edito = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Edito;
        }

        public List<entOrdenProduccion> ComboBoxOrdenProduccion()
        {
            SqlCommand cmd = null;
            List<entOrdenProduccion> lista = new List<entOrdenProduccion>();

            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("ComboBoxOrdenProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entOrdenProduccion or = new entOrdenProduccion();

                    or.IdOrdenProduccion = Convert.ToInt32(dr["IdOrden_Pro"]);
                    or.IdOrdenRequisicion = Convert.ToInt32(dr["IdOrd_Requis"]);
                    or.FechaEmision = Convert.ToDateTime(dr["Fecha_Emis"]);
                    or.FechaInicio = Convert.ToDateTime(dr["Fecha_Inic"]);
                    or.FecheFin = Convert.ToDateTime(dr["Fecha_Fin"]);
                    or.Estado = Convert.ToBoolean(dr["Estado_Orden"]);

                    lista.Add(or);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

            return lista;
        }

        public void AnadirFechaInicioOrdenProduccion(int idOrdenProduccion)
        {
            using (SqlConnection cn = Conexion.Instancia.conectar())
            {
                cn.Open();

                using (SqlCommand command = new SqlCommand("AnadirFechaInicioOrdenProduccion", cn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdOrden_Pro", idOrdenProduccion);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AnadirFechaFinOrdenProduccion(int idOrdenProduccion)
        {
            using (SqlConnection cn = Conexion.Instancia.conectar())
            {
                cn.Open();

                using (SqlCommand command = new SqlCommand("AnadirFechaFinOrdenProduccion", cn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("IdOrden_Pro", idOrdenProduccion);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
