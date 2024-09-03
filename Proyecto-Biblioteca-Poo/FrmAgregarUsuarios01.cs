using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    public partial class FrmAgregarUsuarios01 : Form
    {
        public FrmAgregarUsuarios01()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            calDevolucion.Visible = !calDevolucion.Visible;
        }

        private void calDevolucion_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = calDevolucion.SelectionStart;
            txtFechaNacimiento.Text = fechaSeleccionada.ToString("dd-MM-yyyy");
            calDevolucion.Visible = false;
        }

        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && txtApellidos.Text != string.Empty && txtCedula.Text != string.Empty && txtDomicilio.Text != string.Empty && txtUsuario.Text != string.Empty && txtContraseña.Text != string.Empty && cbEstado.SelectedItem != null && cbRol.SelectedItem != null)
            {
                DateTime fechaNacimiento = calDevolucion.SelectionStart;

                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (fechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;

                if (edad < 18)
                {
                    MessageBox.Show("Debe ser mayor de 18 años para registrarse.");
                }
                else
                {
                    csLogin verificar = new csLogin();
                    bool verificador = verificar.VerificarCorreoSQL(txtCorreo.Text);
                    if (!verificador && txtCorreo.Text.Contains('@'))
                    {
                        csUsuarios users = new csUsuarios(txtCedula.Text, txtNombre.Text, txtApellidos.Text, fechaNacimiento.ToShortDateString(), cbRol.SelectedItem.ToString(), cbEstado.SelectedItem.ToString(), txtDomicilio.Text, txtCorreo.Text, txtUsuario.Text, txtContraseña.Text);
                        users.AgregarUsuario();
                        users.AgregarCredenciales();
                        MessageBox.Show("Datos agregados correctamente.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El correo electrónico ingresado ya está registrado en nuestro sistema o No es un correo valido. Por favor, ingrese una dirección de correo diferente.");
                        txtCorreo.Text = string.Empty;
                    }
                    FrmListaUsuarios frm = Owner as FrmListaUsuarios;
                    frm.dgvUsuarios.Rows.Clear();
                    frm.MostrarLibros();

                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos solicitados.");
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten Letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ValidarSoloLetrasYEspacios(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetrasYEspacios(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetrasYEspacios(e);
        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            btnMostrarContraseña.Visible = false;
            btnOcultarContraseña.Visible = true;
        }

        private void btnOcultarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            btnMostrarContraseña.Visible = true;
            btnOcultarContraseña.Visible = false;
        }

        private void FrmAgregarUsuarios01_Load(object sender, EventArgs e)
        {
            btnOcultarContraseña.Visible = false;
        }

        private void btnEditarCampos_Click(object sender, EventArgs e)
        {
            txtCorreo.Enabled = true;
            txtCedula.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtFechaNacimiento.Enabled = true;
            txtDomicilio.Enabled = true;
            cbRol.Enabled = true;
            cbEstado.Enabled = true;
           btnActualizar.Enabled = true;
            txtCedula.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmListaUsuarios frm = Owner as FrmListaUsuarios;
            if (txtNombre.Text != string.Empty && txtApellidos.Text != string.Empty && txtCedula.Text != string.Empty && txtDomicilio.Text != string.Empty && cbEstado.SelectedItem != null && cbRol.SelectedItem != null)
            {
                csUsuarios users = new csUsuarios(txtCedula.Text, txtNombre.Text, txtApellidos.Text, txtFechaNacimiento.Text, cbRol.SelectedItem.ToString(), cbEstado.SelectedItem.ToString(), txtDomicilio.Text, txtCorreo.Text, txtUsuario.Text, txtContraseña.Text);
                users.EditarDatos();
                frm.dgvUsuarios.Rows.Clear();
                frm.MostrarLibros();
                MessageBox.Show("Datos actualizados correctamente.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos solicitados.");
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
              if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("No se permiten espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}