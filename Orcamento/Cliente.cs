using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento
{
    class Cliente
    {
        private string nome;
        private static string orcStatus = "Pendente";

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }


        }

        public string OrcStatus
        {
            get
            {
                return orcStatus;
            }

            set
            {
                orcStatus = value;
            }
        }
    }
}
