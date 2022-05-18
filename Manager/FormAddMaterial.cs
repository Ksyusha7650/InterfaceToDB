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
    public partial class FormAddMaterial : Form
    {
        List<WriteOffProd> materials;
        WriteOffMaterial formMat;
        List<string> materialNames, prodOperations;
        public FormAddMaterial(List<WriteOffProd> list, WriteOffMaterial form)
        {
            InitializeComponent();
            materials = list;
            formMat = form;
            materialNames = DataBase.GetProducts();
            foreach(string materialName in materialNames)
            {
                comboBoxProduct.Items.Add(materialName);
            }
            prodOperations = DataBase.GetOperations();
            foreach (string operationName in prodOperations)
            {
                comboBoxOperation.Items.Add(operationName);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if ((comboBoxProduct.SelectedIndex != -1) && (comboBoxOperation.SelectedIndex != -1)
                && (numericUpDownAmount.Value > 0))
            {
                string operation = comboBoxOperation.SelectedItem.ToString();
                string product = comboBoxProduct.SelectedItem.ToString();
                int id_operation = DataBase.GetIdOperation(operation);
                int id_product = DataBase.GetIdProduct(product);
                int amount = (int)numericUpDownAmount.Value;
                int id_order = formMat.order;
                DataBase.InsertMaterialsToList(id_order, id_operation, id_product, amount);
                formMat.tableMaterials.Rows.Clear();
                materials = DataBase.GetWriteOffList(id_order);
                foreach (WriteOffProd prod in materials)
                {
                    product = DataBase.ProductName(prod.Product);
                    operation = DataBase.OperationName(prod.Operation);
                    formMat.tableMaterials.Rows.Add(product, prod.AmountProducts, operation);
                }
            }
            this.Close();
        }
    }
}
