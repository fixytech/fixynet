namespace FixyNet.Forms
{
    partial class FrmMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonitor));
            this.dgEvents = new System.Windows.Forms.DataGridView();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uuid_dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uuid_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoRecargaDatos = new System.Windows.Forms.Timer(this.components);
            this.tiempoPool = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnIiciar = new System.Windows.Forms.Button();
            this.numEventos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numPool = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPool)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEvents
            // 
            this.dgEvents.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.dgEvents.AllowUserToAddRows = false;
            this.dgEvents.AllowUserToDeleteRows = false;
            this.dgEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estado,
            this.tiempo_respuesta,
            this.fecha,
            this.hora,
            this.ip,
            this.hostname,
            this.mac,
            this.observacion,
            this.uuid_dispositivo,
            this.Expr1,
            this.uuid_evento});
            this.dgEvents.Location = new System.Drawing.Point(12, 99);
            this.dgEvents.Name = "dgEvents";
            this.dgEvents.RowHeadersVisible = false;
            this.dgEvents.Size = new System.Drawing.Size(909, 339);
            this.dgEvents.TabIndex = 0;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // tiempo_respuesta
            // 
            this.tiempo_respuesta.DataPropertyName = "tiempo_respuesta";
            this.tiempo_respuesta.HeaderText = "Respuesta (Ms)";
            this.tiempo_respuesta.Name = "tiempo_respuesta";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            // 
            // ip
            // 
            this.ip.DataPropertyName = "ip";
            this.ip.HeaderText = "Ip";
            this.ip.Name = "ip";
            // 
            // hostname
            // 
            this.hostname.DataPropertyName = "hostname";
            this.hostname.HeaderText = "Hostname";
            this.hostname.Name = "hostname";
            // 
            // mac
            // 
            this.mac.DataPropertyName = "mac";
            this.mac.HeaderText = "Mac";
            this.mac.Name = "mac";
            // 
            // observacion
            // 
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "Observacion";
            this.observacion.Name = "observacion";
            // 
            // uuid_dispositivo
            // 
            this.uuid_dispositivo.DataPropertyName = "uuid_dispositivo";
            this.uuid_dispositivo.HeaderText = "uuid_dispositivo";
            this.uuid_dispositivo.Name = "uuid_dispositivo";
            this.uuid_dispositivo.Visible = false;
            // 
            // Expr1
            // 
            this.Expr1.DataPropertyName = "Expr1";
            this.Expr1.HeaderText = "Expr1";
            this.Expr1.Name = "Expr1";
            this.Expr1.Visible = false;
            // 
            // uuid_evento
            // 
            this.uuid_evento.DataPropertyName = "uuid_evento";
            this.uuid_evento.HeaderText = "uuid_evento";
            this.uuid_evento.Name = "uuid_evento";
            this.uuid_evento.Visible = false;
            // 
            // tiempoRecargaDatos
            // 
            this.tiempoRecargaDatos.Interval = 1000;
            this.tiempoRecargaDatos.Tick += new System.EventHandler(this.TiempoRecargaDatos_Tick);
            // 
            // tiempoPool
            // 
            this.tiempoPool.Tick += new System.EventHandler(this.TiempoPool_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timpo de Pooleo";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDetener);
            this.groupBox1.Controls.Add(this.btnIiciar);
            this.groupBox1.Controls.Add(this.numEventos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numPool);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion de Monitoreo";
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(555, 31);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 7;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // btnIiciar
            // 
            this.btnIiciar.Location = new System.Drawing.Point(473, 31);
            this.btnIiciar.Name = "btnIiciar";
            this.btnIiciar.Size = new System.Drawing.Size(75, 23);
            this.btnIiciar.TabIndex = 6;
            this.btnIiciar.Text = "Iniciar";
            this.btnIiciar.UseVisualStyleBackColor = true;
            this.btnIiciar.Click += new System.EventHandler(this.BtnIiciar_Click);
            // 
            // numEventos
            // 
            this.numEventos.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEventos.Location = new System.Drawing.Point(347, 34);
            this.numEventos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEventos.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEventos.Name = "numEventos";
            this.numEventos.Size = new System.Drawing.Size(120, 20);
            this.numEventos.TabIndex = 5;
            this.numEventos.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Timpo recarga eventos";
            // 
            // numPool
            // 
            this.numPool.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPool.Location = new System.Drawing.Point(99, 34);
            this.numPool.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPool.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPool.Name = "numPool";
            this.numPool.Size = new System.Drawing.Size(120, 20);
            this.numPool.TabIndex = 3;
            this.numPool.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMonitor_FormClosed);
            this.Load += new System.EventHandler(this.FrmMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPool)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgEvents;
        private System.Windows.Forms.Timer tiempoRecargaDatos;
        private System.Windows.Forms.Timer tiempoPool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numPool;
        private System.Windows.Forms.NumericUpDown numEventos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIiciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn uuid_dispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uuid_evento;
    }
}