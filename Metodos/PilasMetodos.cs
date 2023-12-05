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
        private Serie serieActual;
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

            serieActual = null;
        }

        //Agregar asdasdas


        //Agregar Serie

        int id = 1;
        public void AgregarNuevaSerie()
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            if (int.TryParse(txtNroCapitulos.Text, out int nroCapitulos))
            {
                Serie nuevaSerie = new Serie(id, nombre, descripcion, nroCapitulos);
                serieActual = nuevaSerie;
                id++;
                MostrarPilas();
                LimpiarTextBoxes();
            }
            else
            {
                MessageBox.Show("Ingrese un número para los capítulos.");
            }
        }

        private void MostrarPilas()
        {
            GridPilas.Rows.Clear();

            if (serieActual != null)
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
            if (serieActual != null)
            {
                string nuevoNombre = ObtenerNuevoValor("Ingrese el nuevo nombre:", serieActual.nombre);
                string nuevaDescripcion = ObtenerNuevoValor("Ingrese la nueva descripción:", serieActual.descripcion);

                string nuevoNroCapitulosInput = ObtenerNuevoValor("Ingrese el nuevo número de capítulos:", serieActual.nroCapitulos.ToString());

                if (int.TryParse(nuevoNroCapitulosInput, out int nuevoNroCapitulos))
                {
                    serieActual.nombre = nuevoNombre;
                    serieActual.descripcion = nuevaDescripcion;
                    serieActual.nroCapitulos = nuevoNroCapitulos;

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
                MessageBox.Show("No hay serie para editar.");
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
            if (serieActual != null)
            {
                serieActual = null;
                MostrarPilas();
                LimpiarTextBoxes();
            }
            else
            {
                MessageBox.Show("No hay serie para eliminar.");
            }
        }
    }
}
