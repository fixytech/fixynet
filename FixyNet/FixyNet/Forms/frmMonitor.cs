using FixyNet.Clases;
using FixyNet.fixynetDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixyNet.Forms
{
    public partial class FrmMonitor : Form
    {
        private readonly MonitorClass monitor = new MonitorClass();
        public FrmMonitor()
        {
            InitializeComponent();
        }
        private void FrmMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Detener();
        }
        private void FrmMonitor_Load(object sender, EventArgs ev)
        {

            btnDetener.Enabled = false;
            monitor.CerrarClass += (s, e) =>
            {

                Detener();

            };

        }
        private void Pooleo()
        {

        }
        public void CargarDatos()
        {
            try
            {
                eventosTableAdapter adapter = new eventosTableAdapter();
                fixynetDataSet.eventosDataTable table = adapter.GetErrorDispEvent();
                dgEvents.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void TiempoRecargaDatos_Tick(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void TiempoPool_Tick(object sender, EventArgs e)
        {
            Pooleo();
        }
        private async void BtnIiciar_Click(object sender, EventArgs e)
        {
            tiempoRecargaDatos.Interval = Int32.Parse(numEventos.Value.ToString());
            tiempoRecargaDatos.Start();

            monitor.tiempoPooleo = Int32.Parse(numPool.Value.ToString());


            btnIiciar.Enabled = false;
            btnDetener.Enabled = true;

            try
            {
                await monitor.Monitoreo();
            }
            catch
            {

            }

        }
        private void BtnDetener_Click(object sender, EventArgs e)
        {
            Detener();
        }
        private void BtnGrafico_Click(object sender, EventArgs e)
        {

        }
        public void Detener()
        {
            tiempoRecargaDatos.Stop();
            monitor.Reloj.Stop();

            btnIiciar.Enabled = true;
            btnDetener.Enabled = false;
        }
    }
}
