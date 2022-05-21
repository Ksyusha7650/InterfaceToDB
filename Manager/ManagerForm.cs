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
        public ManagerForm(EnterForm form)
        {
            InitializeComponent();
            mainForm = form;
            mainForm.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int index = tableOrders.SelectedCells[0].RowIndex;
            int Id = (int)tableOrders.Rows[index].Cells[0].Value;
            AddShipmentForm shipmentForm = new AddShipmentForm(Id);
            shipmentForm.ShowDialog();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
