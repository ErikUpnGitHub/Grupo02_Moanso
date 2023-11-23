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
    public class datOrdenRequisicion
    {
        private static readonly datOrdenRequisicion instancia = new datOrdenRequisicion();
        public static datOrdenRequisicion Instancia
        {
            get { return datOrdenRequisicion.instancia; }
        }

        public List<entOrdenRequisicion> ListarOrden()
        {
            SqlCommand cmd = null;
            List<entOrdenRequisicion> lista = new List<entOrdenRequisicion>();

            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("ListarOrdenRequisicion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entOrdenRequisicion or = new entOrdenRequisicion();

                    or.IdOrdenRequisicion = Convert.ToInt32(dr["IdOrd_Requis"]);
                    or.FechaEmision = Convert.ToDateTime(dr["Fecha_Emision"]);

                    try
                    { or.FechaFin = Convert.ToDateTime(dr["Fecha_Fin"]); }
                    catch (Exception)
                    { or.FechaFin = null; }

                    or.Estado = Convert.ToBoolean(dr["Estado"]);

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

        public Boolean InsertarOrdenRequisicion()
        {
            SqlCommand cmd = null;
            Boolean inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("InsertarOrdenRequisicion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

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

        public Boolean EditarOrden(entOrdenRequisicion orden)
        {

            SqlCommand cmd = null;
            Boolean Edito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("EditarOrdenRequisicion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdOrd_Requis", orden.IdOrdenRequisicion);
                cmd.Parameters.AddWithValue("@Fecha_Emision", orden.FechaEmision);
                cmd.Parameters.AddWithValue("@Fecha_Fin", orden.FechaFin);
                cmd.Parameters.AddWithValue("@Estado", orden.Estado);

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

        public List<entOrdenRequisicion> BuscarOrdenId(int id)
        {
            SqlCommand cmd = null;

            List<entOrdenRequisicion> lista = new List<entOrdenRequisicion>();

            entOrdenRequisicion orden = new entOrdenRequisicion();

            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("BuscarOrdenRequisicion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOrd_Requis", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    orden.IdOrdenRequisicion = Convert.ToInt32(dr["IdOrd_Requis"]);
                    orden.FechaEmision = Convert.ToDateTime(dr["Fecha_Emision"]);

                    try
                    { orden.FechaFin = Convert.ToDateTime(dr["Fecha_Fin"]); }
                    catch (Exception)
                    { orden.FechaFin = null; }

                    orden.Estado = Convert.ToBoolean(dr["Estado"]);

                    lista.Add(orden);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

            return lista;
        }

        public List<entOrdenRequisicion> ComboBoxRequisicion()
        {
            SqlCommand cmd = null;
            List<entOrdenRequisicion> lista = new List<entOrdenRequisicion>();

            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("ComboBoxRequisicion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entOrdenRequisicion or = new entOrdenRequisicion();

                    or.IdOrdenRequisicion = Convert.ToInt32(dr["IdOrd_Requis"]);
                    or.FechaEmision = Convert.ToDateTime(dr["Fecha_Emision"]);
                    or.FechaFin = Convert.ToDateTime(dr["Fecha_Fin"]);
                    or.Estado = Convert.ToBoolean(dr["Estado"]);

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

        public void CambiarEstadoOrdenRequisicion(int idOrdenRequisicion)
        {
            using (SqlConnection cn = Conexion.Instancia.conectar())
            {
                cn.Open();

                using (SqlCommand command = new SqlCommand("CambiarEstadoOrdenRequisicion", cn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdOrd_Requis", idOrdenRequisicion);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
