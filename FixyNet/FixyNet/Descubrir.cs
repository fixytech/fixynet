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

namespace FixyNet
{
    public partial class Descubrir : Form
    {
        public Descubrir()
        {
            InitializeComponent();
           

        }
        private void ProgressEventHandler(object sender, ProgressBarEvent e)
        {
            progressBarDescubrir.Maximum = e.Total;
            progressBarDescubrir.Value = e.Progress;
            lblProgressBarDescubrir.Text = e.Mensaje;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            dgDispositivos.Rows.Clear();

            List<ListaIPRespuesta> respuesta;
            respuesta = new List<ListaIPRespuesta>();
        

            if (tbRed.Text.Length == 0)
            {
                MessageBox.Show("Inserte una red", "Buscar dispositivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                HerramientasRed res = new HerramientasRed();
                res.ProgressEvent += ProgressEventHandler;

                respuesta = res.buscarDispositivos(tbRed.Text);
                

                foreach (ListaIPRespuesta lista in respuesta)
                {
                    dgDispositivos.Rows.Add(lista.ip, lista.estado);
                }
                
               

               
            }
        }

       
    }
}
