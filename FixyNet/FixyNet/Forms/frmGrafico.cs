using FixyNet.Clases;
using FixyNet.Clases.Listas;
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
    public partial class frmGrafico : Form
    {
        public event EventHandler Cambio;
        public event EventHandler Cerrofrm;



        public frmGrafico()
        {
            InitializeComponent();
        }

        private void frmGrafico_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }




        private void frmGrafico_Paint(object sender, PaintEventArgs e)
        {
            InvocarCambio();
        }


        public void InvocarCambio()
        {
            this.Cambio?.Invoke(this, EventArgs.Empty);
        }
        public void InvocarCerrar()
        {
            this.Cerrofrm?.Invoke(this, EventArgs.Empty);
        }

        private void frmGrafico_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmGrafico_FormClosed(object sender, FormClosedEventArgs e)
        {
            InvocarCerrar();
        }

        private void progressGrafico_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        private void progressGrafico_Leave(object sender, EventArgs e)
        {

        }
    }
}
