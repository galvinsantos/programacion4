using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_de_Equipos
{
    public partial class Mantenimiento_Empleado : Form
    {
        public static bool modificar = false;

        public Mantenimiento_Empleado()
        {
            InitializeComponent();
        }

        private void btnactualizarservicio_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KI5B4T\\SQLEXPRESS;Initial Catalog=gestion;Integrated Security=True");
            string strsql;
            strsql = "insert into clientes(txtcodigo, txtnombre, txtcedula, txttelefono, txtdireccion) values(@codigo, @nombre, @cedula, @telefono, @direccion)";
            SqlCommand cmd = new SqlCommand(strsql, con);

            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text);
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd.Parameters.AddWithValue("@cedula", txtcedula.Text);
            cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Mantenimiento_Empleado_Load(object sender, EventArgs e)
        {

            if (modificar)
            {
                Cargar();
            }
            else { }
        }

        public void Cargar()
        {

        }
    }
}
