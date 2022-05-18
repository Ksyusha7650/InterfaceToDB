using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceToDB
{
    public struct ProductionOrders
    {
        public int Id;
        public DateTime date;
        public int amount;
        public int id_prod;
        public char status;
        public int id_warehouse;

        public ProductionOrders(int id, DateTime date, int amount, int id_prod, char status, int id_warehouse)
        {
            Id = id;
            this.date = date;
            this.amount = amount;
            this.id_prod = id_prod;
            this.status = status;
            this.id_warehouse = id_warehouse;
        }

        public string ListProductionOrder
        {
            get
            {
                return "Id order: " + Id + " date of order: " + date + " product: " + DataBase.ProductName(id_prod)
                    + " amount: " +  amount + " status: " + status + "warehouse: " + id_warehouse;
            }
        }
    }
}
