using System;
using System.Data;
using System.Data.Sql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gestion_de_Equipos
{
    public class operacion
    {
        public void AgregarEmpleado(string codigo, string nombre, string cedula, string telefono, string direccion)
        {
            SqlConnection con = new SqlConnection("Data Source="+Environment.MachineName+"\\SQLEXPRESS;Initial Catalog=gestion;Integrated Security=True");
            string strsql;
            strsql = "insert into clientes(codigo, nombre, cedula, telefono, direccion) values(@codigo, @nombre, @cedula, @telefono, @direccion)";
            SqlCommand cmd = new SqlCommand(strsql, con);

            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@direccion", direccion);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable ConsultaConResultado(string sql)
        {
            SqlConnection con = new SqlConnection("Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=gestion;Integrated Security=True");

            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        public DataSet DataSetConsulta(string sql)
        {
            SqlConnection con = new SqlConnection("Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=gestion;Integrated Security=True");

            try
            {
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
