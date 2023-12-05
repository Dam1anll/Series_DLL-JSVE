using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ProyectoSeries_DLL_JSVE.Clases;
using ProyectoSeries_DLL_JSVE.Forms;

namespace ProyectoSeries_DLL_JSVE.Metodos
{
    public class ListasMetodos
    {
        private Nodo cabezaLista;
        private DataGridView GridListas;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtNroCapitulos;
        int id = 1;

        public ListasMetodos(DataGridView gridListas, TextBox txtNombre, TextBox txtDescripcion, TextBox txtNroCapitulos)
        {
            this.GridListas = gridListas;
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
                if (AgregarSerie(nuevaSerie))
                {
                    id++; 
                    MostrarListas();
                    LimpiarTextBoxes();
                }
                else
                {
                    MessageBox.Show("Error al agregar la serie.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número para los capitulos.");
            }
        }
        private bool AgregarSerie(Serie nuevaSerie)
        {
            try
            {
                Nodo nuevoNodo = new Nodo(nuevaSerie);

                if (cabezaLista == null)
                {
                    cabezaLista = nuevoNodo;
                }
                else
                {
                    Nodo nodoActual = cabezaLista;
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
        private void MostrarListas()
        {
            GridListas.Rows.Clear();

            Nodo nodoActual = cabezaLista;
            while (nodoActual != null)
            {
                Serie serieActual = nodoActual.datos;
                GridListas.Rows.Add(serieActual.id ,serieActual.nombre, serieActual.descripcion, serieActual.nroCapitulos);
                nodoActual = nodoActual.siguiente;
            }
        }
        private void LimpiarTextBoxes()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNroCapitulos.Text = string.Empty;
        }

        ////////////////////////////////////////////EDITAR SERIES//////////////////////////////////////////////////////////
  
        public void EditarSerie()
        {
            string idInput = Interaction.InputBox("Ingrese la ID de la serie que quiera editar:", "Editar Serie", "");

            if (int.TryParse(idInput, out int idSeleccionado))
            {
                Nodo nodoActual = cabezaLista;
                while (nodoActual != null && nodoActual.datos.id != idSeleccionado)
                {
                    nodoActual = nodoActual.siguiente;
                }

                if (nodoActual != null)
                {
                    string nuevoNombre = ObtenerNuevoValor("Ingrese el nuevo nombre:", nodoActual.datos.nombre);
                    string nuevaDescripcion = ObtenerNuevoValor("Ingrese la nueva descripción:", nodoActual.datos.descripcion);

                    string nuevoNroCapitulosInput = ObtenerNuevoValor("Ingrese el nuevo número de capítulos:", nodoActual.datos.nroCapitulos.ToString());

                    if (int.TryParse(nuevoNroCapitulosInput, out int nuevoNroCapitulos))
                    {
                        nodoActual.datos.nombre = nuevoNombre;
                        nodoActual.datos.descripcion = nuevaDescripcion;
                        nodoActual.datos.nroCapitulos = nuevoNroCapitulos;

                        MostrarListas();
                        LimpiarTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el número de capítulos.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la serie en la lista enlazada.");
                }
            }
            else
            {
                MessageBox.Show("Id no encontrado.");
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
            string idInput = Interaction.InputBox("Ingrese la ID de la serie que quiera eliminar:", "Eliminar Serie", "");

            if (int.TryParse(idInput, out int idEliminar))
            {
                Nodo nodoActual = cabezaLista;
                Nodo nodoAnterior = null;

                while (nodoActual != null && nodoActual.datos.id != idEliminar)
                {
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.siguiente;
                }

                if (nodoActual != null)
                {
                    if (nodoAnterior == null)
                    {
                        cabezaLista = nodoActual.siguiente;
                    }
                    else
                    {
                        nodoAnterior.siguiente = nodoActual.siguiente;
                    }

                    MostrarListas();
                    LimpiarTextBoxes();
                }
                else
                {
                    MessageBox.Show("No se encontró el Id de la serie.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una ID válido.");
            }
        }

        ////////////////////////////////////////////ORDENARAR SERIES//////////////////////////////////////////////////////////
        public void Ordenar()
        {
            if (cabezaLista != null && cabezaLista.siguiente != null)
            {
                Nodo actual = cabezaLista;

                while (actual != null)
                {
                    Nodo minimo = EncontrarNodo(actual);

                    Serie temp = actual.datos;
                    actual.datos = minimo.datos;
                    minimo.datos = temp;

                    actual = actual.siguiente;
                }

                MostrarListas();
            }
            else
            {
                MessageBox.Show("La lista está vacía o solo contiene un elemento, no es necesario ordenar.");
            }
        }
        private Nodo EncontrarNodo(Nodo inicio)
        {
            Nodo minimo = inicio;
            Nodo actual = inicio.siguiente;

            while (actual != null)
            {
                if (actual.datos.nroCapitulos < minimo.datos.nroCapitulos)
                {
                    minimo = actual;
                }

                actual = actual.siguiente;
            }

            return minimo;
        }
    }
}



