using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceToDB
{

    public struct Warehouse
    {
       public int Id;
       public string Name;
       public bool IsTransit;

        public Warehouse(int id, string name, bool isTransit)
        {
            Id = id;
            Name = name;
            IsTransit = isTransit;
        }
    }
    public partial class ShowWarehouses : Form
    {
        public List<Warehouse> Warehouses;  
       
        public ShowWarehouses()
        {
            InitializeComponent();
            Warehouses = DataBase.GetWarehousesList();
            foreach(Warehouse warehouse in Warehouses)
            {
                tableWarehouses.Rows.Add(warehouse.Id, warehouse.Name, warehouse.IsTransit);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
