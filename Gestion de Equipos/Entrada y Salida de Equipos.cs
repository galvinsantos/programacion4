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
            cbtipobusqueda.SelectedValue = 1;
        }
    }
}
