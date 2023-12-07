using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSeries_DLL_JSVE.Clases;
using ProyectoSeries_DLL_JSVE.Forms;
using Microsoft.VisualBasic;

namespace ProyectoSeries_DLL_JSVE.Metodos
{
    public class PilasMetodos
    {
        private Stack<Serie> pilaSeries;
        private DataGridView GridPilas;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtNroCapitulos;

        public PilasMetodos(DataGridView gridPilas, TextBox txtNombre, TextBox txtDescripcion, TextBox txtNroCapitulos)
        {
            this.GridPilas = gridPilas;
            this.txtNombre = txtNombre;
            this.txtDescripcion = txtDescripcion;
            this.txtNroCapitulos = txtNroCapitulos;

            pilaSeries = new Stack<Serie>();
        }

        //Agregar Serie

        int id = 1;
        public void AgregarNuevaSerie()
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            if (int.TryParse(txtNroCapitulos.Text, out int nroCapitulos))
            {
                Serie nuevaSerie = new Serie(id, nombre, descripcion, nroCapitulos);
                pilaSeries.Push(nuevaSerie);
                id++;
                MostrarPilas();
                LimpiarTextBoxes();
            }
            else
            {
                MessageBox.Show("Ingrese un número para los capitulos.");
            }
        }

        private void MostrarPilas()
        {
            GridPilas.Rows.Clear();

            foreach (Serie serieActual in pilaSeries)
            {
                GridPilas.Rows.Add(serieActual.id, serieActual.nombre, serieActual.descripcion, serieActual.nroCapitulos);
            }
        }

        private void LimpiarTextBoxes()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNroCapitulos.Text = string.Empty;
        }

        //Editar Serie
        public void EditarSerie()
        {
            if (GridPilas.SelectedRows.Count > 0)
            {
                int selectedRowIndex = GridPilas.SelectedRows[0].Index;
                Serie serieActual = pilaSeries.ElementAt(selectedRowIndex); // Obtener la serie seleccionada

                string nuevoNombre = ObtenerNuevoValor("Ingrese el nuevo nombre:", serieActual.nombre);
                string nuevaDescripcion = ObtenerNuevoValor("Ingrese la nueva descripción:", serieActual.descripcion);

                string nuevoNroCapitulosInput = ObtenerNuevoValor("Ingrese el nuevo número de capítulos:", serieActual.nroCapitulos.ToString());

                if (int.TryParse(nuevoNroCapitulosInput, out int nuevoNroCapitulos))
                {
                    // Remover la serie actual de la pila

                    // Actualizar los valores de la serie
                    serieActual.nombre = nuevoNombre;
                    serieActual.descripcion = nuevaDescripcion;
                    serieActual.nroCapitulos = nuevoNroCapitulos;

                    // Volver a agregar la serie actual al final de la pila
                    pilaSeries.Push(serieActual);

                    MostrarPilas();
                    LimpiarTextBoxes();
                }
                else
                {
                    MessageBox.Show("Ingrese el número de capítulos.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.");
            }
        }



        private string ObtenerNuevoValor(string mensaje, string valorActual)
        {
            string nuevoValor = Interaction.InputBox(mensaje, "Editar Serie", valorActual);
            return nuevoValor;
        }

        //Eliminar Serie
        public void EliminarSerie()
        {
            if (pilaSeries.Count > 0)
            {
                pilaSeries.Pop();
                MostrarPilas();
                LimpiarTextBoxes();
            }
            else
            {
                MessageBox.Show("La pila está vacía, no hay elementos para eliminar.");
            }
        }
    }
}
