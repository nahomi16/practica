using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01
{
    class Carro
    {
        public int peso = 0;
        public string modelo = "", tamaño = "", color = "";
        public double costo = 0.0;

        public void Encender()
        {
            Console.WriteLine("Estoy encendiendo");
        }

        public void DarVuelta()
        {
            Console.WriteLine("Estoy dando vuelta");
        }

        public void PrenderLuces()
        {
            Console.WriteLine("Estoy Prendiendo las luces");
        }

        public void Transportar()
        {
            Console.WriteLine("estoy transportando");
        }

        public void Apagar()
        {
            Console.WriteLine("Me estoy apagando");
        }
    }
}
