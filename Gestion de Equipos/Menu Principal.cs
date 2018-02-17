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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form f = new Login();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Consultar();
            f.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Entrada_y_Salida_de_Equipos();
            f.ShowDialog();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Mantenimiento_de_Equipos();
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
            MessageBox.Show("Monstrando Formulario de Mantenimiento de Usuarios...");
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
            Form f = new Login();
            f.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
