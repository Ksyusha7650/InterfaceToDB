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
    
    public partial class ManagerForm : Form
    {
        
        EnterForm mainForm;
        List<string> producedProducts;
        List<int> warehouses;
        public ManagerForm(EnterForm form)
        {
            InitializeComponent();
            mainForm = form;
            mainForm.Hide();
            producedProducts = DataBase.GetProducts();
            foreach (string prodProduce in producedProducts)
            {
                comboBoxProduct.Items.Add(prodProduce);
            }
            warehouses = DataBase.GetWarehouses();
            foreach (int id_warehouse in warehouses)
            {
                comboBoxWh.Items.Add(id_warehouse);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //TODO: проверка на пустые значения
            string product = comboBoxProduct.SelectedItem.ToString();
            int warehouse = Int32.Parse(comboBoxWh.SelectedItem.ToString());
            int amount = (int)numericUpDownAmount.Value;
            int id_product = DataBase.GetIdProduct(product);
            DataBase.InsertProdOrderToList(id_product, amount, warehouse);
            MessageBox.Show("Added!");
        }

        private void showRestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorageForm storageForm = new StorageForm();
            storageForm.ShowDialog();
        }

        private void showRestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowOrders showOrders = new ShowOrders();
            showOrders.ShowDialog();
        }
    }
}
