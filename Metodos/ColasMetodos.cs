using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSeries_DLL_JSVE.Clases;
using Microsoft.VisualBasic;

namespace ProyectoSeries_DLL_JSVE.Metodos
{
    public class ColasMetodos
    {
        private Nodo cabezaCola;
        private DataGridView GridCola;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtNroCapitulos;
        int id = 1;

        public ColasMetodos(DataGridView gridCola, TextBox txtNombre, TextBox txtDescripcion, TextBox txtNroCapitulos)
        {
            this.GridCola = gridCola;
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
                if (EncolarSerie(nuevaSerie))
                {
                    id++;
                    MostrarCola();
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

        private bool EncolarSerie(Serie nuevaSerie)
        {
            try
            {
                Nodo nuevoNodo = new Nodo(nuevaSerie);

                if (cabezaCola == null)
                {
                    cabezaCola = nuevoNodo;
                }
                else
                {
                    Nodo nodoActual = cabezaCola;
                    while (nodoActual.siguiente != null)
                    {
                        nodoActual = nodoActual.siguiente;
                    }

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

        private void MostrarCola()
        {
            GridCola.Rows.Clear();

            Nodo nodoActual = cabezaCola;
            while (nodoActual != null)
            {
                Serie serieActual = nodoActual.datos;
                GridCola.Rows.Add(serieActual.id, serieActual.nombre, serieActual.descripcion, serieActual.nroCapitulos);
                nodoActual = nodoActual.siguiente;
            }
        }

        ////////////////////////////////////////////Editar SERIES//////////////////////////////////////////////////////////
        public void EditarSerie()
        {
            string idInput = Interaction.InputBox("Ingrese la ID de la serie que quiera editar:", "Editar Serie", "");

            if (int.TryParse(idInput, out int idSeleccionado))
            {
                Serie serieOriginal = DesencolarSerie(idSeleccionado);

                if (serieOriginal != null)
                {
                    string nuevoNombre = ObtenerNuevoValor("Ingrese el nuevo nombre:", serieOriginal.nombre);
                    string nuevaDescripcion = ObtenerNuevoValor("Ingrese la nueva descripción:", serieOriginal.descripcion);

                    string nuevoNroCapitulosInput = ObtenerNuevoValor("Ingrese el nuevo número de capítulos:", serieOriginal.nroCapitulos.ToString());

                    if (int.TryParse(nuevoNroCapitulosInput, out int nuevoNroCapitulos))
                    {
                        Serie serieEditada = new Serie(idSeleccionado, nuevoNombre, nuevaDescripcion, nuevoNroCapitulos);

                        EncolarSerieEnLugarOriginal(serieEditada, idSeleccionado);

                        MostrarCola();
                        LimpiarTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el número de capítulos.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la serie en la cola.");
                }
            }
            else
            {
                MessageBox.Show("Id no encontrado.");
            }
        }

        private void EncolarSerieEnLugarOriginal(Serie serieEditada, int idOriginal)
        {
            try
            {
                Nodo nuevoNodo = new Nodo(serieEditada);

                if (cabezaCola == null)
                {
                    cabezaCola = nuevoNodo;
                }
                else
                {
                    Nodo nodoActual = cabezaCola;
                    Nodo nodoAnterior = null;

                    while (nodoActual != null && nodoActual.datos.id < idOriginal)
                    {
                        nodoAnterior = nodoActual;
                        nodoActual = nodoActual.siguiente;
                    }

                    if (nodoAnterior == null)
                    {
                        nuevoNodo.siguiente = cabezaCola;
                        cabezaCola = nuevoNodo;
                    }
                    else
                    {
                        nuevoNodo.siguiente = nodoActual;
                        nodoAnterior.siguiente = nuevoNodo;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al encolar la serie editada: {ex.Message}");
            }
        }

        private string ObtenerNuevoValor(string mensaje, string valorActual)
        {
            string nuevoValor = Interaction.InputBox(mensaje, "Editar Serie", valorActual);
            return nuevoValor;
        }

        private Serie DesencolarSerie(int id)
        {
            Nodo nodoActual = cabezaCola;
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
                    cabezaCola = nodoActual.siguiente;
                }
                else
                {
                    nodoAnterior.siguiente = nodoActual.siguiente;
                }

                return nodoActual.datos;
            }
            else
            {
                return null; // La serie no se encontró en la cola
            }
        }

        ////////////////////////////////////////////ELIMINAR SERIES//////////////////////////////////////////////////////////

        public void EliminarSerie()
        {
            if (cabezaCola != null)
            {
                Serie serieEliminar = cabezaCola.datos;
                cabezaCola = cabezaCola.siguiente;
                MostrarCola();
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
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
