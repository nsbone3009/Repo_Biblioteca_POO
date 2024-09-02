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
    public partial class FrmListaUsuarios : Form
    {
        public FrmListaUsuarios()
        {
            InitializeComponent();
            MostrarLibros();
        }
        public void MostrarLibros()
        {
            string consulta = "select * from  Usuarios";
            dgvUsuarios = new csAjustarDataGridView().Ajustar(dgvUsuarios, consulta);
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuarios01 agregar = new FrmAgregarUsuarios01();
            agregar.btnActualizar.Visible = false;
            agregar.btnEditarCampos.Enabled= false;
            agregar.ShowDialog();
            MostrarLibros();
        }

        private void FrmListaUsuarios_Load(object sender, EventArgs e)
        {
            MostrarLibros();
        }

        private void dgvLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAgregarUsuarios01 datos = new FrmAgregarUsuarios01();
            datos.txtCedula.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            datos.txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            datos.txtApellidos.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            datos.txtFechaNacimiento.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            datos.txtDomicilio.Text = dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            datos.txtCorreo.Text = dgvUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
            datos.cbRol.Text = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
            datos.cbEstado.Text = dgvUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString().Trim();
            datos.txtCorreo.Enabled = false;
            datos.txtCedula.Enabled = false;
            datos.txtNombre.Enabled = false;
            datos.txtApellidos.Enabled = false;
            datos.txtFechaNacimiento.Enabled = false;
            datos.txtDomicilio.Enabled = false;
            datos.cbRol.Enabled = false;
            datos.cbEstado.Enabled = false;
            datos.txtUsuario.Visible = false;
            datos.txtContraseña.Visible = false;
            datos.label10.Visible = false;
            datos.label2.Visible = false;
            datos.btnOcultarContraseña.Visible=false;
            datos.btnMostrarContraseña.Visible = false;
            datos.btnGuardarCampos.Enabled = false;
            datos.btnActualizar.Enabled = false;
           

            datos.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 3)
            {
                string consulta = "Select cedula_usr, nombres_usr, apellidos_usr, fecha_nacimiento_usr, direccion_domicilio_usr, correo_usr, rol_usr, estado_usr " +
                  "from Usuarios where cedula_usr like '%" + txtBuscar.Text + "%' or nombres_usr like '%" + txtBuscar.Text + "%' " +
                  "or apellidos_usr like '%" + txtBuscar.Text + "%' or fecha_nacimiento_usr like '%" + txtBuscar.Text + "%' " +
                  "or direccion_domicilio_usr like '%" + txtBuscar.Text + "%' or correo_usr like '%" + txtBuscar.Text + "%' " +
                  "or rol_usr like '%" + txtBuscar.Text + "%' or estado_usr like '%" + txtBuscar.Text + "%'";


                dgvUsuarios.Rows.Clear();
                dgvUsuarios = new csAjustarDataGridView().Ajustar(dgvUsuarios, consulta);
            }
            if (txtBuscar.Text.Length == 0)
            {
                dgvUsuarios.Rows.Clear();
                MostrarLibros();
            }
        }
    }
}
