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
    public partial class ShowRoutes : Form
    {
        public List<Route> routes;

        public ShowRoutes()
        {
            InitializeComponent();
            routes = GetLists.GetRoutesList();
            foreach(Route route in routes)
            {
                tableRoutes.Rows.Add(route.Id, route.duration,  route.id_warehouseTo, route.id_warehouseFrom,
                    route.id_warehouseTransit);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
