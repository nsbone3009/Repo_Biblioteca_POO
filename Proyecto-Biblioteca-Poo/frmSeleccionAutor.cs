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
    public partial class frmSeleccionAutor : Form
    {
        public frmSeleccionAutor()
        {
            InitializeComponent();
        }

        private void frmSeleccionAutor_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            dgvAutores = new csAjustarDataGridView().Ajustar(dgvAutores, "Select NombreAutor, Estado from Autores");
        }
        private void dgvAutores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAgregarODetallesLibros frm = Owner as frmAgregarODetallesLibros;
            if (frm.txtAutores.Text != "") { frm.txtAutores.Text += ", " + dgvAutores.Rows[e.RowIndex].Cells[0].Value.ToString(); }
            else { frm.txtAutores.Text += dgvAutores.Rows[e.RowIndex].Cells[0].Value.ToString(); }
            this.Close();
        }
    }
}
