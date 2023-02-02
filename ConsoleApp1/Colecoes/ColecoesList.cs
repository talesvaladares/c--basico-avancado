using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object? obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }

        //o equals e o hashCode servem para comparar objetos
        //se os dois são iguais ou não
        //se esses dois métodos não forem implementados, a comparação será feita pela referencia da memoria
        //se for feita por comparação de memoria a igualdade sempre será false

        //metodo para comparar se dois objetos sãos iguais
        //public override bool Equals(object obj)
        //{
        //    Produto outroProduto = (Produto)obj;
        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco == outroProduto.Preco;
        //    return mesmoNome && mesmoPreco;
        //}

        //public override int GetHashCode()
        //{
        //   return Nome.Length;
        //}
    }
    internal class ColecoesList
    {
        public static void Executar() {
            var livro = new Produto("Game of thrones", 49.9);

            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var combo = new List<Produto> { 
                new Produto("Camisa", 29.90),
                new Produto("brinquedo", 80),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo); //adiciona uma lista em uma lista
            Console.WriteLine(carrinho.Count); //conta quantos elementos tem na lista
            carrinho.RemoveAt(3); //remove o elemento de indice 3

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
        }
    }
}
