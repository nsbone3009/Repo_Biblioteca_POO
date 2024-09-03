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
        public int id;
        public bool bandera=false;  
        public frmAgregarODetallesAutores()
        {
            InitializeComponent();
        }
    

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int datoId(string ID)
        {
            id= Convert.ToInt32(ID);

            return id;
        }

        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {
            btnEditarCampos.Visible = false;
            if (bandera==false)
            {
                if (cbEstado.SelectedItem.ToString() == "Activo")
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
            }
            else
            {
                if (cbEstado.SelectedItem.ToString() == "Activo")
                {
                    string consulta = "update Autores set NombreAutor='" + txtAutor.Text + "', Estado='" + cbEstado.SelectedIndex + "' where idAutor=" + id + " ";

                    csConexionSQL conexionSQL = new csConexionSQL();
                    conexionSQL.Update(consulta);
                    MessageBox.Show("Datos actualizados Correctamente");
                    this.Hide();

                }
                else
                {
                    string consulta = "update Autores set NombreAutor='" + txtAutor.Text + "', Estado='" + cbEstado.SelectedIndex + "' where idAutor=" + id + " ";

                    csConexionSQL conexionSQL = new csConexionSQL();
                    conexionSQL.Update(consulta);
                    MessageBox.Show("Datos actualizados Correctamente");
                    this.Hide();
                }
            }
            frmListaAutores frm =Owner as frmListaAutores;
            //frm.dgvAutores.Rows.Clear();
            frm.Actualizar();

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
