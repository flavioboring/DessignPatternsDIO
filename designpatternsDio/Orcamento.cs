using System;
using System.Collections.Generic;
using System.Text;

namespace designpatternsDio
{
    public class Orcamento
    {
        public double valor { get; private set; }
        public Orcamento(double valor)
        {
            this.valor = valor;
        }
    }
}
