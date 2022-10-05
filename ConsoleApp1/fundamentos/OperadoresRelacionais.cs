using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar() {
            double nota = 6.0;
            double notaDeCorte = 7;

            Console.WriteLine($"Nota inválida? {nota > 10}");
            Console.WriteLine($"Nota inválida? {nota < 10}");
            Console.WriteLine($"Perfeito? {nota == 10}");
            Console.WriteLine($"Tem como melhorar? {nota != 10}");
            Console.WriteLine($"Pssou por média? {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperação? {nota < notaDeCorte}");
            Console.WriteLine($"Reprovado? {nota < 3}");
        }
    }
}
