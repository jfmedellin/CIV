using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteles
{
    internal class ProgramPrincipal
    {
        static void Main(string[] args)
        {
            Ingrediente azucar = new Ingrediente("Azucar", 1, 100);
            Ingrediente harina = new Ingrediente("Harina", 2, 200);
            Ingrediente huevo = new Ingrediente("Huevo", 10, 300);
            Ingrediente leche = new Ingrediente("Leche", 1, 400);
            Ingrediente vainilla = new Ingrediente("Vainilla", 1, 500);
            Ingrediente chocolate = new Ingrediente("Chocolate", 1, 600);
            Ingrediente mantequilla = new Ingrediente("Mantequilla", 1, 700);
            Ingrediente crema = new Ingrediente("Crema", 1, 800);
            Ingrediente fresa = new Ingrediente("Fresa", 1, 900);

            Pastel pastelChocolote = new Pastel("Pastel de chocolate", 1);
            pastelChocolote.AgregarIngrediente(azucar);
            pastelChocolote.AgregarIngrediente(harina);
            pastelChocolote.AgregarIngrediente(huevo);
            pastelChocolote.AgregarIngrediente(leche);
            pastelChocolote.AgregarIngrediente(vainilla);
            pastelChocolote.AgregarIngrediente(chocolate);
            pastelChocolote.AgregarIngrediente(mantequilla);
            pastelChocolote.AgregarIngrediente(crema);
            pastelChocolote.AgregarIngrediente(fresa);

            Console.WriteLine("Cantidad de ingredientes: " + pastelChocolote.ContarIngredientes());
            Console.WriteLine();
            Console.WriteLine("Ingredientes del pastel de chocolate");
            Console.WriteLine(pastelChocolote.ListarIngredientes());
            Console.WriteLine();
            Console.WriteLine("Costo del pastel de chocolate");
            Console.WriteLine(pastelChocolote.CalcularCosto());
            Console.WriteLine();

            Console.WriteLine("El programa ha finalizado");
            Console.ReadKey();
        }
    }
}
