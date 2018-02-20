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
        SqlConnection cnx = new SqlConnection(@"Data Source = base de datos");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Data Source = base de datos");
            try
            {
                //Filtra de la base de datos los usuarios y contracenas existentes. depende como estan los campos de la base de datos. 
                String query = "select count(*) from login where usuario = '" + txtusuario.Text + "' and clave = '" + txtcontrasena.Text + "';";

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
                    //Oculta la tabla de login y abre la interfas pricipal
                    this.Hide();
                    Form main = new Form2();
                    main.Show();
                }
                else
                {
                    //mensaje de error si el usuario o contracena es incorrecto
                    MessageBox.Show("USUARIO O CONTRACEÑA INCORRECTO");
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
    }
}
