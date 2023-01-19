using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada; //uint significa numero inteiro sem sinal

        public Moto(string marca, string modelo, uint cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetCilindrada(cilindrada);
            SetModelo(modelo);
            SetMarca(marca);
        }

        public Moto() { }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            //if (cilindrada > 0)
            //{
            //   Cilindrada = cilindrada;
            //}

            //pega sempre positivo
            //cilindrada = Math.Abs(cilindrada);

            Cilindrada = cilindrada;


        }
    }

    internal class GetSet
    {

        public static void Executar()
        {
            var moto1 = new Moto("Kawazaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());
            Console.WriteLine(moto1.GetMarca());

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
        }
    }
}
