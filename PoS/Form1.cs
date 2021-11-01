using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PoS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Location = new Point(nombreTienda.Location.X - label1.Width / 2, nombreTienda.Location.Y + nombreTienda.Height + 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=verificador_de_precios; SSL mode=none");
                mySqlConnection.Open();
                String query = "SELECT * FROM usuarios WHERE numero_de_empleado = " + usuariotxb.Text + " and pass = " + pswtxb.Text;
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    if (mySqlDataReader.Read())
                {
                    String nombre = mySqlDataReader.GetString(1);
                    //MessageBox.Show("Conexión exitosa");
                    PuntoDeVenta principal = new PuntoDeVenta();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrecto.");
                }
                mySqlConnection.Close();
                usuariotxb.Text = "";
                pswtxb.Text = "";
            }
            catch (Exception ERROR)
            {
                MessageBox.Show("Algo salió mal " + ERROR.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }


    }
}
