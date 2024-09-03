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
    public partial class frmListaAutores : Form
    {
        public string Id;
        public frmListaAutores()
        {
            InitializeComponent();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesAutores frm = new frmAgregarODetallesAutores();
            frm.btnEditarCampos.Visible = false;
            this.AddOwnedForm(frm);
            frm.lbTituloVentana.Text = "AGREGAR AUTOR";
            frm.ShowDialog();
        }
        public void MostrarDatos()
        {
            dgvAutores = new csAjustarDataGridView().Ajustar(dgvAutores, "select idAutor, NombreAutor, Estado from Autores");
        }

        private void frmListaAutores_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void dgvAutores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAgregarODetallesAutores frm = new frmAgregarODetallesAutores();

            this.AddOwnedForm(frm);
            Id = dgvAutores.Rows[e.RowIndex].Cells[0].Value.ToString();
            frm.txtAutor.Text = dgvAutores.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.cbEstado.Text = dgvAutores.Rows[e.RowIndex].Cells[2].Value.ToString();
            frm.btnGuardarCampos.Enabled = false;
            frm.txtAutor.Enabled = false;
            frm.cbEstado.Enabled = false;
            frm.datoId(Id);
            frm.ShowDialog();

        }
       

    }
}
