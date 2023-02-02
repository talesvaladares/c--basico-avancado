using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {

        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1);
            var p2 = new Produto("Caneta", 1);

            //equals implementado dentro de produto
            //para verificar é so clicar me Produto
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
