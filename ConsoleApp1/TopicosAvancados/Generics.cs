using CursoCSharp.Colecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        private T valorPrivado;

        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
        }

        public T metodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return valorPrivado;
        }
    }

    public class CaixaInt: Caixa<int> {
        public CaixaInt() : base(0) { }
     }

    public class CaixaProduto: Caixa<Produto>
    {
        public CaixaProduto() : base(new Produto()) { }
    }
    internal class Generics
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000);

            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.GetType());

            var caixa2 = new Caixa<String>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Teste"));
            Console.WriteLine(caixa2.GetType());

            var caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        
        }
    }
}
