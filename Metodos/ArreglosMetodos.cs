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
        private List<Serie> series;
        private TextBox txtTamaño;
        private DataGridView GridArreglos;

        public ArreglosMetodos(TextBox txtTamaño, DataGridView gridArreglos)
        {
            this.txtTamaño = txtTamaño;
            this.GridArreglos = gridArreglos;
        }

        // Agregar Serie
        public void AgregarArreglos()
        {
            try
            {
                if (int.TryParse(txtTamaño.Text, out int newSize))
                {
                    int ultimaIdExistente = series.Count > 0 ? series.Max(s => s.id) : 0;

                    for (int x = 0; x < newSize; x++)
                    {
                        int id = ultimaIdExistente + x + 1;
                        string nombre = Interaction.InputBox("Escribe el nombre de la serie");
                        string descripcion = Interaction.InputBox("Escribe una descripción sobre la serie");
                        int nroCapitulos = Convert.ToInt32(Interaction.InputBox("Escribe la cantidad de capítulos de la serie"));

                        series.Add(new Serie(id, nombre, descripcion, nroCapitulos));
                    }

                    ActualizarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Eliminar Serie
        public void EliminarArreglos()
        {
            try
            {
                if (series.Count > 0)
                {
                    int idEliminar = Convert.ToInt32(Interaction.InputBox("Ingrese el id del arreglo a eliminar"));

                    Serie serieEliminar = series.Find(serie => serie.id == idEliminar);

                    if (serieEliminar != null)
                    {
                        series.Remove(serieEliminar);
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
                    MessageBox.Show("No hay Series para eliminar.");
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

            foreach (Serie serie in series)
            {
                GridArreglos.Rows.Add(serie.id, serie.nombre, serie.descripcion, serie.nroCapitulos);
            }
        }


        //Editar Serie
        public void EditarSerie()
        {
            try
            {
                int idSerieEditar = Convert.ToInt32(Interaction.InputBox("Ingrese el ID de la serie que quiera editar:", "Edición", ""));

                Serie serieEditar = null;

                foreach (Serie serie in series)
                {
                    if (serie.id == idSerieEditar)
                    {
                        serieEditar = serie;
                        break;
                    }
                }

                if (serieEditar != null)
                {
                    string nuevoNombre = Interaction.InputBox("Edita el nombre de la serie", "Edición", serieEditar.nombre);
                    string nuevaDescripcion = Interaction.InputBox("Edita la descripción de la serie", "Edición", serieEditar.descripcion);
                    int nuevosCapitulos = Convert.ToInt32(Interaction.InputBox("Edita la cantidad de capítulos de la serie", "Edición", serieEditar.nroCapitulos.ToString()));

                    serieEditar.nombre = nuevoNombre;
                    serieEditar.descripcion = nuevaDescripcion;
                    serieEditar.nroCapitulos = nuevosCapitulos;

                    foreach (DataGridViewRow row in GridArreglos.Rows)
                    {
                        if ((int)row.Cells["IdSerie"].Value == idSerieEditar)
                        {
                            row.Cells["NombreSerie"].Value = nuevoNombre;
                            row.Cells["DescripcionSerie"].Value = nuevaDescripcion;
                            row.Cells["NroCapitulosSerie"].Value = nuevosCapitulos;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar la serie con el ID proporcionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Ordenar Arreglos
        public void OrdenarArreglo()
        {
            try
            {
                if (series.Count > 0)
                {
                    for (int x = 0; x < series.Count; x++)
                    {
                        int minimo = x;

                        for (int y = x + 1; y < series.Count; y++)
                        {
                            if (series[y].nroCapitulos < series[minimo].nroCapitulos)
                            {
                                minimo = y;
                            }
                        }

                        Serie temp = series[x];
                        series[x] = series[minimo];
                        series[minimo] = temp;
                    }

                    ActualizarGrid();

                    MessageBox.Show("Arreglos ordenados");
                }
                else
                {
                    MessageBox.Show("No hay arreglos para ordenar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
