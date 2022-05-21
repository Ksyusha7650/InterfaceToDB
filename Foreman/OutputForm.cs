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
    public struct OutputProd
    {
        public int Id;
        public int amount;
        public DateTime date;
        public int id_wh;
        public int id_order;
        public int id_prod;

        public OutputProd(int id, int amount, DateTime date, int id_wh, int id_order, int id_prod)
        {
            Id = id;
            this.amount = amount;
            this.date = date;
            this.id_wh = id_wh;
            this.id_prod = id_prod;
            this.id_order = id_order;
        }
    }
    public partial class OutputForm : Form
    {
        public List<OutputProd> OutputProdList;
        public OutputForm()
        {
            InitializeComponent();
            OutputProdList = GetLists.GetOutputProdList();
            foreach(OutputProd outputProd in OutputProdList)
            {
                string prodName = GetString.ProductName(outputProd.id_prod);
                tableOutput.Rows.Add(outputProd.Id, outputProd.amount,outputProd.date, outputProd.id_wh,
                    outputProd.id_order, prodName);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
