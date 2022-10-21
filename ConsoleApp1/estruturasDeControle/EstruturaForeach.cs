﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.estruturasDeControle {
    internal class EstruturaForeach {

        public static void Executar() {

            var palavra = "Opa!";

            foreach(var letra in palavra) {
                Console.WriteLine(letra);
            }

            //array do tipo string
            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}