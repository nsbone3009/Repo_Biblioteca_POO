﻿namespace Proyecto_Biblioteca_Poo
{
    partial class frmAgregarODetallesLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarODetallesLibros));
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardarCampos = new System.Windows.Forms.Button();
            this.btnEditarCampos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbTituloVentana = new System.Windows.Forms.Label();
            this.txtPublicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIsbn = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.ptbxImagenLibro = new System.Windows.Forms.PictureBox();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.cbEditorial = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtAutores = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagenLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(48, 134);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(681, 35);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(423, 290);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(69, 35);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtResume
            // 
            this.txtResume.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResume.Location = new System.Drawing.Point(48, 366);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(360, 139);
            this.txtResume.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Genero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Resumen";
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
            this.btnGuardarCampos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCampos.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCampos.Location = new System.Drawing.Point(629, 434);
            this.btnGuardarCampos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnGuardarCampos.Name = "btnGuardarCampos";
            this.btnGuardarCampos.Size = new System.Drawing.Size(100, 35);
            this.btnGuardarCampos.TabIndex = 23;
            this.btnGuardarCampos.Text = "Guardar";
            this.btnGuardarCampos.UseVisualStyleBackColor = false;
            this.btnGuardarCampos.Click += new System.EventHandler(this.btnGuardarCampos_Click);
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
            this.btnEditarCampos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCampos.ForeColor = System.Drawing.Color.White;
            this.btnEditarCampos.Location = new System.Drawing.Point(629, 471);
            this.btnEditarCampos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnEditarCampos.Name = "btnEditarCampos";
            this.btnEditarCampos.Size = new System.Drawing.Size(100, 35);
            this.btnEditarCampos.TabIndex = 24;
            this.btnEditarCampos.Text = "Editar";
            this.btnEditarCampos.UseVisualStyleBackColor = false;
            this.btnEditarCampos.Click += new System.EventHandler(this.btnEditarCampos_Click);
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
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(726, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbTituloVentana
            // 
            this.lbTituloVentana.AutoSize = true;
            this.lbTituloVentana.BackColor = System.Drawing.Color.Transparent;
            this.lbTituloVentana.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lbTituloVentana.Location = new System.Drawing.Point(103, 25);
            this.lbTituloVentana.Name = "lbTituloVentana";
            this.lbTituloVentana.Size = new System.Drawing.Size(94, 24);
            this.lbTituloVentana.TabIndex = 52;
            this.lbTituloVentana.Text = "XXXXXX";
            // 
            // txtPublicacion
            // 
            this.txtPublicacion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicacion.Location = new System.Drawing.Point(289, 290);
            this.txtPublicacion.Name = "txtPublicacion";
            this.txtPublicacion.Size = new System.Drawing.Size(118, 35);
            this.txtPublicacion.TabIndex = 8;
            this.txtPublicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublicacion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Año Publicacion";
            // 
            // lbIsbn
            // 
            this.lbIsbn.AutoSize = true;
            this.lbIsbn.BackColor = System.Drawing.Color.Transparent;
            this.lbIsbn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsbn.Location = new System.Drawing.Point(526, 269);
            this.lbIsbn.Name = "lbIsbn";
            this.lbIsbn.Size = new System.Drawing.Size(36, 18);
            this.lbIsbn.TabIndex = 54;
            this.lbIsbn.Text = "Isbn";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(529, 290);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(200, 35);
            this.txtIsbn.TabIndex = 53;
            // 
            // ptbxImagenLibro
            // 
            this.ptbxImagenLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbxImagenLibro.Location = new System.Drawing.Point(423, 366);
            this.ptbxImagenLibro.Name = "ptbxImagenLibro";
            this.ptbxImagenLibro.Size = new System.Drawing.Size(139, 139);
            this.ptbxImagenLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxImagenLibro.TabIndex = 55;
            this.ptbxImagenLibro.TabStop = false;
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCambiarImagen.BackgroundImage")));
            this.btnCambiarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarImagen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCambiarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCambiarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarImagen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarImagen.ForeColor = System.Drawing.Color.White;
            this.btnCambiarImagen.Location = new System.Drawing.Point(566, 470);
            this.btnCambiarImagen.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(37, 35);
            this.btnCambiarImagen.TabIndex = 56;
            this.btnCambiarImagen.Text = "...";
            this.btnCambiarImagen.UseVisualStyleBackColor = false;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // cbEditorial
            // 
            this.cbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditorial.Font = new System.Drawing.Font("Arial", 18F);
            this.cbEditorial.FormattingEnabled = true;
            this.cbEditorial.Location = new System.Drawing.Point(529, 209);
            this.cbEditorial.Name = "cbEditorial";
            this.cbEditorial.Size = new System.Drawing.Size(200, 35);
            this.cbEditorial.TabIndex = 57;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Arial", 18F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(48, 290);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(205, 35);
            this.cbCategoria.TabIndex = 58;
            // 
            // txtAutores
            // 
            this.txtAutores.Enabled = false;
            this.txtAutores.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutores.Location = new System.Drawing.Point(48, 209);
            this.txtAutores.Name = "txtAutores";
            this.txtAutores.Size = new System.Drawing.Size(432, 35);
            this.txtAutores.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(483, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 35);
            this.button1.TabIndex = 60;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAgregarODetallesLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAutores);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbEditorial);
            this.Controls.Add(this.btnCambiarImagen);
            this.Controls.Add(this.ptbxImagenLibro);
            this.Controls.Add(this.lbIsbn);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.lbTituloVentana);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditarCampos);
            this.Controls.Add(this.btnGuardarCampos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPublicacion);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarODetallesLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAgregarODetallesLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagenLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtTitulo;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtResume;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnGuardarCampos;
        public System.Windows.Forms.Button btnEditarCampos;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Label lbTituloVentana;
        public System.Windows.Forms.TextBox txtPublicacion;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbIsbn;
        public System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.PictureBox ptbxImagenLibro;
        public System.Windows.Forms.Button btnCambiarImagen;
        public System.Windows.Forms.ComboBox cbEditorial;
        public System.Windows.Forms.ComboBox cbCategoria;
        public System.Windows.Forms.TextBox txtAutores;
        public System.Windows.Forms.Button button1;
    }
}