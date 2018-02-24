using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;    //tener que eliminar para poder usar Npgsql o otro.

 namespace Gestion_de_Equipos
{
    public partial class Login : Form
    {
        operacion oper = new operacion();
        public bool preguntarsalir = true;
        public bool IniciandoSesion = true;

        public Login()
        {
            InitializeComponent();
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.MaxLength = 10;
        }
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider mds = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = mds.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        SqlConnection cnx = new SqlConnection(@"Data Source = " + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=gestion;Integrated Security=True");
        



        private void button1_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        public void LogIn()
        {
            SqlConnection cnx = new SqlConnection("Data Source = " + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=gestion;Integrated Security=True");
            try
            {
                //Filtra de la base de datos los usuarios y contracenas existentes. depende como estan los campos de la base de datos. 
                String query = "select count(*) from login where usuario = '" + txtusuario.Text + "' and contrasena = '" + txtcontrasena.Text + "';";

                SqlDataAdapter ad;
                DataTable dt = new DataTable();


                cnx.Open();
                SqlCommand cmd;
                cmd = cnx.CreateCommand();
                cmd.CommandText = query;
                ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    DataSet ds = oper.DataSetConsulta("SELECT idempleado, tipousuario FROM login WHERE usuario = '" + txtusuario.Text + "';");

                    //Establecer el empleado
                    MenuPrincipal.usuarioempleado = txtusuario.Text;
                    MenuPrincipal.idempleado = ds.Tables[0].Rows[0][0].ToString();
                    MenuPrincipal.TipoUsuario = ds.Tables[0].Rows[0][1].ToString();

                    //Se cierra el Login y se habilita el menú principal
                    this.Close();
                }
                else
                {
                    //mensaje de error si el usuario o contracena es incorrecto
                    MessageBox.Show("Usuario o ontraseña Incorrectos","Inicio de Sesión", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MenuPrincipal.usuarioempleado == "CERRADO")
            {
                if (preguntarsalir)
                {
                    preguntarsalir = false;
                    bool SalirDelSistema = oper.CajaDeMensaje("Salir del Sistema", "Salir");
                    if (SalirDelSistema)
                    {
                        this.Close();
                    }
                    else
                    {
                        //Quedarse en el sistema
                        e.Cancel = true;
                        preguntarsalir = true;
                    }
                }
                else { }
            }
            {
                //Continue With the login
            }
        }

        private void txtcontrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IniciandoSesion)
            {
                IniciandoSesion = false;
                if (e.KeyChar == 13)
                {
                    LogIn();
                }
                else { }
                IniciandoSesion = true;
            }
            else { }
        }
    }
}
