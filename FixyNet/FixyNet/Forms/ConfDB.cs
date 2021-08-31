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
    public partial class ConfDB : Form
    {


        public ConfDB()
        {
            InitializeComponent();
        }

        private void ConfDB_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnTestConexion_Click(object sender, EventArgs e)
        {
            

            if(cbWindows.Checked == true && tbServer.Text.Length > 0)
            {

                ConexionDb.testConexionWindows(tbServer.Text + "\\" + tbInstancia.Text, tbDb.Text);
            }
            else
            {
                if(cbWindows.Checked == true && tbServer.Text.Length <= 0)
                {
                    MessageBox.Show("Complete el nombre del servidor");
                    tbServer.Focus();
                }
                if (cbWindows.Checked== false && tbUsuario.Text.Length == 0 || tbPassword.Text.Length == 0 || tbServer.Text.Length == 0)
                {
                    MessageBox.Show("Complete los datos de CREDENCIALES y CONEXION");
                }
                else
                {
                    ConexionDb.testConexionBasic(tbServer.Text + "\\" + tbInstancia.Text, tbDb.Text, tbUsuario.Text, tbPassword.Text);
                }
            }
          

            
        }

        private void ConfDB_Load(object sender, EventArgs e)
        {
            tbServer.Text = System.Environment.MachineName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (cbWindows.Checked)
            {
                tbUsuario.Enabled = false;
                tbPassword.Enabled = false;
            }
            else
            {
                tbUsuario.Enabled = true;
                tbPassword.Enabled = true;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
