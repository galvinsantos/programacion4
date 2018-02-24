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
            CrearModificar();
        }

        private void dgvequipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idmodificar = dgvequipos.CurrentRow.Cells[0].Value.ToString();
            Modificar();
        }

        public void Modificar()
        {
            modificar = true;
            btnagregar.Text = "MODIFICAR";
            DataSet ds = oper.DataSetConsulta("SELECT * FROM login WHERE usuario = '"+ idmodificar +"';");
            txtempleado.Text = CargarEmpleado(MenuPrincipal.idseleccionar);
            txtidempleado.Text = ds.Tables[0].Rows[0][2].ToString();
            txtusuario.Text = ds.Tables[0].Rows[0][0].ToString();
            txtcontraseña.Text = "*******";
            cbtipousuario.Text = ds.Tables[0].Rows[0][3].ToString();
        }

        public string CargarEmpleado(string idempleado)
        {
            //Cargar nombre del empleado desde el id
            DataSet ds = oper.DataSetConsulta("SELECT nombre FROM empleados WHERE id = '" + idempleado + "'");
            return ds.Tables[0].Rows[0][0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoUsuario();
            txtusuario.Focus();
        }

        public void NuevoUsuario()
        {
            modificar = false;
            txtcontraseña.Clear();
            txtempleado.Text = "Seleccione";
            txtidempleado.Text = "0";
            txtusuario.Clear();
            cbtipousuario.SelectedIndex = 0;
            btnagregar.Text = "CREAR";
        }

        public bool ValidarCampos()
        {
            if(txtidempleado.Text != "0")
            {
                if (txtusuario.TextLength < 6 || txtcontraseña.TextLength < 6)
                {
                    MessageBox.Show("El usuario y la contraseña deben ser de por lo menos seis (6) carácteres...", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusuario.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos...", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public void CrearModificar()
        {
            //Crear o modificar el usuario segun sea el caso
            bool CamposCompletados = ValidarCampos();
            if (CamposCompletados)
            {
                if (modificar)
                {
                    oper.QuerySqlLibre("UPDATE login SET usuario = '"+txtusuario.Text+ "', contrasena = '" + txtcontraseña.Text + "', idempleado = '" + txtidempleado.Text + "', tipousuario = '" + cbtipousuario.Text + "' WHERE usuario = '" + idmodificar + "';");
                }
                else {
                    oper.QuerySqlLibre("INSERT INTO login VALUES ('" + txtusuario.Text + "','" + txtcontraseña.Text + "','" + txtidempleado.Text + "','" + cbtipousuario.Text + "',);");
                }
            }
            else { }
        }


    }
}
