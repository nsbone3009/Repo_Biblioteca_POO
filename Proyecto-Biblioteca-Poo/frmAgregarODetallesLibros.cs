using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    public partial class frmAgregarODetallesLibros : Form
    {
        public string ISBN = "";

        public frmAgregarODetallesLibros()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PortadaLibro()
        {
            csConexionSQL conexion = new csConexionSQL();
            string consulta = "Select * from Libros where isbn_lb = '"+ISBN+"'";
            SqlDataReader leer = conexion.SelectLeer(consulta);
            if (leer.Read())
            {
                try
                {
                    MemoryStream ImgMemoria = new MemoryStream((byte[])leer["imagen_lb"]);
                    Bitmap bitmap = new Bitmap(ImgMemoria);
                    ptbxImagenLibro.BackgroundImage = bitmap;
                }
                catch { }
            }
        }

        private void btnEditarCampos_Click(object sender, EventArgs e)
        {
            txtTitulo.Enabled = true;
            cbAutor.Enabled = true;
            cbEditorial.Enabled = true;
            cbCategoria.Enabled = true;
            txtPublicacion.Enabled = true;
            txtCantidad.Enabled = true;
            txtResume.Enabled = true;
            btnGuardarCampos.Enabled = true;
            btnCambiarImagen.Enabled = true;
        }

        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {
            frmListaLibros frm = Owner as frmListaLibros;
            if (frm.validacion)
            {
                if (txtTitulo.Text != "" & cbAutor.SelectedIndex>-1 & cbEditorial.SelectedIndex > -1 & cbCategoria.SelectedIndex > -1 & txtPublicacion.Text != "" & txtCantidad.Text != "" & txtResume.Text != "")
                {
                    string consulta = "Update Libros set titulo_lb = '" + txtTitulo.Text + "', autor_es_lb = '" + cbAutor.SelectedItem.ToString() + "'," +
                " editorial_lb = '" + cbEditorial.SelectedItem.ToString() + "',genero_lb = '" + cbCategoria.SelectedItem.ToString() + "', año_publicacion_lb = '" + txtPublicacion.Text + "'," +
                " cantidad_lb = '" + txtCantidad.Text + "', sinopsis_lb = '" + txtResume.Text + "' where isbn_lb = '" + ISBN + "'";
                    new csConexionSQL().Update(consulta);
                    if (ptbxImagenLibro.Image != null)
                    {
                        new csGuardarImagenDatabase().GuardarImagen(ptbxImagenLibro, "Update Libros set imagen_lb = @imagen where isbn_lb = '" + ISBN + "' ");
                    }
                    frm.validacion = false;
                    frm.dgvLibros.Rows.Clear();
                    frm.MostrarLibros();
                    frm.validacion = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos solicitados.");
                }
            }
            else
            {
                if (txtIsbn.Text != "" & txtTitulo.Text != "" & cbAutor.SelectedIndex >-1  & cbEditorial.SelectedIndex > -1 & cbCategoria.SelectedIndex > -1 & txtPublicacion.Text != "" & txtCantidad.Text != "" & txtResume.Text != "")
                {
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    int añoP= Convert.ToInt32(txtPublicacion.Text);
                    if (cantidad >=1& añoP<2025)
                    {
                        string consulta = "Insert into Libros(isbn_lb, titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb)" +
                            "Values('" + txtIsbn.Text + "','" + txtTitulo.Text + "', '" + cbAutor.SelectedItem.ToString() + "', '" + cbEditorial.SelectedItem.ToString() + "', '" + cbCategoria.SelectedItem.ToString() + "', '" + txtPublicacion.Text + "', '" + txtCantidad.Text + "', '" + txtResume.Text + "')";
                        new csConexionSQL().Insert(consulta);
                        if (ptbxImagenLibro.Image != null)
                        {
                            new csGuardarImagenDatabase().GuardarImagen(ptbxImagenLibro, "Update Libros set imagen_lb = @imagen where isbn_lb = '" + txtIsbn.Text + "' ");
                        }
                        frm.dgvLibros.Rows.Clear();
                        frm.MostrarLibros();
                        frm.validacion = false;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cantidad o Año publicado invalida.");
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos solicitados.");
                }
            }
        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagen = new OpenFileDialog();
            Imagen.Filter = "archivos de imagen (*png;)|*png;";
            if (Imagen.ShowDialog() == DialogResult.OK)
            {
                ptbxImagenLibro.BackgroundImage = null;
                ptbxImagenLibro.Image = Image.FromFile(Imagen.FileName);
            }
        }

        private void txtPublicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten Letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten Letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten Numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
