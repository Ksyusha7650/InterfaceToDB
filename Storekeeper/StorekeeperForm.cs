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
    public partial class StorekeeperForm : Form
    {
        EnterForm mainForm;
        List<TransferOrder> listOrders;
        public StorekeeperForm(EnterForm form)
        {
            InitializeComponent();
            mainForm = form;
            mainForm.Hide();
            ShowList();
        }
        private void ShowList()
        {
            tableOrders.Rows.Clear();
            listOrders = GetLists.GetTransferOrdersList();
            foreach (TransferOrder order in listOrders)
            {
                if (order.dateShipment == DateTime.MinValue)
                    tableOrders.Rows.Add(order.Id, order.ID_Route, order.Status, order.dateCreated,
                    "-", "-");
                else if (order.dateRecieving == DateTime.MinValue)
                    tableOrders.Rows.Add(order.Id, order.ID_Route, order.Status, order.dateCreated,
                    order.dateShipment, "-");
                else
                    tableOrders.Rows.Add(order.Id, order.ID_Route, order.Status, order.dateCreated,
                        order.dateShipment, order.dateRecieving);
            }
        }
        private void buttonShip_Click(object sender, EventArgs e)
        {
            int index = tableOrders.SelectedCells[0].RowIndex;
            int Id = (int)tableOrders.Rows[index].Cells[0].Value;
            Procedures.Ship(Id);
        }

        private void shipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorageForm storageForm = new StorageForm();
            storageForm.ShowDialog();
        }

        private void buttonRecieve_Click(object sender, EventArgs e)
        {

        }
    }
}
