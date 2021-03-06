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
    public struct WriteOffProd
    {
        public int Id;
        public int Operation;
        public int Product;
        public int AmountProducts;
        public DateTime DateOfWriteOff;
        public int ID_Order;

        public WriteOffProd(int Id, int ID_Order, int operation, int product, int amountProducts, DateTime date) : this()
        {
            this.Id = Id;
            this.ID_Order = ID_Order;
            this.Operation = operation;
            this.Product = product;
            this.AmountProducts = amountProducts;
            this.DateOfWriteOff = date; 
        }
    }
    public partial class WriteOffMaterial : Form
    {
        public List<WriteOffProd> writeOffProds;
        public DataGridView tableMaterials;
        public int order;
        
        public WriteOffMaterial(int ID_Order)
        {
            InitializeComponent();
            tableMaterials = dataMaterials;
            order = ID_Order;
            writeOffProds = GetLists.GetWriteOffList(order);
            foreach (WriteOffProd prod in writeOffProds)
            {
               string product = GetString.ProductName(prod.Product);
               string operation = GetString.OperationName(prod.Operation);
                tableMaterials.Rows.Add(product, prod.AmountProducts, operation);
            }
        }

        private void showRestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorageForm storageForm = new StorageForm();
            storageForm.ShowDialog();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            FormAddMaterial addMaterial = new FormAddMaterial(writeOffProds, this);
            addMaterial.ShowDialog();
        }

        private void buttonWriteOff_Click(object sender, EventArgs e)
        {
            writeOffProds = GetLists.GetWriteOffList(order);
            foreach (WriteOffProd prod in writeOffProds)
            {
                Procedures.DoWriteOff(prod.Id);
            }
            
            this.Close();
        }
    }
}
