using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento
{
    /// <summary>
    /// Esta classe tem por finalidade iniciar o banco de dados padrão
    /// no primeiro uso do sistema
    /// </summary>
    static class SQLiteDB
    {      
        /// <summary>
        /// Método responsável por criar um banco de dados automaticamente, caso não 
        /// encontre nenhum na pasta do aplicativo
        /// </summary>
        /// <param name="connectionString">Passar a string de conexão faz com que 
        /// o método verifique se o arquivo existe. O padrão em Properties.Settings é:
        /// "SQLiteDB.db"</param>
        /// <returns>Retorna uma mensagem de sucesso ou de erro como resultado</returns>
        public static string Create(string connectionString)
        {
            string returnStr = string.Empty;
            if (!File.Exists(connectionString))
            {
                System.Windows.Forms.MessageBox.Show("Banco de dados não encontrado. " + 
                    "Um novo BD foi criado automaticamente!", "Informação");
                try
                {
                    SQLiteConnection.CreateFile("SQLiteDB.db");
                    SQLiteConnection m_dbConnection;
                    m_dbConnection = new SQLiteConnection("Data Source=SQLiteDB.db;Version=3;");
                    m_dbConnection.Open();
                    string sql = createQuery();
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    sql = insertQuery();
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    m_dbConnection.Close();

                    //Se um novo BD for gerado, a string de conexão volta ao padrão
                    Properties.Settings.Default.connectionString = "SQLiteDB.db";

                    returnStr = "New DB Created successfuly!";
                }
                catch (Exception e)
                {
                    returnStr = e.Message;
                }
            }
            return returnStr;
        }
        /// <summary>
        /// Método auxiliar que organiza a query de criação das tabelas
        /// </summary>
        /// <returns>Retorna a query pronta para o BD</returns>
        private static string createQuery()
        {
            string createScript = "CREATE TABLE Cliente (" +
                " id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                " nome       TEXT NOT NULL UNIQUE," +
                " endereco   TEXT," +
                " local      TEXT," +
                " telefone_1 TEXT," +
                " telefone_2 TEXT ); ";
            createScript += "CREATE TABLE Produto (" +
                 " id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                 " nome  TEXT NOT NULL UNIQUE," +
                 " preco INTEGER ); ";
            createScript += "CREATE TABLE Tipo (" + 
                " id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,"  + 
                " nome      TEXT," + 
                " descricao TEXT ); ";
            createScript += "CREATE TABLE Orcamento (" +
                " id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                " id_cliente INTEGER REFERENCES Cliente (id)," +
                " data DATETIME," +
                " id_tipo INTEGER REFERENCES Tipo(id)," +
                " desconto INTEGER," +
                " status TEXT DEFAULT Pendente ); ";
            createScript += "CREATE TABLE Item (" +
                " id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                " id_orcam INTEGER REFERENCES Orcamento (id)," + 
                " id_produto INTEGER REFERENCES Produto(id)," +
                " preco_item INTEGER," + 
                " quantidade INTEGER NOT NULL ); ";

            return createScript;
        }
        /// <summary>
        /// Método auxiliar que organiza a query de criação das tabelas
        /// </summary>
        /// <returns>Retorna a query pronta para o BD</returns>
        private static string insertQuery()
        {
            string insertString = "INSERT INTO Cliente" +
                " (id, nome, endereco, local, telefone_1, telefone_2)" + 
                " VALUES" + 
                " (null, 'Fulano da Silva', 'Rua Princesa Alice, n° 350'," + 
                " 'Instituto Bela', '163333333', '162222222'); ";
            insertString += "INSERT INTO Produto" +
                " (id, nome, preco)" +
                " VALUES" +
                " (null, 'Boneca Bharbie', '8230'), " +
                " (null, 'Celular Zéfone 2', '123099'), " +
                " (null, 'Cafeteira Java', '45385'); ";
            insertString += "INSERT INTO Tipo(" +
                " id, nome, descricao)" +
                " VALUES" +
                " (null, 'Eletrônicos', 'Celulares, computadores...'), " +
                " (null, 'Brinquedos', 'Brinquedos diversos'); ";
            insertString += "INSERT INTO Orcamento" + 
                " (id, id_cliente, data, id_tipo, desconto, status) " +
                " VALUES" + 
                " (null, '1', '10/03/1981', '1', '0', 'Pendente'); ";
            insertString += "INSERT INTO Item" +
                " (id, id_orcam, id_produto, preco_item, quantidade) " +
                " VALUES" +
                " (null, '1', '1', '8050', '2'); ";

            return insertString;
        }
    }
}
