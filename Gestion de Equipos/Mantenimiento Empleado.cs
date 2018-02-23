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
            operacion oper = new operacion();
            oper.AgregarEmpleado(txtcodigo.Text, txtnombre.Text, txtcedula.Text, txttelefono.Text, txtdireccion.Text);
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
