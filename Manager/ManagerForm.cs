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
    public struct TransferOrder
    {
        public int Id;
        public int ID_Route;
        public string Status;
        public DateTime dateCreated;
        public DateTime dateShipment;
        public DateTime dateRecieving;

        public TransferOrder(int id, int iD_Route, string status, DateTime dateCreated, 
            DateTime dateShipment, DateTime dateRecieving)
        {
            Id = id;
            ID_Route = iD_Route;
            Status = status;
            this.dateCreated = dateCreated;
            this.dateShipment = dateShipment;
            this.dateRecieving = dateRecieving;
        }
    }

    public partial class ManagerForm : Form
    {
        EnterForm mainForm;
        List<TransferOrder> listOrders;
        public List<Int32> whTo_From;
        public ManagerForm(EnterForm form)
        {
            InitializeComponent();
            mainForm = form;
            mainForm.Hide();
            whTo_From = GetLists.GetWarehouses(0);
            foreach (int i in whTo_From)
            {
                comboBoxFrom.Items.Add(i);
                comboBoxTo.Items.Add(i);
            }
            ShowList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int index = tableOrders.SelectedCells[0].RowIndex;
            int Id = (int)tableOrders.Rows[index].Cells[0].Value;
            AddShipmentForm shipmentForm = new AddShipmentForm(Id);
            shipmentForm.ShowDialog();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            int id_to = Int32.Parse(comboBoxTo.SelectedItem.ToString());
            int id_from = Int32.Parse(comboBoxFrom.SelectedItem.ToString());
            Procedures.InsertOrderToList(id_to, id_from);
            ShowList();
        }

        private void showRestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorageForm storageForm = new StorageForm();
            storageForm.ShowDialog();
        }

        private void showRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoutes showRoutes = new ShowRoutes();
            showRoutes.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            MessageWithQuestion message = new MessageWithQuestion();
            message.ShowDialog();
            if (MessageWithQuestion.toDelete)
            {
                int index = tableOrders.SelectedCells[0].RowIndex;
                int Id = (int)tableOrders.Rows[index].Cells[0].Value;
                Procedures.DeleteOrderFromList(Id);
                ShowList();
            }
        }
    }
}
