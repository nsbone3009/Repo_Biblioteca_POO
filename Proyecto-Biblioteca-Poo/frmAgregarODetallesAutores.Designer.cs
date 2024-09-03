namespace Proyecto_Biblioteca_Poo
{
    partial class frmAgregarODetallesAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarODetallesAutores));
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombreAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lbTituloVentana = new System.Windows.Forms.Label();
            this.btnEditarCampos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardarCampos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(46, 191);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(455, 37);
            this.cbEstado.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "Estado";
            // 
            // lbNombreAutor
            // 
            this.lbNombreAutor.AutoSize = true;
            this.lbNombreAutor.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreAutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAutor.Location = new System.Drawing.Point(43, 60);
            this.lbNombreAutor.Name = "lbNombreAutor";
            this.lbNombreAutor.Size = new System.Drawing.Size(104, 18);
            this.lbNombreAutor.TabIndex = 70;
            this.lbNombreAutor.Text = "Nombre Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(46, 93);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(455, 35);
            this.txtAutor.TabIndex = 69;
            // 
            // lbTituloVentana
            // 
            this.lbTituloVentana.AutoSize = true;
            this.lbTituloVentana.BackColor = System.Drawing.Color.Transparent;
            this.lbTituloVentana.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lbTituloVentana.Location = new System.Drawing.Point(66, 9);
            this.lbTituloVentana.Name = "lbTituloVentana";
            this.lbTituloVentana.Size = new System.Drawing.Size(94, 24);
            this.lbTituloVentana.TabIndex = 73;
            this.lbTituloVentana.Text = "XXXXXX";
            // 
            // btnEditarCampos
            // 
            this.btnEditarCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarCampos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarCampos.BackgroundImage")));
            this.btnEditarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCampos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCampos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCampos.ForeColor = System.Drawing.Color.White;
            this.btnEditarCampos.Location = new System.Drawing.Point(46, 264);
            this.btnEditarCampos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnEditarCampos.Name = "btnEditarCampos";
            this.btnEditarCampos.Size = new System.Drawing.Size(125, 40);
            this.btnEditarCampos.TabIndex = 80;
            this.btnEditarCampos.Text = "Editar";
            this.btnEditarCampos.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(376, 264);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(125, 40);
            this.btnCerrar.TabIndex = 79;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardarCampos
            // 
            this.btnGuardarCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCampos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarCampos.BackgroundImage")));
            this.btnGuardarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCampos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCampos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCampos.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCampos.Location = new System.Drawing.Point(214, 264);
            this.btnGuardarCampos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnGuardarCampos.Name = "btnGuardarCampos";
            this.btnGuardarCampos.Size = new System.Drawing.Size(125, 40);
            this.btnGuardarCampos.TabIndex = 78;
            this.btnGuardarCampos.Text = "Guardar";
            this.btnGuardarCampos.UseVisualStyleBackColor = false;
            // 
            // frmAgregarODetallesAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Biblioteca_Poo.Properties.Resources.AGREGAR_AUTOR;
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.btnEditarCampos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardarCampos);
            this.Controls.Add(this.lbTituloVentana);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombreAutor);
            this.Controls.Add(this.txtAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarODetallesAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarODetallesAutores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbNombreAutor;
        public System.Windows.Forms.TextBox txtAutor;
        public System.Windows.Forms.Label lbTituloVentana;
        public System.Windows.Forms.Button btnEditarCampos;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnGuardarCampos;
    }
}