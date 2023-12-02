using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using ProyectoSeries_DLL_JSVE.Clases;
using ProyectoSeries_DLL_JSVE.Forms;

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
            this.series = new List<Serie>();
        }

        // Agregar Arreglos
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

        // Eliminar Arreglos
        public void EliminarArreglos()
        {
            try
            {
                if (series.Count > 0)
                {
                    int idEliminar = Convert.ToInt32(Interaction.InputBox("Ingrese el id del arreglo a eliminar"));

                    Serie serieEliminar = series.Find(s => s.id == idEliminar);

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


        //Editar Arreglos
        public void EditarSerie()
        {
            try
            {
                int idSerieEditar = Convert.ToInt32(Interaction.InputBox("Ingrese el ID de la serie que quiera editar:", "Edición", ""));

                Serie serieEditar = null;

                foreach (Serie s in series)
                {
                    if (s.id == idSerieEditar)
                    {
                        serieEditar = s;
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
                    for (int i = 0; i < series.Count; i++)
                    {
                        int minimo = i;

                        for (int j = i + 1; j < series.Count; j++)
                        {
                            if (series[j].nroCapitulos < series[minimo].nroCapitulos)
                            {
                                minimo = j;
                            }
                        }

                        Serie temp = series[i];
                        series[i] = series[minimo];
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
