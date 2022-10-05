using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;

            //fica apenas com uma casa decimal
            Console.WriteLine(valor.ToString("F1"));
            
            //transforma em moeda
            Console.WriteLine(valor.ToString("C"));

            //transforma percentual
            Console.WriteLine(valor.ToString("P"));

            //transforma em numero decimal com duas casas decimais
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");

            //transforma em moeda
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;

            //completa com zeros até o numero ter o tamanho de 10
            Console.WriteLine(inteiro.ToString("D10", cultura));


        }
    }
}
