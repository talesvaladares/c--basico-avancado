using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno () {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno () {Nome = "André", Idade = 21, Nota = 4.3},
                new Aluno () {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno () {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno () {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno () {Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno () {Nome = "Marcio", Idade = 18, Nota = 6.8},
            };

            //pega somente um aluno que o nome seja pedro
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine(pedro.Nome);
            Console.WriteLine(pedro.Nota);

            //desta forma não da erro se não encontrar o aluno
            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Pedro2"));

            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }

            //pega o primeiro que encontrar
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nome);
            Console.WriteLine(ana.Nota);

            var cicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Ana2"));
            
            if (cicrano == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nome);
            Console.WriteLine(outraAna.Nota);

            //pula um valor e pega 3 da lista
            var exemploSkip = alunos.Skip(1).Take(3);

            foreach(var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            var menorNota = alunos.Min(aluno => aluno.Nota);

            Console.WriteLine(maiorNota);
            Console.WriteLine(menorNota);

            //soma todas as notas da lista
            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            //media das notas dos alunos da lista
            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
