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
            string consulta = "select id_dl as ID, cedula_ltr as [CEDULA LECTOR], isbn_lb as ISBN, fecha_prestamo AS [FECHA PRESTAMO], fecha_devolucion_programada as [FECHA DEVOLUCION PROGRAMADA], fecha_devolucion as [FECHA DEVOLUCION] FROM Devoluciones";
            csConexionSQL database = new csConexionSQL();
            dgvDevoluciones.DataSource = database.MostrarRegistros(consulta);
        }
    }
}
