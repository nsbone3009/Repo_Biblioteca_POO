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
            txtAutor.Enabled = true;
            txtEditorial.Enabled = true;
            txtCategoria.Enabled = true;
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
                string consulta = "Update Libros set titulo_lb = '" + txtTitulo.Text + "', autor_es_lb = '" + txtAutor.Text + "'," +
                " editorial_lb = '" + txtEditorial.Text + "',genero_lb = '" + txtCategoria.Text + "', año_publicacion_lb = '" + txtPublicacion.Text + "'," +
                " cantidad_lb = '" + txtCantidad.Text + "', sinopsis_lb = '" + txtResume.Text + "' where isbn_lb = '" + ISBN + "'";
                new csConexionSQL().Update(consulta);
                new csGuardarImagenDatabase().GuardarImagen(ptbxImagenLibro, "Update Libros set imagen_lb = @imagen where isbn_lb = '" + ISBN + "' ");
                frm.validacion = false;
            }
            else
            {
                string consulta = "Insert into Libros(isbn_lb, titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb)" +
                    "Values('"+txtIsbn.Text+"','"+txtTitulo.Text+"', '"+txtAutor.Text+"', '"+txtEditorial.Text+"', '"+txtCategoria.Text+"', '"+txtPublicacion.Text+"', '"+txtCantidad.Text+"', '"+txtResume.Text+"')";
                new csConexionSQL().Insert(consulta);
                new csGuardarImagenDatabase().GuardarImagen(ptbxImagenLibro, "Update Libros set imagen_lb = @imagen where isbn_lb = '"+txtIsbn.Text+"' ");
            }
            frm.dgvLibros.Rows.Clear();
            frm.MostrarLibros();
            frm.validacion = false;
            this.Close();
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
    }
}
