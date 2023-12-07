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
    public partial class FormColas : Form
    {
        private ColasMetodos colasMetodos;
        public FormColas()
        {
            InitializeComponent();
            colasMetodos = new ColasMetodos(GridColas, txtNombre, txtDescripcion, txtNroCapitulos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            colasMetodos.AgregarNuevaSerie();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            colasMetodos.EliminarSerie();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           colasMetodos.EditarSerie();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

        }
    }
}
