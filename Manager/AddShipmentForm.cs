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
    public struct ShippingProducts
    {
        public int Id;
        public int ID_Product;
        public int Amount;
        public int ID_TransferOrder;

        public ShippingProducts(int id, int iD_Product, int amount, int iD_TransferOrder)
        {
            Id = id;
            ID_Product = iD_Product;
            Amount = amount;
            ID_TransferOrder = iD_TransferOrder;
        }
    }

    public partial class AddShipmentForm : Form
    {
        List<string> products;
        int id_order = 0, id_prodSelected = 0;
        List<ShippingProducts> shippingProducts;
        public AddShipmentForm(int par_id_order)
        {
            InitializeComponent();
            id_order = par_id_order;
            products = GetLists.GetProductsFromWh(id_order);
            foreach (string product in products)
            {
                comboBoxProduct.Items.Add(product);
            }
            LoadListShipments();
        }

        private void LoadListShipments()
        {
            tableShipments.Rows.Clear();
            shippingProducts = GetLists.GetShippingProductsList(id_order);
            foreach (ShippingProducts shippingProduct in shippingProducts)
            {
                string productName = GetString.ProductName(shippingProduct.ID_Product);
                tableShipments.Rows.Add(shippingProduct.Id, productName, shippingProduct.Amount);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string product = comboBoxProduct.SelectedItem.ToString();
                int id_product = GetInt.GetIdProduct(product);
                int amount = (int)numericUpDownAmount.Value;
                Procedures.InsertShippingToList(amount, id_order, id_product);
                MessageForm message = new MessageForm("Added!");
                message.ShowDialog();
                LoadListShipments();
            }
            catch
            {
                MessageForm message = new MessageForm("Values not correct!");
                message.ShowDialog();
            }

        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodName = comboBoxProduct.SelectedItem.ToString();
            id_prodSelected = GetInt.GetIdProduct(prodName);
            int avaibleAmount = GetInt.GetAmountProduct(id_prodSelected, id_order);
            labelAmount.Text = avaibleAmount.ToString();
            numericUpDownAmount.Maximum = avaibleAmount;
        }
    }
}
