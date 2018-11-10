using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01
{
    class Persona
    {
        public string nombre = "", apellido = "", color = "";
        public int edad = 0;
        public double peso = 0.0;

        public void Nacer()
        {
            Console.WriteLine("Estoy Naciendo");
        }

        public void Crecer()
        {
            Console.WriteLine("estoy creciendo");
        }

        public void Procrear()
        {
            Console.WriteLine("Me estoy procreando");
        }

        public void Respirar()
        {
            Console.WriteLine("Estoy respirando");
        }

        public void Cantar()
        {
            Console.WriteLine("estoy cantando");
        }
    }
}
