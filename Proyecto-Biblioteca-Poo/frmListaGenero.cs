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
    public partial class frmListaGenero : Form
    {
        public frmListaGenero()
        {
            InitializeComponent();
        }
        static frmAgregarODetallesGeneros frm = new frmAgregarODetallesGeneros();
        private void btnAgregarGenero_Click(object sender, EventArgs e)
        {
            if (dgvGenero.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                this.AddOwnedForm(frm); frm.txtGenero.Text = "";
                frm.cbEstado.SelectedIndex = -1;
                frm.txtGenero.Enabled = true;
                frm.bandera = true;
                frm.lbTituloVentana.Text = "AGREGAR GENERO";
                frm.ShowDialog();
            }
        }
        private void frmListaGenero_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            dgvGenero = new csAjustarDataGridView().Ajustar(dgvGenero, "select idGenero, NombreGenero, Estado from Genero");
        }
        private void dgvGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGenero.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                this.AddOwnedForm(frm);
                frm.lbTituloVentana.Text = "MODIFICAR GENERO";
                frm.txtGenero.Enabled = false;
                frm.bandera = false;
                frm.txtGenero.Text = dgvGenero[1, dgvGenero.CurrentRow.Index].Value.ToString().Trim();
                if (int.Parse(dgvGenero[2, dgvGenero.CurrentRow.Index].Value.ToString().Trim()) == 1)
                    frm.cbEstado.SelectedIndex = 1;
                else
                    frm.cbEstado.SelectedIndex = 0;

                frm.ShowDialog();
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length >= 5)
                BusquedaPorCaracter(txtBuscar.Text);
            else
                Limpiar();
        }
        private void BusquedaPorCaracter(string busqueda)
        {
            try
            {
                dgvGenero.Rows.Clear();
                dgvGenero = new csAjustarDataGridView().Ajustar(dgvGenero, "select idGenero, NombreGenero, Estado from Genero where NombreGenero like '" + "%" + busqueda + "%" +"' ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Limpiar()
        {
            dgvGenero.Rows.Clear();
            MostrarDatos();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BusquedaPorCaracter(txtBuscar.Text);
        }
    }
}
