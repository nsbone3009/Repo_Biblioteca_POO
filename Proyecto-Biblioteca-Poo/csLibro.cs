using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_Biblioteca_Poo
{
    internal class csLibro
    {
        public string ISBN { get; set; }
        private csConexionSQL conexion;
        public csLibro()
        {
            conexion = new csConexionSQL();
        }
        public void MostrarLibros(DataGridView dgvLibros)
        {
            string consulta = "Select L.titulo_lb, E.NombreEditorial, G.NombreGenero, L.año_publicacion_lb, L.cantidad_lb, L.sinopsis_lb " +
            "from Libros L " +
            "join Editorial E on E.idEditorial = L.IdEditorial "+
            "join Genero G on G.idGenero = L.IdGenero ";
            int f = 0, v = 0;
            DataTable contenedor = new csConexionSQL().MostrarRegistros(consulta);
            foreach (DataRow row in contenedor.Rows)
            {
                dgvLibros.Rows.Add();
                object[] vector = row.ItemArray;
                for (int i = 0; i < dgvLibros.ColumnCount; i++)
                {
                    dgvLibros.Columns[i].Width = dgvLibros.Width / dgvLibros.ColumnCount;
                    dgvLibros.Columns[i].Resizable = DataGridViewTriState.False;
                    if (i != 1)
                    {
                        dgvLibros.Rows[f].Cells[i].Value = vector[v++].ToString();
                    }
                    else
                    {
                        string autoresLibros = "";
                        string isbn = new csConexionSQL().Extraer("Select * from Libros where titulo_lb = '" + vector[0] + "'", "isbn_lb");
                        string[] autores = new csConexionSQL().ExtraerAutores("Select * from Autores_Libros where isbn_lb = '" + isbn + "'", "idAutor").Split(';');
                        foreach (string autor in autores)
                        {
                            autoresLibros += new csConexionSQL().Extraer("Select * from Autores where idAutor = '" + autor + "'", "NombreAutor") + ", ";
                        }
                        dgvLibros.Rows[f].Cells[i].Value = autoresLibros;
                    }
                }
                v = 0;
                dgvLibros.Rows[f++].Height = 50;
            }
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
        public void HabilitarCampos(TextBox txtTitulo, TextBox txtAutores, ComboBox cbEditorial, ComboBox cbCategoria,TextBox txtPublicacion, TextBox txtCantidad, TextBox txtResume, Button btnGuardarCampos, Button btnCambiarImagen)
        {
            txtTitulo.Enabled = true;
            txtAutores.Enabled = true;
            cbEditorial.Enabled = true;
            cbCategoria.Enabled = true;
            txtPublicacion.Enabled = true;
            txtCantidad.Enabled = true;
            txtResume.Enabled = true;
            btnGuardarCampos.Enabled = true;
            btnCambiarImagen.Enabled = true;
        }
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
            frm.txtAutores.Text = filaSeleccionada.Cells[1].Value.ToString().Trim();
            frm.cbEditorial.SelectedItem = filaSeleccionada.Cells[2].Value.ToString().Trim();
            frm.cbCategoria.SelectedItem = filaSeleccionada.Cells[3].Value.ToString().Trim();
            frm.txtPublicacion.Text = filaSeleccionada.Cells[4].Value.ToString().Trim();
            frm.txtCantidad.Text = filaSeleccionada.Cells[5].Value.ToString().Trim();
            frm.txtResume.Text = filaSeleccionada.Cells[6].Value.ToString().Trim();

            // Deshabilitar campos para ver detalles
            frm.txtTitulo.Enabled = false;
            frm.txtAutores.Enabled = false;
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
