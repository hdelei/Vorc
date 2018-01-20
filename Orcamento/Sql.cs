using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Orcamento
{
    class Sql
    {
        string connStr = @"Data Source = "
            + Properties.Settings.Default.connectionString
            + ";foreign keys = true;datetimeformat=CurrentCulture;";

        //string connStr = @"Data Source = " 
        //    + "C:/Users/user/Documents/Visual Studio 2015/Projects/Orcamento novoBD/vorcDB.db;" 
        //    + "foreign keys = true;datetimeformat=CurrentCulture;";        

        SQLiteConnection conn;       
        SQLiteCommand cmd;
        SQLiteDataReader drt;
        DataTable datatable;

        int insertId = 0;
        string query;

        public int InsertId
        {
            get { return insertId; }
        }

        public DataTable Datatable
        {
            get { return datatable; }
        }

        public void Select(string table, string filter)
        {            
            query = "SELECT * FROM " + table +
                    " WHERE nome LIKE '" + filter + "%';" ;

            try
            {
                conn = new SQLiteConnection(connStr);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                drt = cmd.ExecuteReader();                
                datatable = new DataTable();
                datatable.Load(drt);
                
                conn.Close();
            }
            catch (Exception e)
            {                
                MessageBox.Show("O seguinte erro está impedindo o correto " + 
                    "funcionamento do aplicativo: \r\n" + e.Message);
            }
        }

        public int Delete(string table, string id)
        {
            query = "DELETE FROM "+ table +
                    " WHERE id = '" + id + "';";

            int returnValue = 0;

            try
            {
                conn = new SQLiteConnection(connStr);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                returnValue = cmd.ExecuteNonQuery();                
                conn.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu o seguinte erro: \n" + e.Message);
            }
            return returnValue;
        }

        public int Insert(string table, string[] values)
        {
            int returnValue = 0;

            string auxValues = "";
            foreach (string value in values)
            {
                auxValues += ",'" + value + "'";
            }

            query = "INSERT INTO " + table +
                    " VALUES(null" + auxValues + ")";

            try
            {
                conn = new SQLiteConnection(connStr);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                returnValue = cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT last_insert_rowid();";
                insertId = Convert.ToInt32((long)cmd.ExecuteScalar());
                conn.Close();                
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu o seguinte erro: \n" + e.Message);
            }

            return returnValue;
        }

        public int Update(string[] values)
        {
            UpdateQuery(values);

            int returnValue = 0;
            
            try
            {
                conn = new SQLiteConnection(connStr);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                returnValue = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu o seguinte erro: \n" + e.Message);
            }

            return returnValue;
        }

        
        public void UpdateQuery(string[] values)//Método auxiliar do Update
        {
            // [0] contém a tabela, [1...] demais valores
            switch (values[0])
            {
                case "Cliente":
                    query = "UPDATE Cliente" +
                    " SET nome = '" + values[2] + "', endereco = '" + values[3] +
                    "', local = '" + values[4] + "', telefone_1 = '" + values[5] +
                    "', telefone_2 = '" + values[6] +
                    "' WHERE id = " + values[1] + ";";
                    break;
                case "Produto":
                    query = "UPDATE Produto" +
                    " SET nome = '" + values[2] +
                    "', preco = " + values[3] +
                    " WHERE id = " + values[1] + ";";
                    break;
                case "Tipo":
                    query = "UPDATE Tipo" +
                    " SET nome = '" + values[2] +
                    "', descricao = '" + values[2] +
                    "' WHERE id = " + values[1] + ";";
                    break;
                case "Expirados":
                    query = "UPDATE Orcamento" +
                            " SET status = 'Expirado'" +
                            " WHERE(status = 'Pendente') AND (data < '" + values[1] + "');";
                    break;
                case "Orcamento Status":
                    query = "Update Orcamento" +
                        " SET status = '" + values[2] + "'" +
                        " WHERE id = " + values[1] + ";";
                    break;
                case "Orcamento Date":
                    query = "Update Orcamento" +
                        " SET data = '" + values[2] + "'," +
                        " status = '" + values[3] + "'" + 
                        " WHERE id = " + values[1] + ";";
                    break;
            }
        }

        public string CustomSelect(string customQuery)
        {
            string message;
            try
            {
                conn = new SQLiteConnection(connStr);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = customQuery;
                cmd.ExecuteNonQuery();
                drt = cmd.ExecuteReader();
                datatable = new DataTable();
                datatable.Load(drt);                
                conn.Close();

                message = "Success";         
                
            }
            catch (Exception e)
            {                
                message = e.Message;                
            }
            return message;
        }        
    }
}
