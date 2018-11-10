using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01
{
    class León
    {
        public int peso = 0;
        public string color = "", tamaño = "", nombre = "";
        public double velocidad = 0.0;

        public void Respirar()
        {
            Console.WriteLine("Estoy respirando");
        }

        public void Nacer()
        {
            Console.WriteLine("Estoy naciendo");
        }

        public void Cazar()
        {
            Console.WriteLine("estoy cazando");
        }

        public void Procrear()
        {
            Console.WriteLine("Estoy Procreando");
        }

        public void Comer()
        {
            Console.WriteLine("estoy comiendo");
        }
    }
}
