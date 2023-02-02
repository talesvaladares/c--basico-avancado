using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Queue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("fulano"); //adicionada na fila
            fila.Enqueue("sicrano"); //adicionada na fila
            fila.Enqueue("beltrano"); //adicionada na fila

            Console.WriteLine(fila.Peek()); //mostra o primeiro da fila
            Console.WriteLine(fila.Count); //mostra o tamanho da fila

            Console.WriteLine(fila.Dequeue()); //tira o primeiro da fila
            Console.WriteLine(fila.Count); //mostra o tamanho da fila

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine(fila.Contains("beltrano")); //verifica se tem beltrano na fila

        }
    }
}
