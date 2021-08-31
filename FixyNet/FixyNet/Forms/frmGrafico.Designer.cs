namespace FixyNet.Forms
{
    partial class frmGrafico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafico));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressGrafico = new System.Windows.Forms.ToolStripProgressBar();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressGrafico,
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1394, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressGrafico
            // 
            this.progressGrafico.Name = "progressGrafico";
            this.progressGrafico.Size = new System.Drawing.Size(100, 16);
            this.progressGrafico.Leave += new System.EventHandler(this.progressGrafico_Leave);
            this.progressGrafico.QueryAccessibilityHelp += new System.Windows.Forms.QueryAccessibilityHelpEventHandler(this.progressGrafico_QueryAccessibilityHelp);
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 17);
            this.lblEstado.Text = "Escaneadas:";
            // 
            // frmGrafico
            // 
            this.ClientSize = new System.Drawing.Size(1394, 591);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Grafico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGrafico_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGrafico_FormClosed);
            this.Load += new System.EventHandler(this.frmGrafico_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGrafico_Paint);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripProgressBar progressGrafico;
        public System.Windows.Forms.ToolStripStatusLabel lblEstado;
    }
}