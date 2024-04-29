using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.SistemaInterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(2503, 250325);
            Console.WriteLine(conta.Saldo);


            conta.Sacar(-10);

            string nome = "robyson";

            Console.ReadLine();
        }
    }
}
