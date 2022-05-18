using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceToDB
{
    public struct Storage
    {
        public int id_prod;
        public int id_warehouse;
        public int amount;

        public Storage(int id_warehouse, int id_prod, int amount)
        {
            this.id_prod = id_prod;
            this.id_warehouse = id_warehouse;
            this.amount = amount;
        }
    }
}
