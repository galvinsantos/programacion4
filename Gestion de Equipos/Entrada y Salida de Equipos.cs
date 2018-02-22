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
    public partial class Entrada_y_Salida_de_Equipos : Form
    {
        public Entrada_y_Salida_de_Equipos()
        {
            InitializeComponent();

        }

        private void Entrada_y_Salida_de_Equipos_Load(object sender, EventArgs e)
        {
            cbtipobusqueda.SelectedIndex = 1;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Form f = new Mantenimiento_de_Equipos();
            f.ShowDialog();
        }

        private void btnentrada_Click(object sender, EventArgs e)
        {
            DarEntrada();
        }

        public void DarEntrada()
        {

        }

        public void DarSalida()
        {

        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            DarSalida();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {

        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        public void MostrarTodos()
        {

        }

        private void dgvequipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form f = new EntradaSalida();
            f.ShowDialog();
        }
    }
}
