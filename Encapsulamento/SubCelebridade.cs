using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {   
        //todos
        public string InfoPublica = "Tenho um instagram!";

        //herança
        protected  string CorDoOlho = "Verde";
           
        //mesmo projeto (assembly)
        internal ulong NumeroCelular = 5537999999999;

        //herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Use muitas gírias";

        //mesma classe ou herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "bla bla";

        //private é o padrão
        private bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");
            
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
