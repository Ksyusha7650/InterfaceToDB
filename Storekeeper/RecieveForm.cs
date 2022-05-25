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

    public struct Recieving
    {
        public int ID;
        public int id_prod;
        public DateTime date;
        public int id_order;

        public Recieving(int iD, int id_prod, DateTime date, int id_order)
        {
            ID = iD;
            this.id_prod = id_prod;
            this.date = date;
            this.id_order = id_order;
        }
    }
    public partial class RecieveForm : Form
    {
        private List<Recieving> recievings;   
        public RecieveForm()
        {
            InitializeComponent();
            ShowList();
        }
        private void ShowList()
        {
            recievings = GetLists.Recievings();
            tableShipments.Rows.Clear();
            foreach (Recieving recieving in recievings)
            {
                string productName = GetString.ProductName(recieving.id_prod);
                tableShipments.Rows.Add(recieving.ID, productName, recieving.date, recieving.id_order);
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
