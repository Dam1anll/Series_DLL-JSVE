using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSeries_DLL_JSVE.Clases;

namespace ProyectoSeries_DLL_JSVE.Metodos
{
    public class ColasMetodos
    {
        private List<Serie> colaSeries; 
        private DataGridView GridColas;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtNroCapitulos;
        private int id = 1;

        public ColasMetodos(DataGridView gridListas, TextBox txtNombre, TextBox txtDescripcion, TextBox txtNroCapitulos)
        {
            this.GridColas = gridListas;
            this.txtNombre = txtNombre;
            this.txtDescripcion = txtDescripcion;
            this.txtNroCapitulos = txtNroCapitulos;

            this.colaSeries = new List<Serie>();
        }

        //Agregar Nueva Serie
        public void AgregarNuevaSerie()
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            if (int.TryParse(txtNroCapitulos.Text, out int nroCapitulos))
            {
                Serie nuevaSerie = CrearNuevaSerie(id, nombre, descripcion, nroCapitulos);
                AgregarSerieACola(nuevaSerie);
                id++;
                MostrarColas();
                LimpiarTextBoxes();
            }
            else
            {
                MessageBox.Show("Ingrese un número para los capítulos.");
            }
        }
        private Serie CrearNuevaSerie(int id, string nombre, string descripcion, int nroCapitulos)
        {
            return new Serie(id, nombre, descripcion, nroCapitulos);
        }

        private void AgregarSerieACola(Serie nuevaSerie)
        {
            colaSeries.Add(nuevaSerie);
        }

        //Eliminar Serie
        public void EliminarSerie()
        {
            if (colaSeries.Count > 0)
            {
                Serie serieEliminar = colaSeries[0];
                colaSeries.RemoveAt(0);
                MostrarColas();
                LimpiarTextBoxes();
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }

        //Ordenar Cola

        public void OrdenarColar() 
        {
            
        }

        //Editar Serie

        private void ActualizarDataGridView()
        {
            GridColas.Rows.Clear();

            foreach (Serie serie in colaSeries)
            {
                GridColas.Rows.Add(serie.id, serie.nombre, serie.descripcion, serie.nroCapitulos);
            }
        }

        //Otros Metodos
        private void MostrarColas()
        {
            GridColas.Rows.Clear();

            foreach (Serie serieActual in colaSeries)
            {
                GridColas.Rows.Add(serieActual.id, serieActual.nombre, serieActual.descripcion, serieActual.nroCapitulos);
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
