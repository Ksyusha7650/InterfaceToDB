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
    public partial class LogisticsSpecialistForm : Form
    {
        EnterForm mainForm;
        public List<Int32> whTo_From, whTrans;
        public LogisticsSpecialistForm(EnterForm form)
        {
            InitializeComponent();
            mainForm = form;
            mainForm.Hide();
            whTo_From = GetLists.GetWarehouses(0);
            foreach (int i in whTo_From)
            {
                comboBoxWhFrom.Items.Add(i);
                comboBoxWhTo.Items.Add(i);
            }
            whTrans = GetLists.GetWarehouses(1);
            foreach (int i in whTrans)
            {
                comboBoxWhTrans.Items.Add(i);
            }
        }

        private void showRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoutes showRoutes = new ShowRoutes();
            showRoutes.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void showWarehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWarehouses showWarehouses = new ShowWarehouses();
            showWarehouses.ShowDialog();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                int warehouseTo = Int32.Parse(comboBoxWhTo.SelectedItem.ToString());
                int warehouseFrom = Int32.Parse(comboBoxWhFrom.SelectedItem.ToString());
                int warehouseTrans = Int32.Parse(comboBoxWhTrans.SelectedItem.ToString());
                int hours = (int)hoursInput.Value;
                int minss = (int)minsInput.Value;
                int secs = (int)secsInput.Value;
                TimeSpan time = new TimeSpan(hours, minss, secs);
                Procedures.InsertRouteToList(warehouseFrom, warehouseTo, warehouseTrans, time);
            }
            catch
            {
                MessageForm messageForm = new MessageForm("Input value!");
                messageForm.ShowDialog();
            }

        }
    }
}
