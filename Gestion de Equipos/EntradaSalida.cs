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
    public partial class EntradaSalida : Form
    {
        public EntradaSalida()
        {
            InitializeComponent();
        }

        private void btnentrada_Click(object sender, EventArgs e)
        {
            MenuPrincipal.DarSalidaDarEntrada = 1;
            this.Close();
        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            MenuPrincipal.DarSalidaDarEntrada = 2;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal.DarSalidaDarEntrada = 3;
            this.Close();
        }

        private void EntradaSalida_Load(object sender, EventArgs e)
        {
            MenuPrincipal.DarSalidaDarEntrada = 0;
        }
    }
}
