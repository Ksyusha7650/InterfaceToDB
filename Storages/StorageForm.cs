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
    public partial class StorageForm : Form
    {
        List<int> warehouses;
        List<string> products;
        List<Storage> storageList;
        public StorageForm()
        {
            InitializeComponent();
            warehouses = GetLists.GetWarehouses(-1);
            foreach (int id_warehouse in warehouses)
            {
                comboBoxWh.Items.Add(id_warehouse);
            }
            products = GetLists.GetProducts(-1);
            foreach (string product in products)
            {
                comboBoxProduct.Items.Add(product);
            }
            storageList = GetLists.GetStorageList(-1, -1);
            ShowStorages();
        }

        private void ShowStorages()
        {
            storageTable.Rows.Clear();
            foreach (Storage s in storageList)
            {
                string productName = GetString.ProductName(s.id_prod);
                storageTable.Rows.Add(s.id_warehouse, productName, s.amount);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int id_product = 0, id_warehouse = 0;
            if (comboBoxProduct.SelectedIndex == -1)
                id_product = -1;
            else
            {
                string product = comboBoxProduct.SelectedItem.ToString();
                id_product = GetInt.GetIdProduct(product);
            }
            if (comboBoxWh.SelectedIndex == -1)
                id_warehouse = -1;
            else
                id_warehouse = Int32.Parse(comboBoxWh.SelectedItem.ToString());
            storageList = GetLists.GetStorageList(id_warehouse, id_product);
            ShowStorages();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxWh.SelectedIndex = -1;
            comboBoxProduct.SelectedIndex = -1;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
