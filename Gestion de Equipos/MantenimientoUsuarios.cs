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
    public partial class MantenimientoUsuarios : Form
    {
        operacion oper = new operacion();

        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            DataSet ds = oper.DataSetConsulta("SELECT * FROM login;");

            dgvequipos.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvequipos.Rows.Add();
                for (int k = 0; k < 4; k++)
                {
                    if(k == 1)
                    {
                        dgvequipos.Rows[i].Cells[k].Value = "*******";
                    }
                    else
                    {
                        dgvequipos.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                    }
                }

            }

        }
        }
    }
}
