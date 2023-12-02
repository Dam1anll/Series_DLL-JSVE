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
        private Nodo cabezaPila;
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
        }

        //Metodos

        public void AgregarPila() 
        {
            
        }
    }
}
