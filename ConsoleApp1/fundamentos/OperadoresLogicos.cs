using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = true;

            var comprouTv5 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou tv 50? {comprouTv5}");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou sorvete? {comprouSorvete}");

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou tv 32? {comprouTv32}");

            Console.WriteLine($"Mais saudavel? {!comprouSorvete}");
        }
    }
}
