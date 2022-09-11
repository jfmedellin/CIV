using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoplaza_Pastel
{
    internal class Circuito
    {
        private List<Monoplaza> monoplazaList;
        public int NumeroVueltas { get; set; }
        public string Nombre { get; set; }

        public Circuito(string nombre, int numeroVueltas)
        {
            Nombre = nombre;
            NumeroVueltas = numeroVueltas;
            monoplazaList = new List<Monoplaza>();
        }

        public void AgregarMonoplaza(Monoplaza monoplaza)
        {
            monoplazaList.Add(monoplaza);
        }

        public void SacarMonoplaza(Monoplaza monoplaza)
        {
            monoplazaList.Remove(monoplaza);
        }

        public Dictionary<int, Monoplaza> RealizarPrueba()
        {
            int menorTiempo = 2000000000;
            Random rnd = new Random();
            Dictionary<int, Monoplaza> tiempos =
            new Dictionary<int, Monoplaza>();
            
            foreach (Monoplaza monoplaza in monoplazaList)
            {
                monoplaza.Encender();
                int tiempoTotal = 0;
                int tiempo = 0;

                for (int i = 1; i <= NumeroVueltas; i++)
                {
                    tiempo = rnd.Next(100000, 999999);
                    tiempoTotal += tiempo;
                    Console.WriteLine("Tiempo de la vuelta {0}: {1}", i, tiempo);
                    Console.WriteLine();
                }
                Console.WriteLine("Tiempo total: {0}", tiempoTotal);    

                tiempos.Add(tiempoTotal, monoplaza);

                if (menorTiempo == 2000000000)
                {
                    menorTiempo = tiempoTotal;
                }
                else if (tiempoTotal < menorTiempo)
                {
                    menorTiempo = tiempoTotal;
                }

                monoplaza.Detener();
                monoplaza.Apagar();

                Console.WriteLine();
            }

            return tiempos;
        }
    }
}
