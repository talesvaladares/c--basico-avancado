using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            this.Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} foi inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            this.Altura = altura;
        }

        public override string ToString()
        {
            return $"{this.Nome} tem {this.Altura}cm de altura!";
        }
    }
    internal class ConstrutorThis
    {

        public static void Executar()
        {

            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40);

            Console.WriteLine(spike);
            Console.WriteLine(max);

        }
    }
}
