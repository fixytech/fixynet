namespace FixyNet
{
    partial class Descubrir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Descubrir));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRed = new System.Windows.Forms.MaskedTextBox();
            this.btnIp = new System.Windows.Forms.Button();
            this.chIntense = new System.Windows.Forms.CheckBox();
            this.chRegular = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDispositivos = new System.Windows.Forms.DataGridView();
            this.btnAgregarDisp = new System.Windows.Forms.Button();
            this.btnAgregarDispMan = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.DataGridViewImageColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Monitor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDispositivos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbRed);
            this.groupBox1.Controls.Add(this.btnIp);
            this.groupBox1.Controls.Add(this.chIntense);
            this.groupBox1.Controls.Add(this.chRegular);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la red";
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(39, 23);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(696, 20);
            this.tbRed.TabIndex = 6;
            // 
            // btnIp
            // 
            this.btnIp.Location = new System.Drawing.Point(741, 21);
            this.btnIp.Name = "btnIp";
            this.btnIp.Size = new System.Drawing.Size(75, 23);
            this.btnIp.TabIndex = 5;
            this.btnIp.Text = "Mi-ip";
            this.btnIp.UseVisualStyleBackColor = true;
            this.btnIp.Click += new System.EventHandler(this.btnIp_Click);
            // 
            // chIntense
            // 
            this.chIntense.AutoSize = true;
            this.chIntense.Location = new System.Drawing.Point(1019, 26);
            this.chIntense.Name = "chIntense";
            this.chIntense.Size = new System.Drawing.Size(61, 17);
            this.chIntense.TabIndex = 4;
            this.chIntense.Text = "Intense";
            this.chIntense.UseVisualStyleBackColor = true;
            // 
            // chRegular
            // 
            this.chRegular.AutoSize = true;
            this.chRegular.Checked = true;
            this.chRegular.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chRegular.Location = new System.Drawing.Point(950, 26);
            this.chRegular.Name = "chRegular";
            this.chRegular.Size = new System.Drawing.Size(63, 17);
            this.chRegular.TabIndex = 3;
            this.chRegular.Text = "Regular";
            this.chRegular.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1086, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 29);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // dgDispositivos
            // 
            this.dgDispositivos.AllowUserToAddRows = false;
            this.dgDispositivos.AllowUserToDeleteRows = false;
            this.dgDispositivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDispositivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDispositivos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgDispositivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDispositivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDispositivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado,
            this.Agregar,
            this.Monitor,
            this.ip,
            this.Hostname,
            this.Mac,
            this.Descripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDispositivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDispositivos.EnableHeadersVisualStyles = false;
            this.dgDispositivos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgDispositivos.Location = new System.Drawing.Point(13, 74);
            this.dgDispositivos.Name = "dgDispositivos";
            this.dgDispositivos.RowHeadersVisible = false;
            this.dgDispositivos.Size = new System.Drawing.Size(1125, 335);
            this.dgDispositivos.TabIndex = 1;
            // 
            // btnAgregarDisp
            // 
            this.btnAgregarDisp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarDisp.Enabled = false;
            this.btnAgregarDisp.Location = new System.Drawing.Point(13, 415);
            this.btnAgregarDisp.Name = "btnAgregarDisp";
            this.btnAgregarDisp.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDisp.TabIndex = 2;
            this.btnAgregarDisp.Text = "Agregar";
            this.btnAgregarDisp.UseVisualStyleBackColor = true;
            this.btnAgregarDisp.Click += new System.EventHandler(this.btnAgregarDisp_ClickAsync);
            // 
            // btnAgregarDispMan
            // 
            this.btnAgregarDispMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarDispMan.Location = new System.Drawing.Point(94, 415);
            this.btnAgregarDispMan.Name = "btnAgregarDispMan";
            this.btnAgregarDispMan.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarDispMan.TabIndex = 3;
            this.btnAgregarDispMan.Text = "Agregar Manual";
            this.btnAgregarDispMan.UseVisualStyleBackColor = true;
            this.btnAgregarDispMan.Click += new System.EventHandler(this.btnAgregarDispMan_Click);
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estado.FillWeight = 76.14214F;
            this.Estado.HeaderText = "Estado";
            this.Estado.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Estado.Name = "Estado";
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Estado.Width = 50;
            // 
            // Agregar
            // 
            this.Agregar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.Name = "Agregar";
            this.Agregar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Agregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Agregar.Width = 50;
            // 
            // Monitor
            // 
            this.Monitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Monitor.HeaderText = "Monitor";
            this.Monitor.Name = "Monitor";
            this.Monitor.Width = 50;
            // 
            // ip
            // 
            this.ip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ip.FillWeight = 45.68527F;
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            this.ip.Width = 150;
            // 
            // Hostname
            // 
            this.Hostname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Hostname.HeaderText = "Hostname";
            this.Hostname.Name = "Hostname";
            this.Hostname.Width = 180;
            // 
            // Mac
            // 
            this.Mac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mac.FillWeight = 178.1725F;
            this.Mac.HeaderText = "Mac";
            this.Mac.Name = "Mac";
            this.Mac.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Descubrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.btnAgregarDispMan);
            this.Controls.Add(this.btnAgregarDisp);
            this.Controls.Add(this.dgDispositivos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Descubrir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descubrir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Descubrir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDispositivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDispositivos;
        private System.Windows.Forms.CheckBox chIntense;
        private System.Windows.Forms.CheckBox chRegular;
        private System.Windows.Forms.Button btnIp;
        private System.Windows.Forms.MaskedTextBox tbRed;
        private System.Windows.Forms.Button btnAgregarDisp;
        private System.Windows.Forms.Button btnAgregarDispMan;
        private System.Windows.Forms.DataGridViewImageColumn Estado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Agregar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Monitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}