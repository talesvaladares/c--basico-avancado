using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            //preço desconto
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);

            Console.WriteLine($"O preço final é {totalComDesconto}");

            //IMC
            double preso = 70;
            double altura = 1.69;
            double imc = preso / Math.Pow(altura, 2);

            Console.WriteLine($"O IMC é {imc}");


            //numero par/impar
            int par = 24;
            int impar = 55;

            Console.WriteLine($"{par}/2 tem {par % 2}");
            Console.WriteLine($"{impar}/2 tem {impar % 2}");
        }
    }
}

