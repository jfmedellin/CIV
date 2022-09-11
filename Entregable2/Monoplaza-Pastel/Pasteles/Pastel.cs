using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteles
{
    internal class Pastel
    {
        public string Nombre { get; set; }
        public int Tamagnio { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }

        public Pastel(string nombre, int tamgnio)
        {
            Nombre = nombre;
            Tamagnio = tamgnio;
            Ingredientes = new List<Ingrediente>();
        }

        public void AgregarIngrediente(Ingrediente ingrediente)
        {
            Ingredientes.Add(ingrediente);
        }

        public int ContarIngredientes()
        {
            return Ingredientes.Count;
        }

        public string ListarIngredientes()
        {
            string ingredientes = "";
            foreach (var ingrediente in Ingredientes)
            {
                ingredientes += ingrediente.Nombre + "\n";
            }
            
            return ingredientes;
        }

        public int CalcularCosto()
        {
            int precio = 0;
            foreach (var ingrediente in Ingredientes)
            {
                precio += ingrediente.Precio;
            }
            return precio;
        }
    }
}
