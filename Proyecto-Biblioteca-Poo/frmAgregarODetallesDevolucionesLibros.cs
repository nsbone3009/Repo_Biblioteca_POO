﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proyecto_Biblioteca_Poo
{
    public partial class frmAgregarODetallesDevolucionesLibros : Form
    {
        static csConexionSQL obj = new csConexionSQL();
        static Random rnd = new Random(DateTime.Now.Millisecond);
        public frmAgregarODetallesDevolucionesLibros()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmListaPrestamosLibros frmLibros = new frmListaPrestamosLibros();
            this.AddOwnedForm(frmLibros);
            frmLibros.btnAgregarPrestamo.Visible = false;
            frmLibros.bandera = true;
            frmLibros.ShowDialog();
        }
        private void btnDevolverLibros_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text != "")
            {
                int a = rnd.Next(100000, 1000000);
                obj.Update("insert into Devoluciones(id_dl, cedula_ltr,isbn_lb,fecha_prestamo,fecha_devolucion_programada,fecha_devolucion) values ('" + a + "', '" + txtCedula.Text.Trim() + "', '" + txtISBN.Text.Trim() + "', '" + txtFechaPrestamo.Text.Trim() + "', '" + txtFechaDevolucion.Text.Trim() + "', '" + txtFechaActual.Text.Trim() + "')");
                obj.Update("insert into Movimientos(id_mvt, cedula_usr, isbn_lb, fecha_mvt, hora_mvt, descipcion_mvt) values ('" + a + "','" + 67890123 + "','" + txtISBN.Text.Trim() + "','" + txtFechaActual.Text.Trim() + "','" + DateTime.Now.ToString("HH:mm:ss") + "','" + "Se devolvió un libro" + "')");
                obj.Update("update Prestamos set estado_ = 0 where isbn_lb =  '" + txtISBN.Text.Trim() + "'");
                ObtenerDato("select cantidad_lb from Libros where isbn_lb =  '" + txtISBN.Text.Trim() + "'", txtISBN.Text.Trim());
                MessageBox.Show("Libro devuelto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListaDevolucionesLibros devoluciones = Owner as frmListaDevolucionesLibros;
                devoluciones.dgvDevoluciones.Rows.Clear();
                devoluciones.CargarDatos();
                this.Close();
            }
            else
                MessageBox.Show("Primero seleccione un libro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ObtenerDato(string consulta, string isbn)
        {
                int a = 0;
            obj.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, obj.Conexion);
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
                a = leer.GetInt32(0);
            a += 1;
            obj.CerrarConexion();
            obj.Update("update Libros set cantidad_lb='" + a + "' where isbn_lb =  '" + isbn.Trim() + "'");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
