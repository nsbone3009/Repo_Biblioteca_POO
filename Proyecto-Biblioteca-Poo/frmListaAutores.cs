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
        public frmListaAutores()
        {
            InitializeComponent();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesAutores frm = new frmAgregarODetallesAutores();
            this.AddOwnedForm(frm);
            frm.lbTituloVentana.Text = "AGREGAR AUTOR";
            frm.ShowDialog();
        }

        private void dgvPrestamos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAgregarODetallesAutores detalles = new frmAgregarODetallesAutores();
            detalles.txtAutor.Text = dgvAutores.Rows[e.RowIndex].Cells[0].Value.ToString();
            detalles.cbEstado.Text = dgvAutores.Rows[e.RowIndex].Cells[1].Value.ToString();
            detalles.btnGuardarCampos.Enabled = false;
            detalles.ShowDialog();
            
        }
        public void Actualizar()
        {
            string consulta = "select NombreAutor,Estado,FechaRegistro from Autores";
            csConexionSQL VerDatos = new csConexionSQL();
            DataTable dt = VerDatos.MostrarRegistros(consulta);
            dgvAutores.DataSource = dt;

        }

        private void frmListaAutores_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
