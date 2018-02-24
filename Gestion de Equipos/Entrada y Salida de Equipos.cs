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
        operacion oper = new operacion();
        public Entrada_y_Salida_de_Equipos()
        {
            InitializeComponent();

        }

        private void Entrada_y_Salida_de_Equipos_Load(object sender, EventArgs e)
        {
            cbtipobusqueda.SelectedIndex = 1;
            MostrarTodos();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Form f = new Mantenimiento_de_Equipos();
            f.ShowDialog();
        }

        private void btnentrada_Click(object sender, EventArgs e)
        {
            DarEntrada();
        }

        public void DarEntrada()
        {

        }

        public void DarSalida()
        {

        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            DarSalida();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            string criterio = "";
            //Criterio
            if (cbtipobusqueda.SelectedIndex == 0)
            {
                criterio = "procesos.id";
            }
            else
            {
                if (cbtipobusqueda.SelectedIndex == 1)
                {
                    criterio = "equipos.nombre";
                }
                else
                {
                    if (cbtipobusqueda.SelectedIndex == 2)
                    {
                        criterio = "procesos.estado";
                    }
                    else
                    {
                        if (cbtipobusqueda.SelectedIndex == 3)
                        {
                            criterio = "participantes.nombre";
                        }
                        else
                        {
                            criterio = "empleados.nombre";
                        }
                    }
                }
            }

            DataSet ds = oper.DataSetConsulta("SELECT procesos.id, equipos.nombre, procesos.estado, " +
                "participantes.nombre, empleados.nombre, procesos.aula, procesos.fecha FROM procesos " +
                "INNER JOIN equipos ON procesos.idequipo = equipos.id " +
                "INNER JOIN participantes ON procesos.idparticipante = participantes.id " +
                "INNER JOIN empleados ON procesos.idempleado = empleados.id " +
                "WHERE "+ criterio +" LIKE '%" + tbbuscar.Text + "%';;");
            dgvequipos.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvequipos.Rows.Add();
                for (int k = 0; k < 6; k++)
                {
                    dgvequipos.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                }

            }
            
        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        public void MostrarTodos()
        {
            DataSet ds = oper.DataSetConsulta("SELECT procesos.id, equipos.nombre, procesos.estado, participantes.nombre, empleados.nombre,procesos.aula, procesos.fecha FROM procesos INNER JOIN equipos ON procesos.idequipo = equipos.id INNER JOIN participantes ON procesos.idparticipante = participantes.id INNER JOIN empleados ON procesos.idempleado = empleados.id;"); 
            dgvequipos.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvequipos.Rows.Add();
                for (int k = 0; k < 7; k++)
                {
                    dgvequipos.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                }

            }
        }

        private void dgvequipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form f = new EntradaSalida();
            f.ShowDialog();
            if(MenuPrincipal.DarSalidaDarEntrada != 0)
            {
                ProcesarEquipo(MenuPrincipal.DarSalidaDarEntrada);
            }
            else { }
        }

        public void ProcesarEquipo(int Tipo)
        {
            //Procesar dependiendo el caso
            if (Tipo == 1) //Dar Entrada cambiar a DISPONIBLE
            {

            }
            else
            {
                if (Tipo == 2) //Dar Salida Entregar al Participante
                {

                }
                else //Por defecto Reservar, abrir formulario de reserva
                {
                    Form f = new reservar();
                    f.ShowDialog();
                }
            }
        }

        private void tbbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                e.Handled = true;
            }        
        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar();
        }
    }
}
