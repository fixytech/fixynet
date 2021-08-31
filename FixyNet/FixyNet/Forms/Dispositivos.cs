using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixyNet
{
    public partial class Dispositivos : Form
    {
        public Dispositivos()
        {
            InitializeComponent();
        }

        private void Dispositivos_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: esta línea de código carga datos en la tabla 'fixynetDataSet.dispositivos' Puede moverla o quitarla según sea necesario.
                this.dispositivosTableAdapter.Fill(this.fixynetDataSet.dispositivos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgDispositivos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ActualizarDatos()
        {
            try
            {
                dispositivosTableAdapter.Update(this.fixynetDataSet.dispositivos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgDispositivos_SelectionChanged(object sender, EventArgs e)
        {

            ActualizarDatos();
        }
    }
}
