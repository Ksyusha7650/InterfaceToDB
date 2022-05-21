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
    public partial class AddShipmentForm : Form
    {
        List<string> products;
        int id_order;
        public AddShipmentForm(int par_id_order)
        {
            InitializeComponent();
            products = GetLists.GetProducts(0);
            foreach (string materialName in products)
            {
                comboBoxProduct.Items.Add(materialName);
            }
            id_order = par_id_order;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string product = comboBoxProduct.SelectedItem.ToString();
                int id_product = GetInt.GetIdProduct(product);
                int amount = (int)numericUpDownAmount.Value;
                Procedures.InsertShippingToList(amount, id_order, id_product);
            }
            catch
            {
                MessageBox.Show("Values not correct!");
            }

        }
    }
}
