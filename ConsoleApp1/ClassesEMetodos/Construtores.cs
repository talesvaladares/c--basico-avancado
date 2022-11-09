using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

        
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro() { }

        public Carro(string modelo, string fabricante, int ano) { 
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }

    class Construtores {

        public static void Executar() {

            var carro1 = new Carro();
            carro1.Modelo = "uno";
            carro1.Fabricante = "Fiat";
            carro1.Ano = 1996;

            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            var carro2 = new Carro("gol", "wolksvagem", 2022);


            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");


            var carro3 = new Carro() {
                Modelo = "Tempra",
                Fabricante = "Fiat",
                Ano = 1987
            };

            Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");
        }
    }
}
