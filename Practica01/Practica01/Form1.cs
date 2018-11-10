using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Persona persona = new Persona();

            persona.nombre = "Sergio";

            Console.WriteLine("persona.nombre " + persona.nombre);

            persona.Cantar();

            persona.Respirar();

            Celular celular = new Celular();

            celular.color = "negro";

            Console.WriteLine("celular.color " + celular.color);

            celular.Prender();

            TV TV = new TV();

            TV.tamaño = "grande";

            Console.WriteLine("TV.tamaño " + TV.tamaño);

            TV.Prender();

            Carro carro = new Carro();

            carro.peso = 700;

            Console.WriteLine("carro.peso " + carro.peso);

            carro.Encender();

            Laptop laptop = new Laptop();

            laptop.color = "azul";

            Console.WriteLine("laptop.color " + laptop.color);

            laptop.Prender();

            León león = new León();

            león.peso = 500;

            Console.WriteLine("león.peso " + león.peso);

            león.Respirar();
        }
    }
}
