using System;
using System.IO;

namespace CursoCSharp.Api
{
    internal class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }
        public static void Executar()
        {

            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoCopia, caminhoDestino);

            try
            {
                using (StreamWriter sw = File.CreateText(caminhoOrigem))
                {
                    sw.WriteLine("Arquivo orignal");
                }

                FileInfo origem = new FileInfo(caminhoOrigem);
                Console.WriteLine(origem.Name);
                Console.WriteLine(origem.IsReadOnly);
                Console.WriteLine(origem.Extension);

                origem.CopyTo(caminhoCopia);
                origem.MoveTo(caminhoDestino);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
