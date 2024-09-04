namespace Proyecto_Biblioteca_Poo
{
    partial class frmListaDevolucionesLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDevolucionesLibros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbDevoluciones = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarDevolucion = new System.Windows.Forms.Button();
            this.dgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FDProgramada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDevoluciones
            // 
            this.lbDevoluciones.AutoSize = true;
            this.lbDevoluciones.BackColor = System.Drawing.Color.Transparent;
            this.lbDevoluciones.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevoluciones.ForeColor = System.Drawing.Color.White;
            this.lbDevoluciones.Location = new System.Drawing.Point(100, 76);
            this.lbDevoluciones.Name = "lbDevoluciones";
            this.lbDevoluciones.Size = new System.Drawing.Size(173, 24);
            this.lbDevoluciones.TabIndex = 1;
            this.lbDevoluciones.Text = "DEVOLUCIONES\r\n";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(24, 131);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarDevolucion
            // 
            this.btnAgregarDevolucion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDevolucion.BackgroundImage")));
            this.btnAgregarDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDevolucion.FlatAppearance.BorderSize = 0;
            this.btnAgregarDevolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDevolucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDevolucion.Location = new System.Drawing.Point(24, 536);
            this.btnAgregarDevolucion.Name = "btnAgregarDevolucion";
            this.btnAgregarDevolucion.Size = new System.Drawing.Size(180, 50);
            this.btnAgregarDevolucion.TabIndex = 17;
            this.btnAgregarDevolucion.Text = "AGREGAR";
            this.btnAgregarDevolucion.UseVisualStyleBackColor = true;
            this.btnAgregarDevolucion.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // dgvDevoluciones
            // 
            this.dgvDevoluciones.AllowUserToAddRows = false;
            this.dgvDevoluciones.AllowUserToDeleteRows = false;
            this.dgvDevoluciones.AllowUserToResizeColumns = false;
            this.dgvDevoluciones.AllowUserToResizeRows = false;
            this.dgvDevoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevoluciones.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cedula,
            this.Isbn,
            this.FPrestamo,
            this.FDProgramada,
            this.FDevolucion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevoluciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevoluciones.Location = new System.Drawing.Point(24, 186);
            this.dgvDevoluciones.Name = "dgvDevoluciones";
            this.dgvDevoluciones.ReadOnly = true;
            this.dgvDevoluciones.RowHeadersVisible = false;
            this.dgvDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevoluciones.Size = new System.Drawing.Size(737, 335);
            this.dgvDevoluciones.TabIndex = 16;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(118, 131);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(643, 35);
            this.txtBuscar.TabIndex = 15;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Isbn
            // 
            this.Isbn.HeaderText = "Isbn";
            this.Isbn.Name = "Isbn";
            this.Isbn.ReadOnly = true;
            // 
            // FPrestamo
            // 
            this.FPrestamo.HeaderText = "Fecha Prestamo";
            this.FPrestamo.Name = "FPrestamo";
            this.FPrestamo.ReadOnly = true;
            // 
            // FDProgramada
            // 
            this.FDProgramada.HeaderText = "Fecha Devolucion Programada";
            this.FDProgramada.Name = "FDProgramada";
            this.FDProgramada.ReadOnly = true;
            // 
            // FDevolucion
            // 
            this.FDevolucion.HeaderText = "Fecha Devolucion";
            this.FDevolucion.Name = "FDevolucion";
            this.FDevolucion.ReadOnly = true;
            // 
            // frmListaDevolucionesLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 640);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregarDevolucion);
            this.Controls.Add(this.dgvDevoluciones);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbDevoluciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaDevolucionesLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaDevolucionesLibros";
            this.Load += new System.EventHandler(this.frmListaDevolucionesLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDevoluciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarDevolucion;
        public System.Windows.Forms.DataGridView dgvDevoluciones;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDProgramada;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDevolucion;
    }
}