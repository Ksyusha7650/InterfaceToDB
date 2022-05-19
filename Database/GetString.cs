using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfaceToDB
{
    public static class GetString
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

        public static string OperationName(int id_operation)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            string name = "";
            myCommand.CommandText = "select OperationName from operations where ID_Operation = " + id_operation;
            using (var reader = myCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                }
            }
            conn.Close();
            return name;
        }

        public static string ProductName(int id_prod)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            string name = "";
            myCommand.CommandText = "select ProductName from products where ID_Product = " + id_prod;
            using (var reader = myCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                }
            }
            conn.Close();
            return name;

        }
    }
}
