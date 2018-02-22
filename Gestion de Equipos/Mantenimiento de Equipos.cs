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
    public partial class Mantenimiento_de_Equipos : Form
    {
        public static bool modificar = false;

        public Mantenimiento_de_Equipos()
        {
            InitializeComponent();
        }

        private void Mantenimiento_de_Equipos_Load(object sender, EventArgs e)
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
    }
}
