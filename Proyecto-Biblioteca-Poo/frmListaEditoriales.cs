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
    public partial class frmListaEditoriales : Form
    {
        static frmAgregarODetallesEditorial frm = new frmAgregarODetallesEditorial();

        public frmListaEditoriales()
        {
            InitializeComponent();
        }

        private void btnAgregarEditorial_Click(object sender, EventArgs e)
        {
            if (dgvEditorial.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                this.AddOwnedForm(frm); frm.txtEditorial.Text = "";
                frm.cbEstado.SelectedIndex = -1;
                frm.txtEditorial.Enabled = true;
                frm.bandera = true;
                frm.lbTituloVentana.Text = "AGREGAR EDITORIAL";
                frm.ShowDialog();
            }
        }

        private void frmListaEditoriales_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            dgvEditorial = new csAjustarDataGridView().Ajustar(dgvEditorial, "select idEditorial, NombreEditorial, Estado from Editorial");
        }

        private void dgvEditorial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEditorial.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                this.AddOwnedForm(frm);
                frm.lbTituloVentana.Text = "MODIFICAR EDITORIAL";
                frm.txtEditorial.Enabled = false;
                frm.bandera = false;
                frm.txtEditorial.Text = dgvEditorial[1, dgvEditorial.CurrentRow.Index].Value.ToString().Trim();
                if (int.Parse(dgvEditorial[2, dgvEditorial.CurrentRow.Index].Value.ToString().Trim()) == 1)
                    frm.cbEstado.SelectedIndex = 1;
                else
                    frm.cbEstado.SelectedIndex = 0;

                frm.ShowDialog();
            }
        }
    }
}
