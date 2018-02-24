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
        operacion oper = new operacion();
        public reservar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Consultar();
            Consultar.Seleccionando = true;
            Consultar.SeleccionandoIndex = 2;
            f.ShowDialog();
            if (MenuPrincipal.idseleccionar != "0")
            {
                //Cargar nombre e id
                DataSet ds = oper.DataSetConsulta("SELECT nombre FROM equipos WHERE id = '" + MenuPrincipal.idseleccionar + "'");
                txtequipo.Text = ds.Tables[0].Rows[0][0].ToString();
                txtidequipo.Text = MenuPrincipal.idseleccionar;
            }
            else
            {
                //No hacer nada
            }
        }

        private void btnreservar_Click(object sender, EventArgs e)
        {
            if (txtparticipantematricula.Text != "" && txtidequipo.Text != "0" && txtequipo.Text != "" && txtaula.Text != "")
                if (dtfechatarget.Value > DateTime.Now) //Validar que la fecha sea Mayor a ayer...
                {
                    {
                        string idparticipante = "";
                        DataSet ds = oper.DataSetConsulta("SELECT id FROM participantes WHERE matricula = '" + txtparticipantematricula.Text + "';");
                        try
                        {
                            idparticipante = ds.Tables[0].Rows[0][0].ToString();
                        }
                        catch
                        {
                            MessageBox.Show("Esta matrícula no existe, ingrese una matrícula correcta...", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtparticipantematricula.Focus();
                            txtparticipantematricula.SelectAll();
                            return;
                        }

                        DateTime targetdate = dtfechatarget.Value;
                        string fechatarget = oper.FormatearFecha(targetdate);
                        fechatarget += " " + dtfechatarget.Value.Hour.ToString() + ":" + dtfechatarget.Value.Minute.ToString() + ":" + dtfechatarget.Value.Second.ToString();

                        //Insertar la Reserva en procesos
                        oper.QuerySqlLibre("INSERT INTO procesos (idequipo, estado, idparticipante, idempleado, aula, fecha) " +
                            "VALUES('" + txtidequipo.Text + "', 'RESERVADO', '" + idparticipante + "', '" + MenuPrincipal.idempleado + "',  '" + txtaula.Text + "', '" + fechatarget + "');");

                        //Actualizar el estado del equipo seleccionado
                        oper.QuerySqlLibre("UPDATE equipos SET estado = 'RESERVADO', participante = '" + txtparticipantematricula.Text + "' WHERE id = '" + txtidequipo.Text + "';");
                        MessageBox.Show("El equipo fue reservado satisfactoriamente...", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NuevaReserva();
                    }
                }
                else
                {
                    MessageBox.Show("Elija una fecha válida...", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtfechatarget.Focus();
                }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos...", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void NuevaReserva()
        {
            txtparticipantematricula.Clear();
            txtidequipo.Text = "0";
            txtequipo.Text = "Seleccionar";
            dtfechatarget.Value = DateTime.Now;
            dtfechatarget.Text = "08:00:00";
            txtaula.Clear();
            MenuPrincipal.idseleccionar = "0";
        }

        private void reservar_Load(object sender, EventArgs e)
        {
            dtfechatarget.Value = DateTime.Now;
            dtfechatarget.Text = "08:00:00";
        }

        private void btnselectpart_Click(object sender, EventArgs e)
        {
            Form f = new Consultar();
            Consultar.Seleccionando = true;
            Consultar.SeleccionandoIndex = 0;
            f.ShowDialog();
            if (MenuPrincipal.idseleccionar != "0")
            {
                //Cargar nombre e id
                DataSet ds = oper.DataSetConsulta("SELECT matricula FROM participantes WHERE id = '" + MenuPrincipal.idseleccionar + "'");
                txtparticipantematricula.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                //No hacer nada
            }
        }
    }
}
