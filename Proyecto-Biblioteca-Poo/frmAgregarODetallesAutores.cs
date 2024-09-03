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
    public partial class frmAgregarODetallesAutores : Form
    {
        public bool bandera=false;
        static csConexionSQL obj = new csConexionSQL();
        public frmAgregarODetallesAutores()
        {
            InitializeComponent();
        }
    

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {
            frmListaAutores frmGenero = Owner as frmListaAutores;
            if (bandera)
            {
                if (txtAutor.Text != "" && cbEstado.SelectedIndex != -1)
                {
                    obj.Insert("insert into Autores (NombreAutor, Estado) values ('" + txtAutor.Text + "', '" + cbEstado.SelectedIndex + "')");
                    MessageBox.Show("El autor ha sido agregado exitosamente a la base de datos.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmGenero.dgvAutores.Rows.Clear();
                    frmGenero.MostrarDatos();
                    this.Close();
                }
                else
                    MessageBox.Show("Faltan campos por llenar");
            }
            else
            {
                if (txtAutor.Text != "" && cbEstado.SelectedIndex != -1)
                {
                    obj.Update("update Autores set Estado = '" + cbEstado.SelectedIndex + "' where NombreAutor = '" + txtAutor.Text.TrimEnd() + "'");
                    MessageBox.Show("El autor ha sido editado correctamente.", "Autor Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmGenero.dgvAutores.Rows.Clear();
                    frmGenero.MostrarDatos();
                    this.Close();
                }
                else
                    MessageBox.Show("Por favor, completa todos los campos requeridos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnEditarCampos_Click(object sender, EventArgs e)
        {
            cbEstado.Enabled = true;
            btnEditarCampos.Visible = true;
            btnGuardarCampos.Enabled = true;
            bandera = true;
        }
    }
}
