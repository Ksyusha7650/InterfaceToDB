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
            producedProducts = GetLists.GetProducts(1);
            foreach (string prodProduce in producedProducts)
            {
                comboBoxProduct.Items.Add(prodProduce);
            }
            warehouses = GetLists.GetWarehouses(0);
            foreach (int id_warehouse in warehouses)
            {
                comboBoxWh.Items.Add(id_warehouse);
            }
            foreach (ToolStripMenuItem item in menu.Items)
            {
                SetColorMenuStrip(item);
            }
            menu.Renderer = new ToolStripProfessionalRenderer(new Colors());
        }
        public void SetColorMenuStrip(ToolStripMenuItem item)
        {
            item.ForeColor = Color.White;
            foreach (ToolStripMenuItem item2 in item.DropDownItems)
            {
                SetColorMenuStrip(item2);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //TODO: проверка на пустые значения
            try
            {
                string product = comboBoxProduct.SelectedItem.ToString();
                int warehouse = Int32.Parse(comboBoxWh.SelectedItem.ToString());
                int amount = (int)numericUpDownAmount.Value;
                int id_product = GetInt.GetIdProduct(product);
                Insert.InsertProdOrderToList(id_product, amount, warehouse);
                MessageBox.Show("Added!");
            }
            catch
            {
                MessageBox.Show("Input value!");
            }
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

        private void shoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WIP wip = new WIP();
            wip.ShowDialog();
        }
    }
}
