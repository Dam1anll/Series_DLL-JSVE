using ProyectoSeries_DLL_JSVE.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSeries_DLL_JSVE.Forms
{
    public partial class FormListas : Form
    {
        private ListasMetodos listasMetodos;
        public FormListas()
        {
            InitializeComponent();
            listasMetodos = new ListasMetodos(GridListas, txtNombre, txtDescripcion, txtNroCapitulos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listasMetodos.AgregarNuevaSerie();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listasMetodos.EliminarSerie();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            listasMetodos.EditarSerie();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listasMetodos.Ordenar();
        }
    }
}
