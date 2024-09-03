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
    public partial class frmAgregarODetallesEditorial : Form
    {
        public bool bandera = false;
        static csConexionSQL obj = new csConexionSQL();
        public frmAgregarODetallesEditorial()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {
            frmListaEditoriales frm = Owner as frmListaEditoriales;
            if (bandera)
            {
                if (txtEditorial.Text != "" && cbEstado.SelectedIndex != -1)
                {
                    obj.Insert("insert into Editorial (NombreEditorial, Estado) values ('" + txtEditorial.Text + "', '" + cbEstado.SelectedIndex + "')");
                    MessageBox.Show("La editorial ha sido agregada correctamente.", "Editorial Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.dgvEditorial.Rows.Clear();
                    frm.MostrarDatos();
                    this.Close();
                }
                else
                    MessageBox.Show("Por favor, completa todos los campos obligatorios antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtEditorial.Text != "" && cbEstado.SelectedIndex != -1)
                {
                    obj.Update("update Editorial set Estado = '" + cbEstado.SelectedIndex + "' where NombreEditorial = '" + txtEditorial.Text.TrimEnd() + "'");
                    MessageBox.Show("La editorial ha sido editada correctamente.", "Editorial Editada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.dgvEditorial.Rows.Clear();
                    frm.MostrarDatos();
                    this.Close();
                }
                else
                    MessageBox.Show("Por favor, completa todos los campos necesarios antes de proceder.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
