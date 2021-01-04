using System;

namespace designpatternsDio
{
    class Program
    {
        static void Main(string[] args)
        {
           Imposto iptu =  new IPTU();
           Imposto ipva = new IPVA();

            Orcamento orcamento = new Orcamento(650.00);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.Realizacalculo(orcamento, iptu);
            calculador.Realizacalculo(orcamento, ipva);

            Console.ReadKey();
            


        }
    }
}
