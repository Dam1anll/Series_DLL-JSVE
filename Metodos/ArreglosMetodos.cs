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
        private Serie[] seriesArray;
        private TextBox txtTamaño;
        private DataGridView GridArreglos;

        public ArreglosMetodos(TextBox txtTamaño, DataGridView gridArreglos)
        {
            this.txtTamaño = txtTamaño;
            this.GridArreglos = gridArreglos;
            this.seriesArray = null;
        }

        // Agregar Serie
        public void AgregarArreglos()
        {
            try
            {
                if (int.TryParse(txtTamaño.Text, out int newSize))
                {
                    int ultimaIdExistente = (seriesArray != null && seriesArray.Length > 0) ? seriesArray.Max(s => s.id) : 0;

                    seriesArray = new Serie[newSize];

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

                        seriesArray[x] = new Serie(id, nombre, descripcion, nroCapitulos);
                    }

                    ActualizarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarArreglos()
        {
            try
            {
                if (seriesArray != null && seriesArray.Length > 0)
                {
                    int idEliminar;

                    while (!int.TryParse(Interaction.InputBox("Ingrese el id del arreglo a eliminar"), out idEliminar))
                    {
                        MessageBox.Show("Por favor, ingrese un número válido para el ID.");
                    }

                    int index = Array.FindIndex(seriesArray, s => s != null && s.id == idEliminar);

                    if (index != -1)
                    {
                        seriesArray[index] = null;
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

            foreach (Serie serie in seriesArray)
            {
                if (serie != null)
                {
                    GridArreglos.Rows.Add(serie.id, serie.nombre, serie.descripcion, serie.nroCapitulos);
                }
            }
        }

        // Editar Serie
        public void EditarSerie()
        {
            try
            {
                if (seriesArray != null && seriesArray.Length > 0)
                {
                    int idSerieEditar;

                    while (!int.TryParse(Interaction.InputBox("Ingrese el ID de la serie que quiera editar:", "Edición", ""), out idSerieEditar))
                    {
                        MessageBox.Show("Por favor, ingrese un número válido para el ID.");
                    }

                    int index = Array.FindIndex(seriesArray, s => s != null && s.id == idSerieEditar);

                    if (index != -1)
                    {
                        string nuevoNombre = Interaction.InputBox("Edita el nombre de la serie", "Edición", seriesArray[index].nombre);
                        string nuevaDescripcion = Interaction.InputBox("Edita la descripción de la serie", "Edición", seriesArray[index].descripcion);
                        int nuevosCapitulos;

                        while (!int.TryParse(Interaction.InputBox("Edita la cantidad de capítulos de la serie", "Edición", seriesArray[index].nroCapitulos.ToString()), out nuevosCapitulos))
                        {
                            MessageBox.Show("Por favor, ingrese un número válido para la cantidad de capítulos.");
                        }

                        seriesArray[index].nombre = nuevoNombre;
                        seriesArray[index].descripcion = nuevaDescripcion;
                        seriesArray[index].nroCapitulos = nuevosCapitulos;

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

        // Ordenar Arreglos
        public void OrdenarArreglo()
        {
            try
            {
                if (seriesArray != null && seriesArray.Length > 0)
                {
                    // Puedes implementar la lógica de ordenación aquí si fuera necesario.
                    MessageBox.Show("La serie se ordena por defecto ya que solo hay una serie.");
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
    }
}
