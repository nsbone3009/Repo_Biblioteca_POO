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

        private void btnAgregarGenero_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesGeneros frm = new frmAgregarODetallesGeneros();
            this.AddOwnedForm(frm);
            frm.lbTituloVentana.Text = "AGREGAR GENERO";
            frm.ShowDialog();
        }
    }
}
