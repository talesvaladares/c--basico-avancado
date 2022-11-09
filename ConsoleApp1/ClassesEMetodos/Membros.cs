using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();

            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            //Console.WriteLine(sicrano.Apresentar()) ;

            sicrano.ApresentarNoConsole();


            var fulano = new Pessoa();

            fulano.Nome = "Beto";
            fulano.Idade = 61;

            //Console.WriteLine(fulano.Apresentar());

            fulano.ApresentarNoConsole();
        }
    }
}
