using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.estruturasDeControle {
    internal class EstruturaWhile {
        public static void Executar() {

            int palpite = 0;

            Random random = new Random();
               
            //valor 16 não entra
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {

                Console.WriteLine("Insira seu palpite");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (palpite == numeroSecreto) {
                    numeroEncontrado = true;
                    var conAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Numero encontrado em {tentativas} tentavias");
                    Console.BackgroundColor = conAnterior;

                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("menor... Tente novamente");
                    Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
                } else {
                    Console.WriteLine("maior... Tente novamente");
                    Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
                }

            }



        }
    }
}
