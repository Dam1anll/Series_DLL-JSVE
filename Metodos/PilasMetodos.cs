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
        private Nodo topePila;
        private DataGridView GridPila;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtNroCapitulos;
        int id = 1;

        public PilasMetodos(DataGridView gridPila, TextBox txtNombre, TextBox txtDescripcion, TextBox txtNroCapitulos)
        {
            this.GridPila = gridPila;
            this.txtNombre = txtNombre;
            this.txtDescripcion = txtDescripcion;
            this.txtNroCapitulos = txtNroCapitulos;
        }

        ////////////////////////////////////////////AGREGAR SERIES//////////////////////////////////////////////////////////

        public void AgregarNuevaSerie()
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            if (int.TryParse(txtNroCapitulos.Text, out int nroCapitulos))
            {
                Serie nuevaSerie = new Serie(id, nombre, descripcion, nroCapitulos);
                if (ApilarSerie(nuevaSerie))
                {
                    id++;
                    MostrarPila();
                    LimpiarTextBoxes();
                }
                else
                {
                    MessageBox.Show("Error al agregar la serie.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número para los capítulos.");
            }
        }

        private bool ApilarSerie(Serie nuevaSerie)
        {
            try
            {
                Nodo nuevoNodo = new Nodo(nuevaSerie);

                if (topePila == null || nuevaSerie.id > topePila.datos.id)
                {
                    nuevoNodo.siguiente = topePila;
                    topePila = nuevoNodo;
                }
                else
                {
                    Nodo nodoActual = topePila;

                    while (nodoActual.siguiente != null && nuevaSerie.id < nodoActual.siguiente.datos.id)
                    {
                        nodoActual = nodoActual.siguiente;
                    }

                    nuevoNodo.siguiente = nodoActual.siguiente;
                    nodoActual.siguiente = nuevoNodo;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la serie: {ex.Message}");
                return false;
            }
        }

        private void MostrarPila()
        {
            GridPila.Rows.Clear();

            Nodo nodoActual = topePila;
            while (nodoActual != null)
            {
                Serie serieActual = nodoActual.datos;
                GridPila.Rows.Add(serieActual.id, serieActual.nombre, serieActual.descripcion, serieActual.nroCapitulos);
                nodoActual = nodoActual.siguiente;
            }
        }

        ////////////////////////////////////////////Editar SERIES//////////////////////////////////////////////////////////
        public void EditarSerie()
        {
            string idInput = Interaction.InputBox("Ingrese la ID de la serie que quiera editar:", "Editar Serie", "");

            if (int.TryParse(idInput, out int idSeleccionado))
            {
                Serie serieOriginal = DesapilarSerie(idSeleccionado);

                if (serieOriginal != null)
                {
                    string nuevoNombre = ObtenerNuevoValor("Ingrese el nuevo nombre:", serieOriginal.nombre);
                    string nuevaDescripcion = ObtenerNuevoValor("Ingrese la nueva descripción:", serieOriginal.descripcion);

                    string nuevoNroCapitulosInput = ObtenerNuevoValor("Ingrese el nuevo número de capítulos:", serieOriginal.nroCapitulos.ToString());

                    if (int.TryParse(nuevoNroCapitulosInput, out int nuevoNroCapitulos))
                    {
                        Serie serieEditada = new Serie(idSeleccionado, nuevoNombre, nuevaDescripcion, nuevoNroCapitulos);

                        ApilarSerie(serieEditada);

                        MostrarPila();
                        LimpiarTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el número de capítulos.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la serie en la pila.");
                }
            }
            else
            {
                MessageBox.Show("Id no encontrado.");
            }
        }

        private Serie DesapilarSerie(int id)
        {
            Nodo nodoActual = topePila;
            Nodo nodoAnterior = null;

            while (nodoActual != null && nodoActual.datos.id != id)
            {
                nodoAnterior = nodoActual;
                nodoActual = nodoActual.siguiente;
            }

            if (nodoActual != null)
            {
                if (nodoAnterior == null)
                {
                    topePila = nodoActual.siguiente;
                }
                else
                {
                    nodoAnterior.siguiente = nodoActual.siguiente;
                }

                return nodoActual.datos;
            }
            else
            {
                return null;
            }
        }

        private string ObtenerNuevoValor(string mensaje, string valorActual)
        {
            string nuevoValor = Interaction.InputBox(mensaje, "Editar Serie", valorActual);
            return nuevoValor;
        }

        ////////////////////////////////////////////ELIMINAR SERIES//////////////////////////////////////////////////////////

        public void EliminarSerie()
        {
            if (topePila != null)
            {
                Serie serieEliminar = topePila.datos;
                topePila = topePila.siguiente;
                MostrarPila();
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void LimpiarTextBoxes()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNroCapitulos.Text = string.Empty;
        }
    }
}
