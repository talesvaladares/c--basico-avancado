using System;
using System.IO;

namespace CursoCSharp.Api
{
    internal class Diretorios
    {

        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharp".ParseHome();
            var dirProjeto = @"~/Desktop/estudo/C#/c--basico-avancado".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true); //fala que é recursivo ou seja vai excluir tudo que tem dentro da pasta
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true); //fala que é recursivo ou seja vai excluir tudo que tem dentro da pasta
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("============ Patas ==============");
            var pastas = Directory.GetDirectories(dirProjeto);

            foreach (var pasta in pastas )
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("============ Arquivos ==============");
            var arquivos = Directory.GetFiles(dirProjeto);

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("============ Raiz ==============");
            var raiz = Directory.GetDirectoryRoot(dirProjeto);
            Console.WriteLine(raiz);

            Directory.Move(novoDir, novoDirDestino);


        }
    }
}
