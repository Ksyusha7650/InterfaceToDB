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
    public struct Shipment
    {
        public int ID;
        public int id_prod;
        public DateTime date;
        public int id_order;

        public Shipment(int iD, int id_prod, DateTime date, int id_order)
        {
            ID = iD;
            this.id_prod = id_prod;
            this.date = date;
            this.id_order = id_order;
        }
    }
    public partial class ShipmentForm : Form
    {
        public List<Shipment> shipments;
       
        public ShipmentForm()
        {
            InitializeComponent();
            ShowList();
        }
        private void ShowList()
        {
            shipments = GetLists.Shipments();
            tableShipments.Rows.Clear();
            foreach (Shipment shipment in shipments)
            {
                string productName = GetString.ProductName(shipment.id_prod);
                tableShipments.Rows.Add(shipment.ID, productName, shipment.date, shipment.id_order);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
