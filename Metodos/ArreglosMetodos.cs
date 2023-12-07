using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using ProyectoSeries_DLL_JSVE.Clases;
using ProyectoSeries_DLL_JSVE.Forms;
using System.Collections;

namespace ProyectoSeries_DLL_JSVE.Metodos
{
    public class ArreglosMetodos
    {
        private Serie[] seriesArreglo;
        private TextBox txtTamaño;
        private DataGridView GridArreglos;

        public ArreglosMetodos(TextBox txtTamaño, DataGridView gridArreglos)
        {
            this.txtTamaño = txtTamaño;
            this.GridArreglos = gridArreglos;
            this.seriesArreglo = null;
        }

        ////////////////////////////////////////////AGREGAR SERIE//////////////////////////////////////////////////////////
        public void AgregarArreglos()
        {
            try
            {
                if (int.TryParse(txtTamaño.Text, out int newSize))
                {
                    int ultimaIdExistente = (seriesArreglo != null && seriesArreglo.Length > 0) ? seriesArreglo.Max(s => s.id) : 0;

                    Serie[] newArray = new Serie[(seriesArreglo != null ? seriesArreglo.Length : 0) + newSize];

                    if (seriesArreglo != null)
                    {
                        seriesArreglo.CopyTo(newArray, 0);
                    }

                    for (int x = 0; x < newSize; x++)
                    {
                        int id = ultimaIdExistente + x + 1;
                        string nombre = Interaction.InputBox("Escribe el nombre de la serie");
                        string descripcion = Interaction.InputBox("Escribe una descripción sobre la serie");
                        int nroCapitulos;

                        while (!int.TryParse(Interaction.InputBox("Escribe la cantidad de capítulos de la serie"), out nroCapitulos))
                        {
                            MessageBox.Show("Por favor, ingrese un número válido para la cantidad de capítulos.");
                        }

                        newArray[newArray.Length - newSize + x] = new Serie(id, nombre, descripcion, nroCapitulos);
                    }

                    seriesArreglo = newArray;

                    ActualizarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ////////////////////////////////////////////ELIMINAR SERIE//////////////////////////////////////////////////////////
        public void EliminarArreglos()
        {
            try
            {
                if (seriesArreglo != null && seriesArreglo.Length > 0)
                {
                    int idEliminar;

                    while (!int.TryParse(Interaction.InputBox("Ingrese el id del arreglo a eliminar"), out idEliminar))
                    {
                        MessageBox.Show("Por favor, ingrese una ID valida.");
                    }

                    int index = Array.FindIndex(seriesArreglo, serie => serie != null && serie.id == idEliminar);

                    if (index != -1)
                    {
                        seriesArreglo[index] = null;
                        ActualizarGrid();
                        MessageBox.Show("Serie eliminada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("ID no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay Serie para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarGrid()
        {
            GridArreglos.Rows.Clear();

            foreach (Serie serie in seriesArreglo)
            {
                if (serie != null)
                {
                    GridArreglos.Rows.Add(serie.id, serie.nombre, serie.descripcion, serie.nroCapitulos);
                }
            }
        }

        ////////////////////////////////////////////EDITAR SERIE//////////////////////////////////////////////////////////
        public void EditarSerie()
        {
            try
            {
                if (seriesArreglo != null && seriesArreglo.Length > 0)
                {
                    int idSerieEditar;

                    while (!int.TryParse(Interaction.InputBox("Ingrese el ID de la serie que quiera editar:", "Edición", ""), out idSerieEditar))
                    {
                        MessageBox.Show("Por favor, ingrese un número válido para el ID.");
                    }

                    int index = Array.FindIndex(seriesArreglo, serie => serie != null && serie.id == idSerieEditar);

                    if (index != -1)
                    {
                        string nuevoNombre = Interaction.InputBox("Edita el nombre de la serie", "Edición", seriesArreglo[index].nombre);
                        string nuevaDescripcion = Interaction.InputBox("Edita la descripción de la serie", "Edición", seriesArreglo[index].descripcion);
                        int nuevosCapitulos;

                        while (!int.TryParse(Interaction.InputBox("Edita la cantidad de capítulos de la serie", "Edición", seriesArreglo[index].nroCapitulos.ToString()), out nuevosCapitulos))
                        {
                            MessageBox.Show("Por favor, ingrese un número válido para la cantidad de capítulos.");
                        }

                        seriesArreglo[index].nombre = nuevoNombre;
                        seriesArreglo[index].descripcion = nuevaDescripcion;
                        seriesArreglo[index].nroCapitulos = nuevosCapitulos;

                        ActualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar la serie con el ID proporcionado.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay Serie para editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ////////////////////////////////////////////ORDENARAR SERIES//////////////////////////////////////////////////////////
        public void OrdenarArreglo()
        {
            try
            {
                if (seriesArreglo != null && seriesArreglo.Length > 0)
                {
                    OrdenarPorSeleccion();
                    ActualizarGrid();
                }
                else
                {
                    MessageBox.Show("No hay serie para ordenar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrdenarPorSeleccion()
        {
            int n = seriesArreglo.Length;

            for (int i = 0; i < seriesArreglo.Length - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {

                    if (seriesArreglo[j]?.nroCapitulos < seriesArreglo[i]?.nroCapitulos)
                    {
                        Serie temp = seriesArreglo[j];
                        seriesArreglo[j] = seriesArreglo[i];
                        seriesArreglo[i] = temp;
                    }
                }
            }
        }
    }
}
