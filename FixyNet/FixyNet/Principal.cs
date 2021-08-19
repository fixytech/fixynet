using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixyNet
{
    public partial class Principal : Form
    {
       
        

        public Principal()
        {
            InitializeComponent();
       
        }

        private void conexionDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormConfDB = new ConfDB(); // Formulario de configuracion de base de datos.
            FormConfDB.Show(); // Muestro form de configuracion
        }

        private void configurarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando a base de datos...";
            SqlConnection cn = ConexionDb.Conectar();

            try
            {
                // Conecto con base de datos
                cn.Open();
                toolStripStatusLabel1.Text = "Conectado";
                toolStripStatusLabel1.BackColor = Color.Green;

                string sql = "select * from clientes";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);

                
                dgClientes.DataSource = dt;
                

                cn.Close();


            }
            catch(Exception ex)
            {
                cn.Close();
                groupBox1.Enabled = false;
                // Informo error
                MessageBox.Show("No se pudo conectar a la base de datos. Revise la configuracion. " + ex);
                toolStripStatusLabel1.Text = "Error de conexion...";
                toolStripStatusLabel1.BackColor = Color.Red;
               
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addCliente = new ClienteAdd();
            addCliente.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form dispositivos = new Dispositivos();

            dispositivos.Show();
        }

        private void descubrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form herramientaDescubrir = new Descubrir();

            herramientaDescubrir.Show();
        }
    }
}
