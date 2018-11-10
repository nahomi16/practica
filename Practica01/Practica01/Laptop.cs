using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01
{
    class Laptop
    {
        public string color = "", tamaño = "", marca = "";
        public double costo = 0.0, peso = 0.0;

        public void Prender()
        {
            Console.WriteLine("estoy prendiendo");
        }

        public void AlmacenarSoftware()
        {
            Console.WriteLine("estoy almacenado software");
        }

        public void ReproducirVideo()
        {
            Console.WriteLine("estoy Reproduciendo video");
        }

        public void Buscar()
        {
            Console.WriteLine("estoy buscando");
        }

        public void Apagar()
        {
            Console.WriteLine("me estoy apagando");
        }
    }
}
