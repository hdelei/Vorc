using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento
{
    class Util
    {
        private static decimal valorTotal;

        public static decimal ValorTotal
        {
            get{ return valorTotal; }
        }
        
        public static DataTable dtColumnIntToDecimal(DataTable dt, int column)
        {
            List<decimal> price = new List<decimal>();
            //Gerar lista de valores em decimal
            foreach (DataRow row in dt.Rows)
            {                
                decimal aux = Convert.ToDecimal((long)row[column]) / 100;
                price.Add(aux);     
            }

            //clonar o datatable, transformando a coluna em decimal
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns[column].DataType = typeof(decimal);
            foreach (DataRow row in dt.Rows)
            {
                dtCloned.ImportRow(row);
            }

            //Inserir valores em decimal
            for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
            {
                dtCloned.Rows[rowIndex][column] = price[rowIndex];
                //Console.WriteLine(dtCloned.Rows[rowIndex][column]);
            }

            //gera a soma de todos os valores 
            valorTotal = price.Sum();
            //Console.WriteLine(valorTotal);
            return dtCloned;
        }        
        /// <summary>
        /// Valida a entrada de valor do usuário, evitando erros de conversão de
        /// valores
        /// </summary>
        /// <param name="userEntry">Recebe um valor convertido para string. Comumente
        /// vem de um TextBox</param>
        /// <returns>Retorna o valor em string já em um formato válido</returns>
        public static string entryValidate(string userEntry)
        {            
            string validEntry;
            if (userEntry.Contains(",") || userEntry.Contains("."))
            {
                validEntry = userEntry.Replace(",", "").Replace(".", "");
            }
            else
            {
                validEntry = userEntry + "00";
            }
            return validEntry;
        }
    }
}
