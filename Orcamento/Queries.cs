using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento
{
    class Queries
    {
        static string query = string.Empty;

        public static string GetDataByOrcId(int id)
        {
            query = 
                "SELECT Cliente.nome, Cliente.endereco, Cliente.local, " + 
                    "Orcamento.id AS orc_id, Tipo.nome AS tipo " +
                "FROM ((Cliente " +
                "INNER JOIN " +
                    "Orcamento ON Cliente.id = Orcamento.id_cliente ) " +
                "INNER JOIN " +
                    "Tipo ON Orcamento.id_tipo = Tipo.id) " +
                "WHERE (Orcamento.id = " + id + ");";
            return query;
        }

        public static string GetItemsByOrcId(int id)
        {
            query =
                "SELECT Produto.nome AS Produto, " +
                    "Item.quantidade AS Quantidade, " +
                    "Item.preco_item AS Preço, " +
                    "Item.quantidade * Item.preco_item AS Subtotal, " +
                    "Item.id " +
                "FROM (( Item " +
                "INNER JOIN Orcamento ON Item.id_orcam = Orcamento.id ) " +
                "INNER JOIN Produto ON Item.id_produto = Produto.id ) " +
                "WHERE(Orcamento.id = " + id + ");";            
            return query;
        }
        /// <summary>
        /// Query especial para evitar erros na falta de Cliente, Produto ou 
        /// Item
        /// </summary>
        /// <param name="table">Nome da tabela a ser consultada</param>
        /// <returns>Retorna a query em formato string</returns>
        public static string ItemsExists(string table)
        {
            query = "SELECT id FROM " + table + " AS id LIMIT 1;";                    
            return query;
        }

    }
}
