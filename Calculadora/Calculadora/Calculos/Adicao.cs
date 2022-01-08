using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Calculos
{
    internal class Adicao
    {
        public long Saldo { get; set; }

        public void calculo(List<long> numeros)
        {
            long i = 0;
            foreach (var item in numeros)
            {
                i += item;
            }
          Saldo = i;
        }
    }
}
