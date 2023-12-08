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
using ProyectoSeries_DLL_JSVE.Clases;
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
            arreglosMetodos.OrdenarArreglo(true);
        }

        private void btnOrdenar2_Click(object sender, EventArgs e)
        {
            arreglosMetodos.OrdenarArreglo(false);
        }
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            arreglosMetodos.EliminarTodasLasSeries();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreABuscar = Interaction.InputBox("Ingrese el nombre de la serie que quiere buscar", "Búsqueda por Nombre", "");

                Serie serieEncontrada = arreglosMetodos.BuscarSerie(nombreABuscar);

                if (serieEncontrada != null)
                {
                    MessageBox.Show($"Serie encontrada:\nID: {serieEncontrada.id}\nNombre: {serieEncontrada.nombre}\nDescripción: {serieEncontrada.descripcion}\nNúmero de Capítulos: {serieEncontrada.nroCapitulos}");
                }
                else
                {
                    MessageBox.Show("No se encontró la serie.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

