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
    public struct WorkInProcess
    {
        public int Id;
        public int id_order;
        public int amount;
        public int id_prod;

        public WorkInProcess(int id, int id_order, int amount, int id_prod)
        {
            Id = id;
            this.id_order = id_order;
            this.amount = amount;
            this.id_prod = id_prod;
        }
    }
    public partial class WIP : Form
    {
        public List<WorkInProcess> works;
        public List<Int32> orders;
        public WIP()
        {
            InitializeComponent();
            works = GetLists.GetWIPList(-1);
            ShowWIP();
            orders = GetLists.GetOrdersInWorkInProcess();
            foreach (int order in orders)
            {
                comboBoxOrders.Items.Add(order);
            }
        }

        private void ShowWIP()
        {
            WIPTable.Rows.Clear();
            foreach (WorkInProcess work in works)
            {
                string productName = GetString.ProductName(work.id_prod);
                WIPTable.Rows.Add(work.Id, work.id_order, productName, work.amount);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            works = GetLists.GetWIPList(Int32.Parse(comboBoxOrders.SelectedItem.ToString()));
            ShowWIP();
        }
    }
}
