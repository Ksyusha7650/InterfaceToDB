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
    public partial class ShowOrders : Form
    {
        public List<ProductionOrders> productionOrders;
        public ShowOrders()
        {
            InitializeComponent();
            productionOrders = DataBase.GetProdOrdersList();
            MakeOrdersList();
        }

        private void MakeOrdersList()
        {
            DataGridViewButtonColumn col = (DataGridViewButtonColumn)listOrders.Columns[6];
            col.Text = "Write-off";
            col.UseColumnTextForButtonValue = true;
            foreach (ProductionOrders prod in productionOrders)
            {
                DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                listOrders.Rows.Add(prod.Id, prod.date, prod.amount, prod.id_prod, prod.status
                   , prod.id_warehouse, buttonCell);
            }
            /*for(int index = 1; index < listButtons.Rows.Count; index++)
            {
                DataGridViewButtonCell button = (DataGridViewButtonCell)listButtons.Rows[index].Cells[0];
               
                    DataGridViewButtonCell buttonDis = listButtons.Rows[index].Cells[0];
                    buttonDis.Enabled = false;
                }
            }*/

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*            int indexCol = listOrders.SelectedColumns[0].Index;
            if (indexCol == 6)
            {*/
                int index = listOrders.SelectedCells[0].RowIndex;
                int ID_Order = (int)listOrders.Rows[index].Cells[0].Value;
                bool check = DataBase.CheckIDToDevelop(ID_Order);
                if (check)
                {
                    WriteOffMaterial writeOff = new WriteOffMaterial(ID_Order);
                    writeOff.ShowDialog();
                }
           // }
        }
    }
}
