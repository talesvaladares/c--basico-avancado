using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        private double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor )
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            Saldo -= valor;
        }
    }
    internal class PrimeiraExcecao
    {
        public static void Executar()
        {
            Conta conta = new Conta(200);

            try
            {
                conta.Sacar(201);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.GetType().Name); //mostra o tipo da exceção
                Console.WriteLine(ex.Message);      
            }
            finally
            {
                Console.WriteLine("Obrigado");
            }
        }
    }
}
