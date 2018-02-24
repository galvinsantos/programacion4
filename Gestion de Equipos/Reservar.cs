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
    public partial class reservar : Form
    {
        public reservar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Consultar();
            Consultar.Seleccionando = true;
            f.ShowDialog();
            if(MenuPrincipal.idseleccionar != "0")
            {
                //Cargar nombre e id
            }
            else
            {
                //No hacer nada
            }
        }
    }
}
