using System;
using System.Data;
using System.Data.Sql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_de_Equipos
{
    public class operacion
    {
        public void AgregarEmpleado(string codigo, string nombre, string cedula, string telefono, string direccion)
        {
            SqlConnection con = new SqlConnection("Data Source="+Environment.MachineName+"\\SQLEXPRESS;Initial Catalog=gestion;Integrated Security=True");
            string strsql;
            strsql = "insert into clientes(nombre, cedula, telefono, direccion) values(@nombre, @cedula, @telefono, @direccion)";
            SqlCommand cmd = new SqlCommand(strsql, con);

            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@direccion", direccion);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string QuerySqlLibre(string sql)
        {

            SqlConnection cnx = new SqlConnection("Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=gestion;Integrated Security=True");

            try
            {
                cnx.Open();
                SqlCommand command = new SqlCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }

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

        public string FormatearFecha(DateTime fechaDT)
        {
            string fechaform;
            int mes = fechaDT.Month;
            int dia = fechaDT.Day;
            string Ddia = "";
            string Mmes = "";
            string Aaño = fechaDT.Year.ToString();

            //Comprobar que el més o el día sea mayor que 10 para si no agregarle el cero delante
            if (mes < 10) { Mmes = "0" + mes.ToString(); } else { Mmes = mes.ToString(); }
            if (dia < 10) { Ddia = "0" + dia.ToString(); } else { Ddia = dia.ToString(); }
            fechaform = Aaño + "-" + Mmes + "-" + Ddia;

            return fechaform; //Retornar al la llamada del método; la fecha formateada
        }

        public bool CajaDeMensaje(string cuerpo, string titulo)
        {
            bool aceptar = false;

            DialogResult Result = MessageBox.Show(cuerpo, titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (Result == DialogResult.OK)
            {
                aceptar = true;
            }

            return aceptar;
        }

        public string ObtenerHoraActual(string hora, string minutos)
        {
            //Formatear la Hora
            string hour;
            if (DateTime.Now.Hour > 12)
            {
                hour = (DateTime.Now.Hour - 12).ToString();
            }
            else { hour = DateTime.Now.Hour.ToString(); }

            //Formatear los minutos
            string minutes;
            if (DateTime.Now.Minute > 9)
            {
                minutes = DateTime.Now.Minute.ToString();
            }
            else { minutes = "0" + DateTime.Now.Minute.ToString(); }

            return (" " + hour + ":" + minutes);
        }

    }
}
