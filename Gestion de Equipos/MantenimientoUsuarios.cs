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
        public bool modificar = false;
        public string idmodificar = "";

        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            MostrarTodos();
            cbtipousuario.SelectedIndex = 0;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            bool eliminarusuario = oper.CajaDeMensaje("¿Seguro que de sea eliminar este usuario?","Eliminar");
            if (eliminarusuario)
            {
                if (dgvequipos.SelectedRows.Count == 1)
                {
                    oper.QuerySqlLibre("DELETE FROM login WHERE usuario = '" + dgvequipos.CurrentRow.Cells[0].Value.ToString() + "';");
                    MostrarTodos();
                }
            }
            else { }
        }

        public void MostrarTodos()
        {
            DataSet ds = oper.DataSetConsulta("SELECT * FROM login;");

            dgvequipos.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvequipos.Rows.Add();
                for (int k = 0; k < 4; k++)
                {
                    if (k == 1)
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool eliminarusuario = oper.CajaDeMensaje("¿Seguro que de sea resetear este usuario?", "Resetear");
            if (eliminarusuario)
            {
                if (dgvequipos.SelectedRows.Count == 1)
                {
                    oper.QuerySqlLibre("UPDATE login SET contrasena = '1234' WHERE usuario = '" + dgvequipos.CurrentRow.Cells[0].Value.ToString() + "';");
                    MostrarTodos();
                }
            }
            else { }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void dgvequipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idmodificar = dgvequipos.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoUsuario();
        }

        public void NuevoUsuario()
        {
            modificar = false;
            txtcontraseña.Clear();
            txtempleado.Text = "Seleccione";

        }

    }
}
