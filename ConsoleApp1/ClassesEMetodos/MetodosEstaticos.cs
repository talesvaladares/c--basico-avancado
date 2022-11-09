using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class MetodosEstaticos {

        public static void Executar() {

            //quando a classe tem metodos estaticos não é preciso criar uma instancia da classe
            //posso usar o metodo direto da classe

            //quando um metodo é static significa que aquele metodo pertence a classe e não a instancia gerada por aquela classe
            //é como se o metodo fosse global
            var resultado = CalculadoraEstatica.Multiplicar(2, 3);

            Console.WriteLine(resultado);
        }

        class CalculadoraEstatica {

            public static int Somar(int a , int b) {
                return a + b;  
            }

            public static int Multiplicar(int a, int b) {
                return a * b;
            }
        }
    }
}
