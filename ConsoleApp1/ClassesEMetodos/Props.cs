using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        private double desconto = 0.1;
        private string nome;

        public string Nome {
            get { return "Opcional: " + nome; }

            set { nome = value; }
        }

        public double Preco { get; set; }

        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);
        }

        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    internal class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);
        }
    }
}
