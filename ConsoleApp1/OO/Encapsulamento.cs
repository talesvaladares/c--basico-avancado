using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FIlhoNaoReconhecido: SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho Não reconhecido");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante
    {

        public readonly SubCelebridade amiga = new SubCelebridade();
        public void MeusAcessos()
        {
            Console.WriteLine("Amiga distante");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
    internal class Encapsulamento
    {
        public static void Executar()
        {
            //como vou fazer uma única chamada posso usar desta forma, sem armazenar a instancia em uma variavel
            new SubCelebridade().MeusAcessos();

            Console.WriteLine();

            new FilhoReconhecido().MeusAcessos();
            new FIlhoNaoReconhecido().MeusAcessos();

            Console.WriteLine();

            new AmigoProximo().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
