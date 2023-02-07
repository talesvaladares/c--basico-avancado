using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DeleteFuncAnonima
    {
        delegate string StringOperacao(string s);
        public static void Executar()
        {
            StringOperacao inveter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);

                return new string(charArray);
            };

            Console.WriteLine(inveter("Bunda"));
        }
    }
}
