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
        static frmAgregarODetallesAutores frm = new frmAgregarODetallesAutores();
        public string Id;
        public frmListaAutores()
        {
            InitializeComponent();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (dgvAutores.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                this.AddOwnedForm(frm); frm.txtAutor.Text = "";
                frm.cbEstado.SelectedIndex = -1;
                frm.txtAutor.Enabled = true;
                frm.bandera = true;
                frm.lbTituloVentana.Text = "AGREGAR AUTOR";
                frm.ShowDialog();
            }
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
            if (dgvAutores.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                this.AddOwnedForm(frm);
                frm.lbTituloVentana.Text = "MODIFICAR GENERO";
                frm.txtAutor.Enabled = false;
                frm.bandera = false;
                frm.txtAutor.Text = dgvAutores[1, dgvAutores.CurrentRow.Index].Value.ToString().Trim();
                if (int.Parse(dgvAutores[2, dgvAutores.CurrentRow.Index].Value.ToString().Trim()) == 1)
                    frm.cbEstado.SelectedIndex = 1;
                else
                    frm.cbEstado.SelectedIndex = 0;

                frm.ShowDialog();
            }
        }
    }
}
