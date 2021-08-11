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
    }
}
