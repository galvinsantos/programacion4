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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();

        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            cbtipobusqueda.SelectedIndex = 1;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cbtipobusqueda.Text == "Participante")
            {
                Form f = new Mantenimiento_de_Participantes();
                f.ShowDialog();
            }
            else
            {
                if (cbtipobusqueda.Text == "Equipos")
                {
                    Form f = new Mantenimiento_de_Equipos();
                    f.ShowDialog();
                }
                else
                {
                    Form f = new Mantenimiento_Empleado();
                    f.ShowDialog();
                }
            }

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
            MostrarTodo();
        }

        public void MostrarTodo()
        {

        }

        private void dgvequipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbtipobusqueda.Text == "Participante")
            {
                Form f = new Mantenimiento_de_Participantes();
                Mantenimiento_de_Participantes.modificar = true;
                f.ShowDialog();
            }
            else
            {
                if (cbtipobusqueda.Text == "Equipos")
                {
                    Form f = new Mantenimiento_de_Equipos();
                    Mantenimiento_de_Equipos.modificar = true;
                    f.ShowDialog();
                }
                else
                {
                    Form f = new Mantenimiento_Empleado();
                    Mantenimiento_Empleado.modificar = true;
                    f.ShowDialog();
                }
            }
        }
    }
}
