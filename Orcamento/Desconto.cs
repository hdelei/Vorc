using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento
{
    class Desconto
    {
        private int valor = 0;

        public int Valor
        {
            get { return valor; }
            set { valor = value * -1; }
        }

    }
}
