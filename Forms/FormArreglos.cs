using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ProyectoSeries_DLL_JSVE.Metodos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoSeries_DLL_JSVE.Forms
{
    public partial class FormArreglos : Form
    {
        private ArreglosMetodos arreglosMetodos;
        public FormArreglos()
        {
            InitializeComponent();
            arreglosMetodos = new ArreglosMetodos(txtTamaño, GridArreglos);
        }
    
        private void btnIngresarArreglos_Click(object sender, EventArgs e)
        {
            arreglosMetodos.AgregarArreglos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            arreglosMetodos.EliminarArreglos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            arreglosMetodos.EditarSerie();
        }

        private void btnOrdenarCapitulos_Click(object sender, EventArgs e)
        {
            arreglosMetodos.OrdenarArreglo();
        }
    }
}
    

