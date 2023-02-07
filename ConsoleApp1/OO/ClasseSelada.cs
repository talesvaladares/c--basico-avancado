﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    sealed class SemFilho
    {
        public double valorDaFortuna ()
        {
            return 1_407_033.34;
        }
    }

    //class SouFilho: SemFilho
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        public new  bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    internal class ClasseSelada
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();

            Console.WriteLine(semFilho.valorDaFortuna);

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());

        }
    }
}
