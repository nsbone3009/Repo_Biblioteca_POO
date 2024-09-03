namespace Proyecto_Biblioteca_Poo
{
    partial class frmListaEditoriales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaEditoriales));
            this.lbEditorial = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnModificarEditorial = new System.Windows.Forms.Button();
            this.btnAgregarEditorial = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEditorial
            // 
            this.lbEditorial.AutoSize = true;
            this.lbEditorial.BackColor = System.Drawing.Color.Transparent;
            this.lbEditorial.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditorial.ForeColor = System.Drawing.Color.White;
            this.lbEditorial.Location = new System.Drawing.Point(112, 68);
            this.lbEditorial.Name = "lbEditorial";
            this.lbEditorial.Size = new System.Drawing.Size(121, 24);
            this.lbEditorial.TabIndex = 3;
            this.lbEditorial.Text = "EDITORIAL";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestamos.Location = new System.Drawing.Point(25, 192);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(737, 335);
            this.dgvPrestamos.TabIndex = 19;
            // 
            // btnModificarEditorial
            // 
            this.btnModificarEditorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarEditorial.BackgroundImage")));
            this.btnModificarEditorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEditorial.FlatAppearance.BorderSize = 0;
            this.btnModificarEditorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarEditorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEditorial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEditorial.ForeColor = System.Drawing.Color.White;
            this.btnModificarEditorial.Location = new System.Drawing.Point(236, 563);
            this.btnModificarEditorial.Name = "btnModificarEditorial";
            this.btnModificarEditorial.Size = new System.Drawing.Size(180, 50);
            this.btnModificarEditorial.TabIndex = 18;
            this.btnModificarEditorial.Text = "MODIFICAR";
            this.btnModificarEditorial.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEditorial
            // 
            this.btnAgregarEditorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarEditorial.BackgroundImage")));
            this.btnAgregarEditorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEditorial.FlatAppearance.BorderSize = 0;
            this.btnAgregarEditorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEditorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEditorial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEditorial.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEditorial.Location = new System.Drawing.Point(25, 563);
            this.btnAgregarEditorial.Name = "btnAgregarEditorial";
            this.btnAgregarEditorial.Size = new System.Drawing.Size(180, 50);
            this.btnAgregarEditorial.TabIndex = 17;
            this.btnAgregarEditorial.Text = "AGREGAR";
            this.btnAgregarEditorial.UseVisualStyleBackColor = true;
            this.btnAgregarEditorial.Click += new System.EventHandler(this.btnAgregarEditorial_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(25, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(119, 137);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(643, 35);
            this.txtBuscar.TabIndex = 15;
            // 
            // frmListaEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Biblioteca_Poo.Properties.Resources.EDITORIAL;
            this.ClientSize = new System.Drawing.Size(785, 640);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnModificarEditorial);
            this.Controls.Add(this.btnAgregarEditorial);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbEditorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaEditoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaEditoriales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEditorial;
        public System.Windows.Forms.DataGridView dgvPrestamos;
        public System.Windows.Forms.Button btnModificarEditorial;
        public System.Windows.Forms.Button btnAgregarEditorial;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}