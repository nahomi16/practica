using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01
{
    class TV
    {
        public string color = "", forma = "", tamaño = "";
        public double peso = 0.0, costo = 0.0;

        public void Prender()
        {
            Console.WriteLine("estoy prendiendo");
        }

        public void Trasmitir()
        {
            Console.WriteLine("estoy trasmitiendo");
        }

        public void Apagar()
        {
            Console.WriteLine("me estoy apagando");
        }

        public void AjustarBrillo()
        {
            Console.WriteLine("Estoy ajustando el brillo");
        }

        public void Informar()
        {
            Console.WriteLine("estoy informando");
        }
    }
}
