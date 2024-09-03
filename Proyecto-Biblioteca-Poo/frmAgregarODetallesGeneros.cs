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
    public partial class frmAgregarODetallesGeneros : Form
    {
        public bool bandera = false;
        public frmAgregarODetallesGeneros()
        {
            InitializeComponent();
        }
        static csConexionSQL obj = new csConexionSQL();
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {
            frmListaGenero frmGenero = Owner as frmListaGenero;
            if(bandera)
            {
                if (txtGenero.Text != "" && cbEstado.SelectedIndex != -1)
                {
                    obj.Insert("insert into Genero (NombreGenero, Estado) values ('" + txtGenero.Text + "', '" + cbEstado.SelectedIndex + "')");
                    MessageBox.Show("El género ha sido agregado correctamente.", "Género Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmGenero.dgvGenero.Rows.Clear();
                    frmGenero.MostrarDatos();
                    this.Close();
                }
                else
                    MessageBox.Show("Por favor, asegúrate de completar todos los campos requeridos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtGenero.Text != "" && cbEstado.SelectedIndex != -1)
                {
                    obj.Update("update Genero set Estado = '" + cbEstado.SelectedIndex + "' where NombreGenero = '" + txtGenero.Text.TrimEnd() + "'");
                    MessageBox.Show("Genero editado correctamente");
                    frmGenero.dgvGenero.Rows.Clear();
                    frmGenero.MostrarDatos();
                    this.Close();
                }
                else
                    MessageBox.Show("Algunos campos obligatorios están vacíos. Por favor, completa todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
