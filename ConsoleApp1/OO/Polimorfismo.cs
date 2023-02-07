﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO


{
    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }

        public Comida()
        {

        }
    }

    public class Feijao : Comida
    {
        public Feijao(double peso) : base(peso) { }
    }

    public class Arroz : Comida
    {
        public Arroz(double peso) : base(peso) { }
    }

    public class Carne : Comida
    {
        public Carne(double peso) : base(peso) { }
    }

    public class Pessoa
    {
        public double Peso;

        public void Comer(Feijao feijao)
        {
            Peso += feijao.Peso;
        }

        public void Comer(Carne carne)
        {
            Peso = carne.Peso;
        }

        public void Comer(Arroz arroz)
        {
            Peso += arroz.Peso;
        }

        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }
       
    }
    internal class Polimorfismo
    {
        public static void Executar()
        {
            Feijao feijao = new Feijao(0.3);

            Arroz arroz = new Arroz(0.25);

            Carne carne = new Carne(0.3);

            Pessoa cliente = new Pessoa();

            cliente.Peso = 80.2;

            cliente.Comer(feijao);
            cliente.Comer(arroz);
            cliente.Comer(carne);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}KG");
        }
    }
}
