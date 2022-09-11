using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoplaza_Pastel
{
    internal class Monoplaza
    {
        public string Escuderia { get; set; }
        
        public bool Encendido { get; set; }
        public bool EnMovimiento { get; set; }

        public Monoplaza(string escuderia)
        {
            Escuderia = escuderia;
            Encendido = false;
            EnMovimiento = false;
        }

        public void Encender()
        {
            if (!Encendido)
            {
                Encendido = true;
                Console.WriteLine("El motor del monoplaza de la escudería {0} ha sido encendido", Escuderia);
            }
            else
            {
                Console.WriteLine("El motor del monoplaza de {0} ya estaba encendido", Escuderia);
            }
        }

        public void Apagar()
        {
            if (Encendido && !EnMovimiento)
            {
                Encendido = false;
                Console.WriteLine("El motor del monoplaza de la escudería {0} ha sido apagado", Escuderia);
            }
            else
            {
                Console.WriteLine("El motor del monoplaza de {0} no se puede apagar", Escuderia);
            }
        }

        public void Detener()
        {
            if (Encendido && EnMovimiento)
            {
                EnMovimiento = false;
                Console.WriteLine("El monoplaza se ha detenido");
            }
            else
            {
                Console.WriteLine("El monoplaza no se puede detener porque está encendido y está en movimiento");
            }
        }
    }
}
