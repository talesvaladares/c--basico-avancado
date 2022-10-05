using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.fundamentos {
    internal class LendoDados {
        public static void Executar() {
            Console.Write("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário?");
            //CultureInfo.InvariantCulture usado para pegar valores decimais com . e nao com ,
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} anos R${salario}");

        }
    }
}
