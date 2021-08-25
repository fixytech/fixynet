using FixyNet.Clases;
using FixyNet.Clases.Listas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixyNet
{
    public partial class Descubrir : Form
    {

        Discovery res = new Discovery();

        Image imaOffline = Properties.Resources.fail;
        Image imaOnline = Properties.Resources.online;

        List<ListaIPRespuesta> resultado = new List<ListaIPRespuesta>();

        public Descubrir()
        {
            InitializeComponent();


        }
        private void ProgressEventHandler(object sender, ProgressBarEvent e)
        {

        }
        private void button1_ClickAsync(object sender, EventArgs e)
        {
            _ = Buscar();

        }

        private async Task Buscar()
        {


            dgDispositivos.Rows.Clear();



            if (tbRed.Text.Length == 0)
            {
                MessageBox.Show("Inserte una red", "Buscar dispositivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Discovery discovery = new Discovery();

                await discovery.BuscarDispositivos(tbRed.Text);

                if (chRegular.Checked)
                {
                    await discovery.Regular();
                }

                resultado = discovery.respuesta;
                string forMac = "Desconocido";
                string forHostname = "Desconocido";

                foreach (ListaIPRespuesta lista in resultado)
                {


                    if (lista.host != null)
                    {
                        forHostname = lista.host;
                    }
                    if (lista.mac != null)
                    {
                        forMac = lista.mac;
                    }

                    dgDispositivos.Rows.Add(imaOnline, true, true, lista.ip, forHostname, forMac, "Descripcion");
                }

                if (resultado.Count != 0)
                {
                    btnAgregarDisp.Enabled = true;
                }

            }
        }

        private void Descubrir_Load(object sender, EventArgs e)
        {

        }

        private void btnIp_Click(object sender, EventArgs e)
        {

            IPAddress[] IPS = Dns.GetHostAddresses(Dns.GetHostName());
            int cnIp = 0;
            int cnRun = 0;

            tbRed.Text = "";
            foreach (IPAddress ip in IPS)
            {

                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    cnIp += 1;
                }
            }

            string[] tresOctetos;

            foreach (IPAddress ip in IPS)
            {

                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    cnRun += 1;

                    if (cnIp == cnRun)
                    {
                        tresOctetos = Discovery.dividirIp(ip.ToString());

                        tbRed.Text += tresOctetos[0] + "." + tresOctetos[1] + "." + tresOctetos[2] + ".1-254";

                    }

                    if (cnRun < cnIp)
                    {
                        tresOctetos = Discovery.dividirIp(ip.ToString());

                        tbRed.Text += tresOctetos[0] + "." + tresOctetos[1] + "." + tresOctetos[2] + ".1-254,";
                    }

                }
            }



        }

        private void btnAgregarDispMan_Click(object sender, EventArgs e)
        {
            Form agregarManual = new frmAddDispMan();

            agregarManual.Show();
            this.Close();

        }

        private async void btnAgregarDisp_ClickAsync(object sender, EventArgs e)
        {
            List<ListaDispositivos> listaDispositivos = new List<ListaDispositivos>();
            DispositivosClass dispositivos = new DispositivosClass();

            foreach (DataGridViewRow row in dgDispositivos.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Agregar"].Value))
                {
                    listaDispositivos.Add(new ListaDispositivos
                    {
                        ip = row.Cells["ip"].Value.ToString(),
                        mac = row.Cells["Mac"].Value.ToString(),
                        hostname = row.Cells["Hostname"].Value.ToString(),
                        descripcion = row.Cells["Descripcion"].Value.ToString(),
                        monitor = Convert.ToBoolean(row.Cells["Monitor"].Value)
                    });
                }



            }
            dispositivos.listaDispositivos = listaDispositivos;

            await dispositivos.AgregarDispositivo();

            MessageBox.Show("Agregados correctamente.");
        }
    }

}
