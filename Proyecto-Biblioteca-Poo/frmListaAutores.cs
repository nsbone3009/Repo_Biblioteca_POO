﻿using System;
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
    public partial class frmListaAutores : Form
    {
        public frmListaAutores()
        {
            InitializeComponent();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesAutores frm = new frmAgregarODetallesAutores();
            this.AddOwnedForm(frm);
            frm.lbTituloVentana.Text = "AGREGAR AUTOR";
            frm.ShowDialog();
        }
    }
}
