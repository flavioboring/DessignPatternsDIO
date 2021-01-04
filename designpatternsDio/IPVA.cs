using System;
using System.Collections.Generic;
using System.Text;

namespace designpatternsDio
{
    public class IPVA : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.valor * 0.5;
        }
    }
}
