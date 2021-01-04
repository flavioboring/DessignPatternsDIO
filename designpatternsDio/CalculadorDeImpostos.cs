using System;
using System.Collections.Generic;
using System.Text;

namespace designpatternsDio
{
    class CalculadorDeImpostos
    {
        public void Realizacalculo(Orcamento orcamento, Imposto imposto)
        {
            double ipva = imposto.Calcula(orcamento);
            Console.WriteLine(ipva);
        }
    }
}
