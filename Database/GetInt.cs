using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfaceToDB
{
    public static class GetInt
    {
        static MySqlConnection conn;
        public static void Connect()
        {
            string connectionString = "server=localhost;uid=root;" +
            "pwd=04042002Mm!;database=prod_clothes";
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static Int32 GetIdOperation(string name)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.Parameters.AddWithValue("@Name", name);
            int operation = 0;
            myCommand.CommandText = "select ID_Operation from operations where OperationName = @Name";
            using (var reader = myCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    operation = reader.GetInt32(0);
                }
            }
            conn.Close();
            return operation;
        }

        public static Int32 GetIdProduct(string name)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.Parameters.AddWithValue("@Name", name);
            myCommand.CommandText = "select ID_Product from products where ProductName = @Name";
            int product = 0;
            using (var reader = myCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    product = reader.GetInt32(0);
                }
            }
            conn.Clone();
            return product;
        }
    }
}
