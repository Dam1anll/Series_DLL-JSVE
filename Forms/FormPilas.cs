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
    public partial class FormPilas : Form
    {
        private PilasMetodos pilasMetodos;
        public FormPilas()
        {
            InitializeComponent();
            pilasMetodos = new PilasMetodos(GridPilas, txtNombre, txtDescripcion, txtNroCapitulos);
        }

        private void btnAgregarCola_Click(object sender, EventArgs e)
        {
            pilasMetodos.AgregarNuevaSerie();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pilasMetodos.EditarSerie();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pilasMetodos.EliminarSerie();
        }
    }
}
