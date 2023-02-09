using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            //var dateTime = new DateTime(2030, 2, 6);
            var datime = new DateTime(day: 9, month: 2, year: 2023);

            Console.WriteLine(datime.Day);
            Console.WriteLine(datime.Month);
            Console.WriteLine(datime.Year);

            //criar data sem hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutos: " + diaAtual.Minute);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

        
            Console.WriteLine(diaAtual.ToString("dd")); //mostra so o dia 7
            Console.WriteLine(diaAtual.ToString("d")); //mostra formatado 07/07/2027
            Console.WriteLine(diaAtual.ToString("D")); //mostra em formatdo de texto de acordo com sistema operacional segunda-feira, 7 de janeiro de 2023

            Console.WriteLine(diaAtual.ToString("g")); // dia atual com hora
            Console.WriteLine(diaAtual.ToString("G")); //dia atual com hora e segundos

            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
