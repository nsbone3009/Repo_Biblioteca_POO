using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_Biblioteca_Poo
{
    class csAjustarDataGridView
    {
        public DataGridView Ajustar(DataGridView tabla, string consulta)
        {
            int f = 0;
            DataTable contenedor = new csConexionSQL().MostrarRegistros(consulta);
            foreach (DataRow row in contenedor.Rows)
            {
                tabla.Rows.Add(row.ItemArray);
                tabla.Rows[f++].Height = 50;
            }
            for (int i = 0; i < tabla.ColumnCount; i++)
            {
                tabla.Columns[i].Width = tabla.Width / tabla.ColumnCount - 1;
                tabla.Columns[i].Resizable = DataGridViewTriState.False;
            }
            return tabla;
        }
    }
}
