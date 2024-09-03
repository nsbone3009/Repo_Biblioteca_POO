namespace Proyecto_Biblioteca_Poo
{
    partial class frmListaGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaGenero));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbGenero = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregarGenero = new System.Windows.Forms.Button();
            this.btnModificarGenero = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.BackColor = System.Drawing.Color.Transparent;
            this.lbGenero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.ForeColor = System.Drawing.Color.White;
            this.lbGenero.Location = new System.Drawing.Point(120, 69);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(216, 24);
            this.lbGenero.TabIndex = 2;
            this.lbGenero.Text = "GÉNERO LITERARIO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(24, 135);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(118, 135);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(643, 35);
            this.txtBuscar.TabIndex = 10;
            // 
            // btnAgregarGenero
            // 
            this.btnAgregarGenero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarGenero.BackgroundImage")));
            this.btnAgregarGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarGenero.FlatAppearance.BorderSize = 0;
            this.btnAgregarGenero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarGenero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGenero.ForeColor = System.Drawing.Color.White;
            this.btnAgregarGenero.Location = new System.Drawing.Point(24, 561);
            this.btnAgregarGenero.Name = "btnAgregarGenero";
            this.btnAgregarGenero.Size = new System.Drawing.Size(180, 50);
            this.btnAgregarGenero.TabIndex = 12;
            this.btnAgregarGenero.Text = "AGREGAR";
            this.btnAgregarGenero.UseVisualStyleBackColor = true;
            this.btnAgregarGenero.Click += new System.EventHandler(this.btnAgregarGenero_Click);
            // 
            // btnModificarGenero
            // 
            this.btnModificarGenero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarGenero.BackgroundImage")));
            this.btnModificarGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarGenero.FlatAppearance.BorderSize = 0;
            this.btnModificarGenero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarGenero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarGenero.ForeColor = System.Drawing.Color.White;
            this.btnModificarGenero.Location = new System.Drawing.Point(235, 561);
            this.btnModificarGenero.Name = "btnModificarGenero";
            this.btnModificarGenero.Size = new System.Drawing.Size(180, 50);
            this.btnModificarGenero.TabIndex = 13;
            this.btnModificarGenero.Text = "MODIFICAR";
            this.btnModificarGenero.UseVisualStyleBackColor = true;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AllowUserToResizeColumns = false;
            this.dgvPrestamos.AllowUserToResizeRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamos.Location = new System.Drawing.Point(24, 190);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(737, 335);
            this.dgvPrestamos.TabIndex = 14;
            // 
            // frmListaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Biblioteca_Poo.Properties.Resources.GÉNERO__4_;
            this.ClientSize = new System.Drawing.Size(785, 640);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnModificarGenero);
            this.Controls.Add(this.btnAgregarGenero);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.Button btnAgregarGenero;
        public System.Windows.Forms.Button btnModificarGenero;
        public System.Windows.Forms.DataGridView dgvPrestamos;
    }
}