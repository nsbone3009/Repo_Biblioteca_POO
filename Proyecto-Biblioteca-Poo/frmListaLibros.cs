using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    public partial class frmListaLibros : Form
    {
        public bool validacion = false;
        public bool banderaLibros = false;
        static csLibro libro = new csLibro();
        public frmListaLibros()
        {
            InitializeComponent();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesLibros frm = new frmAgregarODetallesLibros();
            this.AddOwnedForm(frm);
            validacion = true;
            frm.lbTituloVentana.Text = "AGREGAR LIBRO";
            frm.ShowDialog();
        }
        private void frmListaLibros_Load(object sender, EventArgs e)
        {
            libro.MostrarLibros(dgvLibros);
        }
        private void dgvLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (banderaLibros == true)
                {
                    try
                    {
                        if (e.RowIndex >= 0)
                        {
                            string ISBN = new csConexionSQL().Extraer("Select isbn_lb from Libros where titulo_lb = '" + dgvLibros.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", "isbn_lb");
                            string Titulo = dgvLibros.Rows[e.RowIndex].Cells[0].Value.ToString();
                            frmAgregarODetallesPrestamosLibros frmPrincipal = Owner as frmAgregarODetallesPrestamosLibros;
                            if (frmPrincipal != null)
                            {
                                frmPrincipal.txtISBN.Text = ISBN;
                                frmPrincipal.txtTituloLibro.Text = Titulo;
                            }
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en if dgvlectores: " + ex);
                    }
                }
                else
                {
                    if (e.RowIndex >= 0)
                    {
                        csLibro libro = new csLibro();
                        frmAgregarODetallesLibros frm = new frmAgregarODetallesLibros();
                        this.AddOwnedForm(frm);
                        libro.Modificar(dgvLibros.Rows[e.RowIndex], frm);
                    }
                }
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text.Length > 3)
            {
                string consulta = "Select titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb " +
                    "from Libros where titulo_lb like '%"+txtBuscar.Text+ "%' or autor_es_lb like '%"+txtBuscar.Text+ "%' or editorial_lb like '%"+txtBuscar.Text+"%' " +
                    "or genero_lb like '%"+txtBuscar.Text+"%'";
                dgvLibros.Rows.Clear();
                dgvLibros = new csAjustarDataGridView().Ajustar(dgvLibros, consulta);
            }
            if (txtBuscar.Text.Length == 0)
            {
                dgvLibros.Rows.Clear();
                libro.MostrarLibros(dgvLibros);
            }
        }
    }
}
