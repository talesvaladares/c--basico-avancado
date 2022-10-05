using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.fundamentos {
    internal class VariaveisEConstantes {

        public static void Executar() {
            
            //area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            //tipos inteiros
            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);
                
            //menor valor que o sbyte pode receber
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("menor valor inteiro "+ menorValorInt);

            //uint é sem sinal negativo
            uint populacaBrasileira = 207_600_000;
            Console.WriteLine("População brasileira "+ populacaBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            //tipos flutuantes
            float precoComputador = 1299.99f; //precisa por o f para funcionar no c#
            Console.WriteLine("Preço computador " + precoComputador);

            double valorMercadoDaApple = 1_000_000_000_000_000.00;
            Console.WriteLine("Valor mercado da apple " + valorMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Valor entre estrelas " + distanciaEntreEstrelas);
               
            //tem que ser entre aspas simples
            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string text = "Tales Eduardo";
            Console.WriteLine(text);



        }
    }
}
