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
            if (cbEstado.SelectedItem.ToString()=="Activo")
            {
                string consulta = "insert into Autores(NombreAutor,Estado)values('" + txtAutor.Text + "','" + cbEstado.SelectedIndex + "')";
                csConexionSQL conexionSQL = new csConexionSQL();
                conexionSQL.Insert(consulta);
                MessageBox.Show("Datos guardados Correctamente");
                this.Hide();

            }
            else
            {
                string consulta = "insert into Autores(NombreAutor,Estado)values('" + txtAutor.Text + "','" + cbEstado.SelectedIndex + "')";
                csConexionSQL conexionSQL = new csConexionSQL();
                conexionSQL.Insert(consulta);
                MessageBox.Show("Datos guardados Correctamente");
                this.Hide();
            }
            frmListaAutores frm =Owner as frmListaAutores;
            //frm.dgvAutores.Rows.Clear();
            frm.Actualizar();

        }

        private void btnEditarCampos_Click(object sender, EventArgs e)
        {
            btnGuardarCampos.Enabled = true;
        }
    }
}
