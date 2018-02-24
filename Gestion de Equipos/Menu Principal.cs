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
    public partial class MenuPrincipal : Form
    {
        operacion oper = new operacion();
        public static string usuarioempleado = "CERRADO";
        public static string idempleado = "1";
        public static string TipoUsuario = "";
        public static string codigomantenimiento = "";
        public static string idseleccionar = "0";

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Consultar();
            f.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //IniciarSesion();
        }

        public void IniciarSesion()
        {


            Form f = new Login();
            usuarioempleado = "CERRADO";
            TipoUsuario = "";
            f.ShowDialog();

            if (usuarioempleado == "CERRADO") //Validar que se halla iniciado sesion...
            {
                this.Close();
            }
            else
            {
                //Continuar
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Entrada_y_Salida_de_Equipos();
            f.ShowDialog();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Mantenimientos();
            f.ShowDialog();
        }

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Mantenimiento_de_Participantes();
            f.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Mantenimiento_Empleado();
            f.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new MantenimientoUsuarios();
            f.ShowDialog();
        }

        private void entradaYSalidaDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Entrada_y_Salida_de_Equipos();
            f.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Consultar();
            f.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarSesion()
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool SalirDelSistema = oper.CajaDeMensaje("Salir del Sistema","Salir");
            if (SalirDelSistema)
            {
                this.Close();
            }
            else
            {
                //Quedarse en el sistema
            }
        }

        private void btnmantenimientos_Click(object sender, EventArgs e)
        {
            Form f = new Mantenimientos();
            f.ShowDialog();
        }

        private void btnreservar_Click(object sender, EventArgs e)
        {
            Form f = new reservar();
            f.ShowDialog();
        }
    }
}
