using FixyNet.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace FixyNet
{
    public partial class frmAddDispMan : Form
    {
        Form descubrir = new Descubrir();

        public frmAddDispMan()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DispositivosClass dispositivos = new DispositivosClass();

            try
            {

                dispositivos.ip = System.Net.IPAddress.Parse(tbInicio.Text);
                dispositivos.ipFin = System.Net.IPAddress.Parse(tbFin.Text);

                MessageBox.Show(await dispositivos.AgregarDispositivos());
                descubrir.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Rango invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBox1_Validated(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }

        private void frmAddDispMan_Load(object sender, EventArgs e)
        {

        }
    }
}
