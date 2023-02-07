using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    interface OperacaoBinaria
    {   
        //por padrão é public e abstratic
        int Operacao(int a, int b);
    }

    class Soma: OperacaoBinaria
    {
        public int Operacao(int a , int b)
        {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a , int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>()
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),

        };

        public string ExecutarOperacoes(int a , int b)
        {
            string resultados = "";

            foreach (var op in operacoes)
            {
                resultados += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultados;
        }
    }

    internal class Interface
    {
        public static void Executar()
        {
            Calculadora calculadora = new Calculadora();

            Console.WriteLine(calculadora.ExecutarOperacoes(4, 2));
        }
    }
}
