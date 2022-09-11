using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteles
{
    internal class Ingrediente
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public Ingrediente(string nombre, int cantidad, int precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
