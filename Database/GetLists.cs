using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace InterfaceToDB
{
    public enum FieldsInWip
    {
        ID_ORDER = -1, 
    }
    public static class GetLists
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
            conn.Close();
            return writeOffProds;
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
            conn.Close();
            return prodOrders;
        }
        public static List<Route> GetRoutesList()
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "SELECT * FROM routes";
            List<Route> routes = new List<Route>();
            using (var reader = myCommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int Id = reader.GetInt32(0);
                        TimeSpan time = reader.GetTimeSpan(1);
                        int id_warehouseFrom = reader.GetInt32(2);
                        int id_warehouseTo = reader.GetInt32(3);
                        int id_warehouseTransit = reader.GetInt32(4);
                        Route route = new Route(Id, time, id_warehouseTo, id_warehouseFrom, id_warehouseTransit);
                        routes.Add(route);
                    }
                }
            }
            conn.Close();
            return routes;
        }

        public static List<OutputProd> GetOutputProdList()
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "SELECT * FROM outputproducts";
            List<OutputProd> outputProdList = new List<OutputProd>();
            using (var reader = myCommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int Id = reader.GetInt32(0);
                        int amount = reader.GetInt32(1);
                        DateTime time = reader.GetDateTime(2);
                        int id_warehouse = reader.GetInt32(3);
                        int id_order = reader.GetInt32(4);
                        int id_product = reader.GetInt32(5);
                        OutputProd outputProd = new OutputProd(Id, amount, time, id_warehouse, id_order, id_product);
                        outputProdList.Add(outputProd);
                    }
                }
            }
            conn.Close();
            return outputProdList;
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
                else
                {
                    myCommand.Parameters.AddWithValue("@ID_Warehouse", par_id_wh);
                    myCommand.Parameters.AddWithValue("@ID_Product", par_id_prod);
                    myCommand.CommandText = "SELECT * FROM storage where ID_Warehouse = @ID_Warehouse and ID_Product = @ID_Product";
                }
            }
            List<Storage> storageList = new List<Storage>();
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
            conn.Close();
            return storageList;

        }

        public static List<Warehouse> GetWarehousesList()
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "SELECT * FROM warehouse;";
            var reader = myCommand.ExecuteReader();
            List<Warehouse> warehouses = new List<Warehouse>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    bool isTrans = reader.GetBoolean(2);
                    Warehouse warehouse = new Warehouse(id, name, isTrans);
                    warehouses.Add(warehouse);
                }
            }
            conn.Close();
            return warehouses;
        }

        public static List<String> GetProducts(int isFinish)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            if (isFinish == -1)
                myCommand.CommandText = "select ProductName from products";
            else
            {
                myCommand.Parameters.AddWithValue("@isFinish", isFinish);
                myCommand.CommandText = "select ProductName from products where IsFinish = @isFinish";
            }
            var reader = myCommand.ExecuteReader();
            List<String> products = new List<String>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    products.Add(reader.GetString(0));
                }
            }
            conn.Close();
            return products;
        }
        public static List<WorkInProcess> GetWIPList(int id_order)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            if (id_order == -1)
                myCommand.CommandText = "SELECT * FROM workinprocess;";
            else
            {
                myCommand.Parameters.AddWithValue("@id_order", id_order);
                myCommand.CommandText = "select * from workinprocess where ID_Order = @id_order";
            }
            var reader = myCommand.ExecuteReader();
            List<WorkInProcess> workInProcesses = new List<WorkInProcess>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    int order = reader.GetInt32(1);
                    int amount = reader.GetInt32(2);
                    int id_prod = reader.GetInt32(3);
                    WorkInProcess workInProcess = new WorkInProcess(id, order, amount, id_prod);
                    workInProcesses.Add(workInProcess);
                }
            }
            conn.Close();
            return workInProcesses;
        }
        public static List<Int32> GetOrdersInWorkInProcess()
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "select distinct w.ID_Order from workinprocess w inner join productionorder p" +
                " on w.ID_Order = p.ID_Order where p.`Status` = 'D';";
            var reader = myCommand.ExecuteReader();
            List<int> warehouses = new List<int>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    warehouses.Add(reader.GetInt32(0));
                }
            }
            conn.Close();
            return warehouses;
        }

        public static List<Int32> GetWarehouses(int isTransit)
        {
            Connect();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            if (isTransit == -1)
                myCommand.CommandText = "select Id_Warehouse from warehouse";
            else
            {
                myCommand.Parameters.AddWithValue("@isTransit", isTransit);
                myCommand.CommandText = "select Id_Warehouse from warehouse where IsTransit = @isTransit";
            }
            var reader = myCommand.ExecuteReader();
            List<int> warehouses = new List<int>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    warehouses.Add(reader.GetInt32(0));
                }
            }
            conn.Close();
            return warehouses;
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
            conn.Close();
            return operations;
        }
    }
}
