using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento
{
    /*Esta classe tem por objetivo fornecer uma identificação dinâmica 
     * ao textbox de busca pelo nome do item desejado
     */
    class Busca
    {
        private string inicio = "início do nome";
        private string qualquerParte = "qualquer parte do nome";
        private bool logica;

        public void setaLogica(string txt)
        {
            if (inicio == txt)
            {
                logica = true;
            }
            else
            {
                logica = false;
            }
        }

        public string retornaTxt1()
        {
            if (logica == true)
            {
                return qualquerParte;
            }
            else
            {
                return inicio;
            }            
        }

        public string retornaTxt2()
        {
            if (logica == true)
            {
                return inicio;
            }
            else
            {
                return qualquerParte;
            }            
        }      
        
    }
}
