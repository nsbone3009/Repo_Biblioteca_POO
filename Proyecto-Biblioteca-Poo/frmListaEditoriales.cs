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
        public frmListaEditoriales()
        {
            InitializeComponent();
        }

        private void btnAgregarEditorial_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesEditorial frm = new frmAgregarODetallesEditorial();
            this.AddOwnedForm(frm);
            frm.lbTituloVentana.Text = "AGREGAR EDITORIAL";
            frm.ShowDialog();
        }
    }
}
