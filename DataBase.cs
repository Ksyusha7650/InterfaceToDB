using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfaceToDB
{
    public static class DataBase
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
            return name;
            conn.Close();
        }

        public static List<WriteOffProd> GetWriteOffList(int id_order)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "Select * from writeoffproducts where ID_Order =" + id_order;
            List<WriteOffProd> writeOffProds = new List<WriteOffProd>();
            using (var reader = myCommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        int amount = reader.GetInt32(1);
                        DateTime date = reader.GetDateTime(2);
                        int operation = reader.GetInt32(3);
                        int product = reader.GetInt32(5);
                        WriteOffProd prod = new WriteOffProd(id, id_order, operation, product, amount, DateTime.Now);
                        writeOffProds.Add(prod);
                    }
                }
            }
            return writeOffProds;
            conn.Close();
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
            return name;
            conn.Close();
        }
        public static List<ProductionOrders> GetProdOrdersList()
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "SELECT * FROM productionorder";
            List<ProductionOrders> prodOrders = new List<ProductionOrders>();
            using (var reader = myCommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int order = reader.GetInt32(0);
                        DateTime date = reader.GetDateTime(1);
                        int amount = reader.GetInt32(2);
                        int id_prod = reader.GetInt32(3);
                        char status = reader.GetChar(4);
                        int id_warehouse = reader.GetInt32(5);
                        ProductionOrders prod = new ProductionOrders(order, date, amount, id_prod, status, id_warehouse);
                        prodOrders.Add(prod);
                    }
                }
            }
            return prodOrders;
            conn.Close();
        }
        public static List<Storage> GetStorageList(int par_id_wh, int par_id_prod)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            if ((par_id_wh == -1) && (par_id_prod == -1)) myCommand.CommandText = "SELECT * FROM storage";
            else
            {
                if (par_id_wh == -1)
                {
                    myCommand.Parameters.AddWithValue("@ID_Product", par_id_prod);
                    myCommand.CommandText = "SELECT * FROM storage where ID_Product = @ID_Product";
                }
                else if (par_id_prod == -1)
                {
                    myCommand.Parameters.AddWithValue("@ID_Warehouse", par_id_wh);
                    myCommand.CommandText = "SELECT * FROM storage where ID_Warehouse = @ID_Warehouse";
                }
                else {
                    myCommand.Parameters.AddWithValue("@ID_Warehouse", par_id_wh);
                    myCommand.Parameters.AddWithValue("@ID_Product", par_id_prod);
                    myCommand.CommandText = "SELECT * FROM storage where ID_Warehouse = @ID_Warehouse and ID_Product = @ID_Product";
                }
            }
            List <Storage> storageList = new List<Storage>();
            using (var reader = myCommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id_warehouse = reader.GetInt32(0);
                        int id_prod = reader.GetInt32(1);
                        int amount = reader.GetInt32(2);
                        Storage storage = new Storage(id_warehouse, id_prod, amount);
                        storageList.Add(storage);
                    }
                }
            }
            return storageList;
            conn.Close();
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
            return operation;
            conn.Close();
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
            return product;
            conn.Clone();
        }

        public static List <String> GetProducts()
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "select ProductName from products";
            var reader = myCommand.ExecuteReader();
            List<String> products = new List<String>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    products.Add(reader.GetString(0)); 
                }
            }
           return products;
           conn.Close();
        }

        public static List<Int32> GetWarehouses()
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "select Id_Warehouse from warehouse";
            var reader = myCommand.ExecuteReader();
            List<int> warehouses = new List<int>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    warehouses.Add(reader.GetInt32(0));
                }
            }
            return warehouses;
            conn.Close();
        }

        public static List<String> GetOperations()
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "select OperationName from operations";
            var reader = myCommand.ExecuteReader();
            List<String> operations = new List<String>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    operations.Add(reader.GetString(0));
                }
            }
            return operations;
            conn.Close();
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Недостаточно списываемого материала.");
            }
            conn.Close();
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
            return check;
            conn.Clone();
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
