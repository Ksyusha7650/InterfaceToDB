﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfaceToDB
{
    public static class Insert
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
        public static void InsertMaterialsToList(int id_order, int id_operation, int id_product, int amount)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "AddWriteOff";
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@par_id_order", id_order);
            myCommand.Parameters.AddWithValue("@par_id_operation", id_operation);
            myCommand.Parameters.AddWithValue("@par_id_product", id_product);
            myCommand.Parameters.AddWithValue("@par_amount", amount);
            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Недостаточно списываемого материала.");
            }
            conn.Close();
        }

        public static void InsertRouteToList(int id_warehouseFrom, int id_warehouseTo, int id_warehouseTrans, TimeSpan dur)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.Parameters.AddWithValue("@wh_to", id_warehouseTo);
            myCommand.Parameters.AddWithValue("@wh_from", id_warehouseFrom);
            myCommand.Parameters.AddWithValue("@wh_trans", id_warehouseTrans);
            myCommand.Parameters.AddWithValue("@duration", dur);
            myCommand.CommandText = "insert into routes set Duration = @duration, " +
                "ID_WarehouseReciever = @wh_to, ID_WarehouseSender = @wh_from, ID_WarehouseTransit = @wh_trans;";
            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static void InsertProdOrderToList(int id_product, int amount, int id_wh)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "AddProdOrder";
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@par_id_warehouse", id_wh);
            myCommand.Parameters.AddWithValue("@par_id_product", id_product);
            myCommand.Parameters.AddWithValue("@par_amount", amount);
            myCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
