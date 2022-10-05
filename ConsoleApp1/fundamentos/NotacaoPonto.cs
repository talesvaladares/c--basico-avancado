using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, "Word!").Replace(" Word!", "Mundo!");

            Console.WriteLine(saudacao);

            string valorImportante = null;
            //usamos o ? para fazer uma navegação segura
            //assim evitamos erros caso o lenght não exista
            Console.WriteLine(valorImportante?.Length);

        }
    }
}
