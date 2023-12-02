using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeries_DLL_JSVE.Clases
{
    public class Serie
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int nroCapitulos { get; set; }
        public Serie(int _id, string _nombre, string _descripcion, int _nroCapitulos)
        {
            id = _id;
            nombre = _nombre;
            descripcion = _descripcion;
            nroCapitulos = _nroCapitulos;
        }
    }
}
