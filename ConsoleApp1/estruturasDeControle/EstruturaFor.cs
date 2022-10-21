using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.estruturasDeControle {
    internal class EstruturaFor {

        public static void Executar() {
            //int i = 1;

            //while (i <= 10) {
            //  Console.WriteLine(i);
            // i++;
            //}

          
            double somario = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.WriteLine($"Informe a nota do aluno {i}");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somario += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somario / tamanhoTurma : 0;
            Console.WriteLine($"Media da turma {media}");
        }
    }
}
