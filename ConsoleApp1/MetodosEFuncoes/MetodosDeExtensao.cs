﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{

    //desta forma é possivel 
    //criar novas funções e abrituir ao tipo int do c#
    //agora todo numero do tipo int
    //ja tem uma função soma e subtração
    public static class ExntensoesInteiro
    {
        public static int Soma(this int num, int outroNumero) {
            return num + outroNumero;
        }

        public static int Subtracao(this int num, int outroNumero)
        {
            return num - outroNumero;
        }
    }
    internal class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;

            Console.WriteLine(numero.Soma(4));
            Console.WriteLine(numero.Subtracao(4));
        }
    }
}
