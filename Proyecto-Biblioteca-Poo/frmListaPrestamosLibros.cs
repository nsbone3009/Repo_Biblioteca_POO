using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Biblioteca_Poo
{
    public partial class frmListaPrestamosLibros : Form
    {
        csPrestamos prestamo = new csPrestamos();
        csConexionSQL database = new csConexionSQL();
        public bool bandera = false;

        public frmListaPrestamosLibros()
        {
            InitializeComponent();
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesPrestamosLibros formulario = new frmAgregarODetallesPrestamosLibros();
            formulario.LabelText = "AGREGAR PRESTAMO";
            formulario.GuardarOModificar = true;
            formulario.ShowDialog();
            dgvPrestamos.Rows.Clear();
            CargarDatos();
        }

        private void frmListaPrestamosLibros_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            string sentencia = prestamo.CargarDatos();
            dgvPrestamos = new csAjustarDataGridView().Ajustar(dgvPrestamos, sentencia);
            //dgvPrestamos.DataSource = database.MostrarRegistros(sentencia);
            //dgvPrestamos = new csAjustarDataGridView().AjustarDatos(dgvPrestamos);
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBuscar.Text.Length > 4)
            {
                dgvPrestamos.DataSource = database.MostrarRegistros("SELECT id_ptm as [ID Prestamo], cedula_ltr as [Cédula Lector], isbn_lb as [ISBN Libro], fecha_prestamo as [Fecha Préstamo], fecha_devolucio_programada as [Fecha devolucion] FROM Prestamos where estado_=1 and CONVERT(varchar,cedula_ltr) like '%" + txtBuscar.Text + "%'  or isbn_lb like '%" + txtBuscar.Text + "%'");
            }
            if (txtBuscar.Text.Length == 0)
            {
                dgvPrestamos.Rows.Clear();
                CargarDatos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPrestamos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (bandera == true)
            {
                frmAgregarODetallesDevolucionesLibros datitos = Owner as frmAgregarODetallesDevolucionesLibros;
                datitos.txtTitulo.Text = new csConexionSQL().Extraer("Select titulo_lb From Libros where isbn_lb = '" + dgvPrestamos.Rows[e.RowIndex].Cells[2].Value.ToString() +"'", "titulo_lb");
                datitos.txtLector.Text = new csConexionSQL().Extraer("Select cedula_ltr From Lectores where cedula_ltr = '" + dgvPrestamos.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", "cedula_ltr");
                datitos.txtCedula.Text = dgvPrestamos.Rows[e.RowIndex].Cells[1].Value.ToString();
                datitos.txtISBN.Text = dgvPrestamos.Rows[e.RowIndex].Cells[2].Value.ToString();
                datitos.txtFechaPrestamo.Text = dgvPrestamos.Rows[e.RowIndex].Cells[3].Value.ToString();
                datitos.txtFechaDevolucion.Text = dgvPrestamos.Rows[e.RowIndex].Cells[4].Value.ToString();
                datitos.txtFechaActual.Text = DateTime.Now.ToString("dd-MM-yyyy");
                this.Close();
            }
            else
            {
                if (dgvPrestamos.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvPrestamos.SelectedRows[0];
                    int idPrestamo = int.Parse(selectedRow.Cells[0].Value.ToString());
                    new frmAgregarODetallesPrestamosLibros(idPrestamo).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dgvPrestamos.Rows.Clear();
                CargarDatos();
            }
            
        }
    }
}
