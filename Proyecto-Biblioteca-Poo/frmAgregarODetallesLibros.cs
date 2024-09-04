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
        private csValidaciones validacion = new csValidaciones();
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
            csLibro libro = new csLibro();
            libro.HabilitarCampos(txtTitulo, txtAutores, cbEditorial, cbCategoria, txtPublicacion, txtCantidad, txtResume, btnGuardarCampos, btnCambiarImagen);
        }
        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {
            frmListaLibros frm = Owner as frmListaLibros;
            csLibro libro = new csLibro();
            if (txtIsbn.Text != "" | txtTitulo.Text != "" & txtAutores.Text != ""   & cbEditorial.Text != "" & cbCategoria.Text != "" & txtPublicacion.Text != "" & txtCantidad.Text != "" & txtResume.Text != "")
            {
                if (frm.validacion)
                {
                    libro.AgregarLibro(txtIsbn.Text,txtTitulo.Text, txtAutores.Text, cbEditorial.SelectedItem.ToString(), cbCategoria.SelectedItem.ToString(), txtPublicacion.Text, int.Parse(txtCantidad.Text), txtResume.Text, ptbxImagenLibro);
                    libro.MostrarLibros(frm.dgvLibros);
                    frm.validacion = false;
                }
                else
                {
                    libro.ModificarLibro(ISBN, txtTitulo.Text, txtAutores.Text, cbEditorial.SelectedItem.ToString(), cbCategoria.SelectedItem.ToString(), txtPublicacion.Text, int.Parse(txtCantidad.Text), txtResume.Text, ptbxImagenLibro);
                    libro.MostrarLibros(frm.dgvLibros);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos solicitados.");
            }
            if (frm.dgvLibros.RowCount > 0) { frm.dgvLibros.Rows.Clear(); }
            libro.MostrarLibros(frm.dgvLibros);
        }
        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            csLibro libro = new csLibro();
            libro.CambiarImagen(ptbxImagenLibro);
        }
        private void txtPublicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.ValidarSoloNumeros(e);
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.ValidarSoloNumeros(e);
        }
        public void MostrarLista()
        {
            cbCategoria = new csConexionSQL().LLenarLista(cbCategoria, "Select NombreGenero from Genero where Estado = '1'", "NombreGenero");
            cbEditorial = new csConexionSQL().LLenarLista(cbEditorial, "Select NombreEditorial from Editorial where Estado = '1'", "NombreEditorial");
        }
        private void frmAgregarODetallesLibros_Load(object sender, EventArgs e)
        {
            MostrarLista();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmSeleccionAutor frm = new frmSeleccionAutor();
            this.AddOwnedForm(frm);
            frm.ShowDialog();
        }
    }
}
