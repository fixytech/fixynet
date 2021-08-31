namespace FixyNet
{
    partial class Dispositivos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dispositivos));
            this.dgDispositivos = new System.Windows.Forms.DataGridView();
            this.dispositivosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fixynetDataSet = new FixyNet.fixynetDataSet();
            this.dispositivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dispositivosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dispositivosTableAdapter = new FixyNet.fixynetDataSetTableAdapters.dispositivosTableAdapter();
            this.Monitor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uuiddispositivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDispositivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixynetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDispositivos
            // 
            this.dgDispositivos.AllowUserToAddRows = false;
            this.dgDispositivos.AllowUserToOrderColumns = true;
            this.dgDispositivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDispositivos.AutoGenerateColumns = false;
            this.dgDispositivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDispositivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monitor,
            this.ip,
            this.hostname,
            this.uuiddispositivoDataGridViewTextBoxColumn,
            this.subnet,
            this.mac,
            this.marca,
            this.modelo,
            this.descripcion});
            this.dgDispositivos.DataSource = this.dispositivosBindingSource2;
            this.dgDispositivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgDispositivos.Location = new System.Drawing.Point(12, 12);
            this.dgDispositivos.MultiSelect = false;
            this.dgDispositivos.Name = "dgDispositivos";
            this.dgDispositivos.RowHeadersVisible = false;
            this.dgDispositivos.Size = new System.Drawing.Size(1087, 426);
            this.dgDispositivos.TabIndex = 0;
            this.dgDispositivos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDispositivos_CellEndEdit);
            this.dgDispositivos.SelectionChanged += new System.EventHandler(this.dgDispositivos_SelectionChanged);
            // 
            // dispositivosBindingSource2
            // 
            this.dispositivosBindingSource2.DataMember = "dispositivos";
            this.dispositivosBindingSource2.DataSource = this.fixynetDataSet;
            // 
            // fixynetDataSet
            // 
            this.fixynetDataSet.DataSetName = "fixynetDataSet";
            this.fixynetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dispositivosBindingSource
            // 
            this.dispositivosBindingSource.DataMember = "dispositivos";
            this.dispositivosBindingSource.DataSource = this.fixynetDataSet;
            // 
            // dispositivosBindingSource1
            // 
            this.dispositivosBindingSource1.DataMember = "dispositivos";
            this.dispositivosBindingSource1.DataSource = this.fixynetDataSet;
            // 
            // dispositivosTableAdapter
            // 
            this.dispositivosTableAdapter.ClearBeforeFill = true;
            // 
            // Monitor
            // 
            this.Monitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Monitor.DataPropertyName = "monitor";
            this.Monitor.HeaderText = "Monitor";
            this.Monitor.Name = "Monitor";
            this.Monitor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Monitor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Monitor.Width = 50;
            // 
            // ip
            // 
            this.ip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ip.DataPropertyName = "ip";
            this.ip.HeaderText = "ip";
            this.ip.Name = "ip";
            // 
            // hostname
            // 
            this.hostname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hostname.DataPropertyName = "hostname";
            this.hostname.HeaderText = "hostname";
            this.hostname.Name = "hostname";
            this.hostname.Width = 150;
            // 
            // uuiddispositivoDataGridViewTextBoxColumn
            // 
            this.uuiddispositivoDataGridViewTextBoxColumn.DataPropertyName = "uuid_dispositivo";
            this.uuiddispositivoDataGridViewTextBoxColumn.HeaderText = "uuid_dispositivo";
            this.uuiddispositivoDataGridViewTextBoxColumn.Name = "uuiddispositivoDataGridViewTextBoxColumn";
            this.uuiddispositivoDataGridViewTextBoxColumn.Visible = false;
            // 
            // subnet
            // 
            this.subnet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.subnet.DataPropertyName = "subnet";
            this.subnet.HeaderText = "subnet";
            this.subnet.Name = "subnet";
            // 
            // mac
            // 
            this.mac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mac.DataPropertyName = "mac";
            this.mac.HeaderText = "mac";
            this.mac.Name = "mac";
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "marca";
            this.marca.Name = "marca";
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "modelo";
            this.modelo.Name = "modelo";
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // Dispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.dgDispositivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dispositivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispositivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dispositivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDispositivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixynetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDispositivos;
        private fixynetDataSet fixynetDataSet;
        private System.Windows.Forms.BindingSource dispositivosBindingSource;
        private fixynetDataSetTableAdapters.dispositivosTableAdapter dispositivosTableAdapter;
        private System.Windows.Forms.BindingSource dispositivosBindingSource1;
        private System.Windows.Forms.BindingSource dispositivosBindingSource2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Monitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn uuiddispositivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}