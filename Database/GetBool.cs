using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfaceToDB
{
    public static class GetBool
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

        public static bool CheckIDToDevelop(int idProdOrder)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.Parameters.AddWithValue("@Id", idProdOrder);
            myCommand.CommandText = "select exists (select * from productionorder" +
                " where ID_Order = @Id and `Status` = 'O');";
            bool check = true;
            using (var reader = myCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    check = reader.GetBoolean(0);
                }
            }
            conn.Close();
            return check;
        }
    }
}
