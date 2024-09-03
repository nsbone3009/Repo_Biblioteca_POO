namespace Proyecto_Biblioteca_Poo
{
    partial class frmAgregarODetallesGeneros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarODetallesGeneros));
            this.lbTituloVentana = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardarCampos = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombreAutor = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTituloVentana
            // 
            this.lbTituloVentana.AutoSize = true;
            this.lbTituloVentana.BackColor = System.Drawing.Color.Transparent;
            this.lbTituloVentana.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lbTituloVentana.Location = new System.Drawing.Point(67, 9);
            this.lbTituloVentana.Name = "lbTituloVentana";
            this.lbTituloVentana.Size = new System.Drawing.Size(94, 24);
            this.lbTituloVentana.TabIndex = 74;
            this.lbTituloVentana.Text = "XXXXXX";
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
            this.btnCerrar.Location = new System.Drawing.Point(379, 262);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(125, 40);
            this.btnCerrar.TabIndex = 86;
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
            this.btnGuardarCampos.Location = new System.Drawing.Point(49, 262);
            this.btnGuardarCampos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnGuardarCampos.Name = "btnGuardarCampos";
            this.btnGuardarCampos.Size = new System.Drawing.Size(125, 40);
            this.btnGuardarCampos.TabIndex = 85;
            this.btnGuardarCampos.Text = "Guardar";
            this.btnGuardarCampos.UseVisualStyleBackColor = false;
            this.btnGuardarCampos.Click += new System.EventHandler(this.btnGuardarCampos_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.White;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.cbEstado.Location = new System.Drawing.Point(49, 189);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(455, 37);
            this.cbEstado.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 83;
            this.label1.Text = "Estado";
            // 
            // lbNombreAutor
            // 
            this.lbNombreAutor.AutoSize = true;
            this.lbNombreAutor.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreAutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAutor.Location = new System.Drawing.Point(46, 58);
            this.lbNombreAutor.Name = "lbNombreAutor";
            this.lbNombreAutor.Size = new System.Drawing.Size(120, 18);
            this.lbNombreAutor.TabIndex = 82;
            this.lbNombreAutor.Text = "Nombre Genero";
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(49, 91);
            this.txtGenero.MaxLength = 50;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(455, 35);
            this.txtGenero.TabIndex = 81;
            // 
            // frmAgregarODetallesGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Biblioteca_Poo.Properties.Resources.DETALLES_GENERO;
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardarCampos);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombreAutor);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lbTituloVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarODetallesGeneros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarODetallesGeneros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbTituloVentana;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnGuardarCampos;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbNombreAutor;
        public System.Windows.Forms.TextBox txtGenero;
        public System.Windows.Forms.ComboBox cbEstado;
    }
}