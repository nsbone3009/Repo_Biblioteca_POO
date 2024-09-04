using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    internal class csLibro
    {
        public string ISBN { get; set; }
        //public string Titulo { get; set; }
        //public string Autor { get; set; }
        //public string Editorial { get; set; }
        //public string Genero { get; set; }
        //public string publicacion { get; set; }
        //public string sinopsis { get; set; }
        private csConexionSQL conexion;

        public csLibro()
        {
            conexion = new csConexionSQL();
        }

        // Mostrar Lista de Libros
        public void MostrarLibros(DataGridView dgvLibros)
        {
            string consulta = "Select titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb from Libros";
            dgvLibros.Rows.Clear();
            dgvLibros = new csAjustarDataGridView().Ajustar(dgvLibros, consulta);
        }
        public void CambiarImagen(PictureBox ptbxImagenLibro)
        {
            OpenFileDialog Imagen = new OpenFileDialog();
            Imagen.Filter = "archivos de imagen (*.png;)|*.png;";
            if (Imagen.ShowDialog() == DialogResult.OK)
            {
                ptbxImagenLibro.BackgroundImage = null;
                ptbxImagenLibro.Image = Image.FromFile(Imagen.FileName);
            }
        }

        public void HabilitarCampos(TextBox txtTitulo, ComboBox cbAutor, ComboBox cbEditorial, ComboBox cbCategoria,
                                    TextBox txtPublicacion, TextBox txtCantidad, TextBox txtResume, Button btnGuardarCampos, Button btnCambiarImagen)
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
        // Agregar un nuevo libro
        public void AgregarLibro(string isbn,string titulo, string autor, string editorial, string genero, string publicacion, int cantidad, string sinopsis, PictureBox ptbxImagenLibro)
        {

            string consulta = $"Insert into Libros(isbn_lb, titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb)" +
                              $"Values('{isbn}', '{titulo}', '{autor}', '{editorial}', '{genero}', '{publicacion}', {cantidad}, '{sinopsis}')";
            conexion.Insert(consulta);

            // Guardar imagen del libro si se ha seleccionado
            if (ptbxImagenLibro.Image != null)
            {
                new csGuardarImagenDatabase().GuardarImagen(ptbxImagenLibro, $"Update Libros set imagen_lb = @imagen where isbn_lb = '{ISBN}' ");
            }
        }

        // Modificar un libro existente
        public void ModificarLibro(string isbn, string titulo, string autor, string editorial, string genero, string publicacion, int cantidad, string sinopsis, PictureBox ptbxImagenLibro)
        {
            string consulta = $"Update Libros set titulo_lb = '{titulo}', autor_es_lb = '{autor}', editorial_lb = '{editorial}', genero_lb = '{genero}', " +
                              $"año_publicacion_lb = '{publicacion}', cantidad_lb = {cantidad}, sinopsis_lb = '{sinopsis}' where isbn_lb = '{isbn}'";
            conexion.Update(consulta);

            // Actualizar imagen del libro si se ha cambiado
            if (ptbxImagenLibro.Image != null)
            {
                new csGuardarImagenDatabase().GuardarImagen(ptbxImagenLibro, $"Update Libros set imagen_lb = @imagen where isbn_lb = '{isbn}' ");
            }
        }
        public void Modificar(DataGridViewRow filaSeleccionada, frmAgregarODetallesLibros frm)
        {
            csConexionSQL conexion = new csConexionSQL();
            frm.MostrarLista();
            frm.lbTituloVentana.Text = "Detalles del Libro";
            frm.ISBN = conexion.Extraer($"Select isbn_lb from Libros where titulo_lb = '{filaSeleccionada.Cells[0].Value.ToString().Trim()}'", "isbn_lb");
            frm.txtTitulo.Text = filaSeleccionada.Cells[0].Value.ToString().Trim();
            frm.cbAutor.SelectedItem = filaSeleccionada.Cells[1].Value.ToString().Trim();
            frm.cbEditorial.SelectedItem = filaSeleccionada.Cells[2].Value.ToString().Trim();
            frm.cbCategoria.SelectedItem = filaSeleccionada.Cells[3].Value.ToString().Trim();
            frm.txtPublicacion.Text = filaSeleccionada.Cells[4].Value.ToString().Trim();
            frm.txtCantidad.Text = filaSeleccionada.Cells[5].Value.ToString().Trim();
            frm.txtResume.Text = filaSeleccionada.Cells[6].Value.ToString().Trim();

            // Deshabilitar campos para ver detalles
            frm.txtTitulo.Enabled = false;
            frm.cbAutor.Enabled = false;
            frm.cbEditorial.Enabled = false;
            frm.cbCategoria.Enabled = false;
            frm.txtPublicacion.Enabled = false;
            frm.txtCantidad.Enabled = false;
            frm.txtResume.Enabled = false;
            frm.btnGuardarCampos.Enabled = false;
            frm.txtIsbn.Visible = false;
            frm.lbIsbn.Visible = false;
            
            frm.PortadaLibro();// Mostrar la portada del libro
            frm.ShowDialog();
        }
    }
}
