using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Set
    {
       
        public static void Executar()
        {

            var livro = new Produto("Game of thrones", 49.9);

            var carrinho = new HashSet<Produto>();

            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.90),
                new Produto("brinquedo", 80),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo); //adiciona uma lista em uma lista
            Console.WriteLine(carrinho.Count); //conta quantos elementos tem na lista
           

            foreach (var item in carrinho)
            {
         
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

        }
    }
}
