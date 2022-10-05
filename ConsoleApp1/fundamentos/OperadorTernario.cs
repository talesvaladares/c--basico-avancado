using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos {
    internal class OperadorTernario {
        public static void Executar() {
            var nota = 7;

            var resultado = nota >= 7 ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado);
        }
    }
}
