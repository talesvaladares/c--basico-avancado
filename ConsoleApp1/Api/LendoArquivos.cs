using System;
using System.IO;

namespace CursoCSharp.Api
{
    internal class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneta bic;2;20");
                    sw.WriteLine("Borracha;3;21");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);  
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

  
        }
    }
}
