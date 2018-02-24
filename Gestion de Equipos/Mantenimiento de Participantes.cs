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
    public partial class Mantenimiento_de_Participantes : Form
    {
        operacion oper = new operacion();

        public static bool modificar = false;

        public Mantenimiento_de_Participantes()
        {
            InitializeComponent();
        }

        private void Mantenimiento_de_Participantes_Load(object sender, EventArgs e)
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

        private void btnactualizarservicio_Click(object sender, EventArgs e)
        {
            oper.QuerySqlLibre("INSERT INTO participantes (nombre, carrera, telefono, matricula) VALUES ('" + tbpnombre.Text + "','" + tbcarrera.Text + "','" + tbtelefono.Text + "','" + tbmatricula.Text + "');");
        }
    }
}
