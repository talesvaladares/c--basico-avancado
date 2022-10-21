using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.estruturasDeControle {
    internal class EstruturaBreak {

        public static void Executar() {

            Random random = new Random();

            //51 nao entra
            int numero = random.Next(1, 51);

            Console.WriteLine($"O numero que queremos é {numero}");

            for (int i = 1; i <= 50; i++) {
                Console.WriteLine($"{i} é numero que queremos?");

                if (i == numero) {
                    Console.WriteLine("Sim");
                    break;
                }
                else {
                    Console.WriteLine("Não"); 
                }
            }
        }
    }
}
