using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeries_DLL_JSVE.Clases
{
    public class Nodo
    {
        public Serie datos { get; set; }
        public Nodo siguiente { get; set; }

        public Nodo(Serie serie)
        {
            datos = serie;
            siguiente = null;
        }
    }
}
