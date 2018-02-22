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
    }
}
