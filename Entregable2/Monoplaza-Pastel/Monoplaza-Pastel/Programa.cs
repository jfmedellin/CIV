using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoplaza_Pastel
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            Monoplaza monoplazaFerrari = new Monoplaza("Ferrari");
            Monoplaza monoplazaMcLaren = new Monoplaza("McLaren");
            Monoplaza monoplazaRedBull = new Monoplaza("Red Bull");

            Circuito circuito = new Circuito("Circuito de Barcelona-Catalunya", 5);
            circuito.AgregarMonoplaza(monoplazaFerrari);
            circuito.AgregarMonoplaza(monoplazaMcLaren);
            circuito.AgregarMonoplaza(monoplazaRedBull);

            Dictionary<int, Monoplaza> tiempos = circuito.RealizarPrueba();

            var orden = tiempos.OrderBy(key=>key.Key);

            Console.WriteLine("El ganador es: {0}", orden.First().Value.Escuderia);
            Console.WriteLine("El segundo es: {0}", orden.ElementAt(1).Value.Escuderia);
            Console.WriteLine("El tercero es: {0}", orden.ElementAt(2).Value.Escuderia);

            Console.WriteLine();

            Console.WriteLine("El programa terminó.");
            Console.ReadLine();
        }
    }
}
