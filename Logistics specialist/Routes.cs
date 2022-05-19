using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceToDB
{
    public struct Route
    {
        public int Id;
        public TimeSpan duration;
        public int id_warehouseTo;
        public int id_warehouseFrom;
        public int id_warehouseTransit;

        public Route(int id, TimeSpan duration, int id_warehouseTo, int id_warehouseFrom, int id_warehouseTransit)
        {
            Id = id;
            this.duration = duration;
            this.id_warehouseTo = id_warehouseTo;
            this.id_warehouseFrom = id_warehouseFrom;
            this.id_warehouseTransit = id_warehouseTransit;
        }
    }
}
