using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class AtributosEstaticos {

        public static void Executar() {

            var produto1 = new Produto("Caneta", 3.2, 0.1);
            var produto2 = new Produto("Borracha", 5.3, 0.1);

            Produto.Desconto = 0.5;

            Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");

            Produto.Desconto = 0.02;

            Console.WriteLine($"Preço com desconto: {produto2.CalcularDesconto()}");



        }

        class Produto {
            public string Nome;
            public double Preco;
            public static double Desconto = 0.1;

            public Produto(string Nome, double Preco, double Desconto) {
                this.Nome = Nome;
                this.Preco = Preco;
                //this.Desconto = Desconto;
            }

            public double CalcularDesconto() {
                return Preco - Preco * Desconto;
            }


        }
    }
}
