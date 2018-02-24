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
                "WHERE " + criterio + " LIKE '%" + tbbuscar.Text + "%';;");

            dgvequipos.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvequipos.Rows.Add();
                for (int k = 0; k < 7; k++)
                {
                    dgvequipos.Rows[i].Cells[k].Value = ds.Tables[0].Rows[i][k].ToString();
                }
            }
            dgvequipos.Refresh();

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
            if (MenuPrincipal.DarSalidaDarEntrada != 0 && dgvequipos.SelectedRows.Count == 1)
            {
                ProcesarEquipo(MenuPrincipal.DarSalidaDarEntrada);
            }
            else { }
        }

        public void ProcesarEquipo(int Tipo)
        {
            //Procesar dependiendo el caso
            string idproceso = dgvequipos.CurrentRow.Cells[0].Value.ToString();
            string estado = dgvequipos.CurrentRow.Cells[2].Value.ToString();
            string nombreequipo = dgvequipos.CurrentRow.Cells[1].Value.ToString();
            DataSet ds = oper.DataSetConsulta("SELECT idequipo, aula, idparticipante FROM procesos WHERE id = '" + idproceso + "';");

            string idequipo = ds.Tables[0].Rows[0][0].ToString();
            string aula = ds.Tables[0].Rows[0][1].ToString();
            string idparticipante = ds.Tables[0].Rows[0][2].ToString();

            if (estado == "FINALIZADO" && Tipo != 3)
            {
                MessageBox.Show("Este proceso ya fue finalizado...", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Continue
            }

            if (Tipo == 1) //Dar Entrada cambiar a DISPONIBLE
            {
                bool DarEntrada = oper.CajaDeMensaje("Le va a dar entrada al equipo: " + nombreequipo, "Dar Entrada");
                if (DarEntrada)
                {
                    oper.QuerySqlLibre("UPDATE procesos SET estado = 'FINALIZADO' WHERE id = '" + idproceso + "';");
                    oper.QuerySqlLibre("UPDATE equipos SET estado = 'DISPONIBLE', ubicacion = 'ALMACEN', participante = '' WHERE id = '" + idequipo + "';");
                }
                else { }
            }
            else
            {
                if (Tipo == 2) //Dar Salida Entregar al Participante
                {

                    ds = oper.DataSetConsulta("SELECT matricula FROM participantes WHERE id = '" + idparticipante + "';");
                    string matriculaparticipante = ds.Tables[0].Rows[0][0].ToString();
                    bool DarSalida = oper.CajaDeMensaje("Le va a dar Salida al equipo: " + nombreequipo, "Dar Entrada");
                    if (DarSalida)
                    {
                        oper.QuerySqlLibre("UPDATE procesos SET estado = 'ENTREGADO' WHERE id = '" + idproceso + "';");
                        oper.QuerySqlLibre("UPDATE equipos SET estado = 'ENTREGADO', ubicacion = '" + aula + "', participante = '" + matriculaparticipante + "' WHERE id = '" + idequipo + "';");
                    }
                    else { }
                }
                else //Por defecto Reservar, abrir formulario de reserva
                {
                    Form f = new reservar();
                    f.ShowDialog();
                }
            }
            Buscar();
        }

        private void tbbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
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
