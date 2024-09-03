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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaEditoriales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbEditorial = new System.Windows.Forms.Label();
            this.btnAgregarEditorial = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvEditorial = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditorial)).BeginInit();
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
            // dgvEditorial
            // 
            this.dgvEditorial.AllowUserToAddRows = false;
            this.dgvEditorial.AllowUserToDeleteRows = false;
            this.dgvEditorial.AllowUserToResizeColumns = false;
            this.dgvEditorial.AllowUserToResizeRows = false;
            this.dgvEditorial.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditorial.ColumnHeadersHeight = 50;
            this.dgvEditorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditorial.Location = new System.Drawing.Point(25, 199);
            this.dgvEditorial.Name = "dgvEditorial";
            this.dgvEditorial.ReadOnly = true;
            this.dgvEditorial.RowHeadersVisible = false;
            this.dgvEditorial.RowHeadersWidth = 50;
            this.dgvEditorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditorial.Size = new System.Drawing.Size(737, 335);
            this.dgvEditorial.TabIndex = 19;
            this.dgvEditorial.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditorial_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID EDITORIAL";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "GENERO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 334;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ESTADO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // frmListaEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Biblioteca_Poo.Properties.Resources.EDITORIAL;
            this.ClientSize = new System.Drawing.Size(785, 640);
            this.Controls.Add(this.dgvEditorial);
            this.Controls.Add(this.btnAgregarEditorial);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbEditorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaEditoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaEditoriales";
            this.Load += new System.EventHandler(this.frmListaEditoriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEditorial;
        public System.Windows.Forms.Button btnAgregarEditorial;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.DataGridView dgvEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}