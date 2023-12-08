using Microsoft.VisualBasic;
using ProyectoSeries_DLL_JSVE.Clases;
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
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            listasMetodos.EliminarTodasLasSeries();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            listasMetodos.EditarSerie();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listasMetodos.OrdenarAscendente();
        }

        private void btnOrdenar2_Click(object sender, EventArgs e)
        {
            listasMetodos.OrdenarDescendente();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreABuscar = Interaction.InputBox("Ingrese el nombre de la serie que quiere buscar", "Búsqueda por Nombre", "");

                Serie serieEncontrada = listasMetodos.BuscarSerie(nombreABuscar);

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
