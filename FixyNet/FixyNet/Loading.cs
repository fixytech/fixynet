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
    public partial class Loading : Form
    {
       
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
           
        }

        public void setTitle(string title)
        {
           
            this.Text = title;
        }
        public void setProgress(int max, int min)
        {
            progressBarLoading.Maximum = max;
            progressBarLoading.Minimum = min;
        }
        public void statusProgress(int valor)
        {
            progressBarLoading.Value = valor;
            lblIp.Text = valor.ToString();

        }
    }
}
