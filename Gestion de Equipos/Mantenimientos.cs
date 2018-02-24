using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Equipos
{
    public partial class Mantenimientos : Form
    {
        operacion oper = new operacion();

        public static bool modificar = false;

        public Mantenimientos()
        {
            InitializeComponent();
        }

        private void btnactualizarservicio_Click(object sender, EventArgs e)
        {
            oper.QuerySqlLibre("INSERT INTO equipos (nombre, estado, ubicacion, participante) VALUES ('" + txtnombreequipo.Text + "','" + txtestadoequipo.Text + "','" + txtubicacionequipo.Text + "','" + txtparticipanteequipo.Text + "');");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oper.QuerySqlLibre("INSERT INTO participantes (nombre, carrera, telefono, matricula) VALUES ('" + txtnombrepart.Text + "','" + txtcarrera.Text + "','" + txttelefonopar.Text + "','" + txtmatricula.Text + "');");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            oper.QuerySqlLibre("INSERT INTO empleados (nombre, ceduña, telefono, dirreccion) VALUES ('" + txtnombreemp.Text + "','" + txtcedulaemp.Text + "','" + txttelefonoemp.Text + "','" + txtdireccionemp.Text + "');");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Mantenimientos_Load(object sender, EventArgs e)
        {
            //Dar derehos al Administrador
            if (MenuPrincipal.TipoUsuario == "Administrador")
            {
                
            }
            else//Quitar derechos
            {
                tabControl1.Controls.Remove(tabPage3);
            }
        }
    }

}
