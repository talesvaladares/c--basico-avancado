using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        private int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            this.VelocidadeMaxima = velocidadeMaxima;
           
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = this.VelocidadeAtual+ delta;

            if (novaVelocidade < 0 )
            {
                this.VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima)
            {
                this.VelocidadeAtual = this.VelocidadeMaxima;
            } else
            {
                this.VelocidadeAtual = novaVelocidade;
            }

            return this.VelocidadeAtual;
        }

        //virtual quer dizer que esse método pode ser sobrescrito por seus filhos
        public virtual int Acelerar()
        {
            return this.AlterarVelocidade(5);
        }

        public int Frear()
        {
            return this.AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        //base quer dizer que estamos usando o construtor pai
        public Uno() : base(200) { }
    }

    public class Ferrari: Carro
    {
        public Ferrari() : base(350) { }

        public override int Acelerar()
        {
            return this.AlterarVelocidade(15);
        }

        //oculto o método da classe pai
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }

    internal class Heranca
    {

        public static void Executar()
        {
            Console.WriteLine("Uno...");

            Uno uno = new Uno();
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.Acelerar());
            Console.WriteLine(uno.Frear());
            Console.WriteLine(uno.Frear());

            Console.WriteLine();

            Console.WriteLine("Ferrari...");

            Ferrari ferrari = new Ferrari();
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Frear());
            Console.WriteLine(ferrari.Frear());

            Console.WriteLine();

            Carro carro = new Ferrari(); //polimorfismo
            Console.WriteLine("Ferrai com tipo carro...");
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());

            Console.WriteLine();

            carro = new Uno(); //polimorfismo
            Console.WriteLine("Uno com tipo carro...");
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Acelerar());
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());
            Console.WriteLine(carro.Frear());

        }

    }
}
