using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01
{
    class Celular
    {
        public string color = "", modelo = "", tamaño = "", forma = "";
        public double peso = 0.0;

        public void Prender()
        {
            Console.WriteLine("estoy prendiendo");
        }

        public void Apagar()
        {
            Console.WriteLine("Me estoy apagando");
        }

        public void TomarFoto()
        {
            Console.WriteLine("estoy tomando fotos");
        }

        public void Grabar()
        {
            Console.WriteLine("estoy grabando");
        }

        public void Llamar()
        {
            Console.WriteLine("estoy Llamando");
        }
    }
}
