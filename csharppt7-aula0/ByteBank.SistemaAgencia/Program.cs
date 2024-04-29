using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{


    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(123, 1),
                new ContaCorrente(261, 999),
                null,
                new ContaCorrente(168, 6),
                new ContaCorrente(523, 2),
                null,
                null,
                new ContaCorrente(523, 10)
            };

            //contas.Sort(); ~~> Chamar a implementação dada em IComparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            

            var contasNaoNulas = contas.Where(conta => conta != null);

            IOrderedEnumerable<ContaCorrente> contasOrdenadas =
            contasNaoNulas.OrderBy(conta => conta.Numero);


            foreach (var conta in contasOrdenadas)
            {
                    Console.WriteLine($"Conta numero : {conta.Numero}, Agencia : {conta.Agencia}");
            }

            Console.ReadLine();

        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Robyson", "Agatha", "Erika", "Roger"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);


            idades.AdicionarVarios(48, 89, 12);


            idades.AdicionarVarios(99, -1);

            idades.Sort();




            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

        }


        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 20, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaListaDeCOntaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoRoby = new ContaCorrente(111111, 22222222);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoRoby,
                new ContaCorrente(874, 5154181),
                new ContaCorrente(874, 1612161)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(
                contaDoRoby,
                new ContaCorrente(874, 5154181),
                new ContaCorrente(874, 1612161));


            for (int i = 0; i < lista.Tamanho; i++)
            {

                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
           {
                new ContaCorrente(874, 5154181),
                new ContaCorrente(874, 61265561),
                new ContaCorrente(874, 6554651)
           };


            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta {i} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {

            //ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Media de idades = {media}");
        }
    }
}
//ListExtensoes.AdicionarVarios(idades, 1, 6554, 161, 6541, 465);
//idades.AdicionarVarios(5, 1165, 1651, 651);

//idades.AdicionarVarios(235, 238);
//ListExtensoes.AdicionarVarios(idades, 235, 238);

// idades.Remove(5);


//Console.WriteLine(SomarVarios(1, 2, 3, 4, 5, 4494, 45));
//Console.WriteLine(SomarVarios(1, 2, 5));


////lista.EscreverListaNaTela();

//lista.Remover(contaDoRoby);

//Console.WriteLine("Apos remover o item");

////lista.EscreverListaNaTela();

////lista.GetItemNoIndice