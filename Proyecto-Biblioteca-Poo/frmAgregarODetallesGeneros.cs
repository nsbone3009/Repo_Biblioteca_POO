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
                    MessageBox.Show("Genero agregado correctamente");
                    frmGenero.dgvGenero.Rows.Clear();
                    frmGenero.MostrarDatos();
                    this.Close();
                }
                else
                    MessageBox.Show("Faltan campos por llenar");
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
                    MessageBox.Show("Faltan campos por llenar");
            }

        }
    }
}
