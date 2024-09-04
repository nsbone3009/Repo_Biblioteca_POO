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
    public partial class frmListaDevolucionesLibros : Form
    {
        public frmListaDevolucionesLibros()
        {
            InitializeComponent();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesDevolucionesLibros obj = new frmAgregarODetallesDevolucionesLibros();
            this.AddOwnedForm(obj);
            obj.ShowDialog();
        }

        private void frmListaDevolucionesLibros_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            string consulta = "select id_dl, cedula_ltr, isbn_lb, fecha_prestamo, fecha_devolucion_programada, fecha_devolucion FROM Devoluciones";
            //csConexionSQL database = new csConexionSQL();
            //dgvDevoluciones.DataSource = database.MostrarRegistros(consulta);
            dgvDevoluciones = new csAjustarDataGridView().Ajustar(dgvDevoluciones, consulta);
        }
    }
}
