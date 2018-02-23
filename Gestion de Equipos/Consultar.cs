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
        //Total 730px
        operacion oper = new operacion();

        public Consultar()
        {
            InitializeComponent();

        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            cbtipobusqueda.SelectedIndex = 1;
            MostrarTodo();
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

            DataSet ds = oper.DataSetConsulta("SELECT * FROM clientes;");

            dgvequipos.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvequipos.Rows.Add();
                for (int k = 0; k < 4; k++)
                {
                    dgvequipos.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                }
                
            }

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

        private void cbtipobusqueda_TextChanged(object sender, EventArgs e)
        {
            EstablecerCriterios();
        }

        public void EstablecerCriterios()
        {
            string nombretabla = "";

            //ESTABLECER CRITERIOS PARA PARTICIPANTES
            if(cbtipobusqueda.SelectedIndex == 1)
            {
                nombretabla = "participantes";
                dgvequipos.Columns[1].HeaderText = "Nombre";
                dgvequipos.Columns[2].HeaderText = "Carrera";
                dgvequipos.Columns[3].HeaderText = "Teléfono";
                dgvequipos.Columns[4].HeaderText = "Direción";

            }
            else
            {
                //ESTABLECER CRITERIOS PARA EMPLEADOS
                if (cbtipobusqueda.SelectedIndex == 1)
                {
                    nombretabla = "empleados";
                    dgvequipos.Columns[1].HeaderText = "Nombre";
                    dgvequipos.Columns[2].HeaderText = "Cédula";
                    dgvequipos.Columns[3].HeaderText = "Teléfono";
                    dgvequipos.Columns[4].HeaderText = "Direción";
                }
                else
                {
                    //ESTABLECER CRITERIOS PARA EQUIPOS
                    nombretabla = "equipos";
                    dgvequipos.Columns[1].HeaderText = "Nombre";
                    dgvequipos.Columns[2].HeaderText = "Estado";
                    dgvequipos.Columns[3].HeaderText = "Ubicación";
                    dgvequipos.Columns[4].HeaderText = "Participante";
                }
            }



        }
    }
}
