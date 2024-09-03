namespace Proyecto_Biblioteca_Poo
{
    partial class FrmAgregarUsuarios01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarUsuarios01));
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lbcedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarCampos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.calDevolucion = new System.Windows.Forms.MonthCalendar();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.btnEditarCampos = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnMostrarContraseña = new System.Windows.Forms.Button();
            this.btnOcultarContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(42, 130);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(189, 32);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 18F);
            this.txtNombre.Location = new System.Drawing.Point(263, 130);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 32);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Font = new System.Drawing.Font("Arial", 18F);
            this.txtApellidos.Location = new System.Drawing.Point(512, 130);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(238, 32);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // lbcedula
            // 
            this.lbcedula.AutoSize = true;
            this.lbcedula.BackColor = System.Drawing.Color.Transparent;
            this.lbcedula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcedula.Location = new System.Drawing.Point(45, 103);
            this.lbcedula.Name = "lbcedula";
            this.lbcedula.Size = new System.Drawing.Size(71, 18);
            this.lbcedula.TabIndex = 62;
            this.lbcedula.Text = "# Cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 66;
            this.label5.Text = "Apellidos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(539, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 18);
            this.label11.TabIndex = 69;
            this.label11.Text = "Fecha de Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 71;
            this.label8.Text = "Domicilio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 18);
            this.label12.TabIndex = 73;
            this.label12.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 18F);
            this.txtCorreo.Location = new System.Drawing.Point(42, 275);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(438, 32);
            this.txtCorreo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "Rol";
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Arial", 18F);
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Administrador",
            "Bibliotecario"});
            this.cbRol.Location = new System.Drawing.Point(263, 197);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(217, 35);
            this.cbRol.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 18F);
            this.txtUsuario.Location = new System.Drawing.Point(42, 416);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(438, 32);
            this.txtUsuario.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 78;
            this.label7.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Arial", 18F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(42, 197);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(189, 35);
            this.cbEstado.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 81;
            this.label10.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "Contraseña";
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
            this.btnGuardarCampos.Location = new System.Drawing.Point(530, 414);
            this.btnGuardarCampos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnGuardarCampos.Name = "btnGuardarCampos";
            this.btnGuardarCampos.Size = new System.Drawing.Size(192, 40);
            this.btnGuardarCampos.TabIndex = 84;
            this.btnGuardarCampos.Text = "Guardar";
            this.btnGuardarCampos.UseVisualStyleBackColor = false;
            this.btnGuardarCampos.Click += new System.EventHandler(this.btnGuardarCampos_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(530, 506);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(192, 40);
            this.btnCerrar.TabIndex = 85;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // calDevolucion
            // 
            this.calDevolucion.Location = new System.Drawing.Point(512, 242);
            this.calDevolucion.Name = "calDevolucion";
            this.calDevolucion.TabIndex = 87;
            this.calDevolucion.Visible = false;
            this.calDevolucion.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calDevolucion_DateSelected);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Arial", 18F);
            this.txtFechaNacimiento.Location = new System.Drawing.Point(512, 198);
            this.txtFechaNacimiento.Multiline = true;
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(197, 32);
            this.txtFechaNacimiento.TabIndex = 5;
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalendario.BackgroundImage")));
            this.btnCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalendario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.Color.White;
            this.btnCalendario.Location = new System.Drawing.Point(711, 197);
            this.btnCalendario.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(38, 35);
            this.btnCalendario.TabIndex = 89;
            this.btnCalendario.Text = "...";
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomicilio.Font = new System.Drawing.Font("Arial", 18F);
            this.txtDomicilio.Location = new System.Drawing.Point(42, 345);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(438, 32);
            this.txtDomicilio.TabIndex = 7;
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
            this.btnEditarCampos.Location = new System.Drawing.Point(530, 460);
            this.btnEditarCampos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnEditarCampos.Name = "btnEditarCampos";
            this.btnEditarCampos.Size = new System.Drawing.Size(192, 40);
            this.btnEditarCampos.TabIndex = 90;
            this.btnEditarCampos.Text = "Editar";
            this.btnEditarCampos.UseVisualStyleBackColor = false;
            this.btnEditarCampos.Click += new System.EventHandler(this.btnEditarCampos_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(42, 488);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(397, 35);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(530, 414);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(192, 40);
            this.btnActualizar.TabIndex = 94;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnMostrarContraseña
            // 
            this.btnMostrarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarContraseña.BackgroundImage")));
            this.btnMostrarContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarContraseña.FlatAppearance.BorderSize = 0;
            this.btnMostrarContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContraseña.Location = new System.Drawing.Point(445, 488);
            this.btnMostrarContraseña.Name = "btnMostrarContraseña";
            this.btnMostrarContraseña.Size = new System.Drawing.Size(35, 35);
            this.btnMostrarContraseña.TabIndex = 91;
            this.btnMostrarContraseña.UseVisualStyleBackColor = false;
            this.btnMostrarContraseña.Click += new System.EventHandler(this.btnMostrarContraseña_Click);
            // 
            // btnOcultarContraseña
            // 
            this.btnOcultarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnOcultarContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOcultarContraseña.BackgroundImage")));
            this.btnOcultarContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOcultarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultarContraseña.FlatAppearance.BorderSize = 0;
            this.btnOcultarContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOcultarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOcultarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarContraseña.Location = new System.Drawing.Point(445, 488);
            this.btnOcultarContraseña.Name = "btnOcultarContraseña";
            this.btnOcultarContraseña.Size = new System.Drawing.Size(35, 35);
            this.btnOcultarContraseña.TabIndex = 92;
            this.btnOcultarContraseña.UseVisualStyleBackColor = false;
            this.btnOcultarContraseña.Click += new System.EventHandler(this.btnOcultarContraseña_Click);
            // 
            // FrmAgregarUsuarios01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Biblioteca_Poo.Properties.Resources.BaseDetallesOAgregarLector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 582);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnOcultarContraseña);
            this.Controls.Add(this.btnMostrarContraseña);
            this.Controls.Add(this.btnEditarCampos);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.calDevolucion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardarCampos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbcedula);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarUsuarios01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAgregarUsuarios";
            this.Load += new System.EventHandler(this.FrmAgregarUsuarios01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbcedula;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnGuardarCampos;
        public System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.MonthCalendar calDevolucion;
        public System.Windows.Forms.Button btnCalendario;
        public System.Windows.Forms.Button btnEditarCampos;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellidos;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.ComboBox cbRol;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.TextBox txtFechaNacimiento;
        public System.Windows.Forms.TextBox txtDomicilio;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Button btnMostrarContraseña;
        public System.Windows.Forms.Button btnOcultarContraseña;
    }
}