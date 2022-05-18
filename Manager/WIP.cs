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
    public struct WorkInProcess
    {
        public int Id;
        public int id_order;
        public int amount;
        public int id_prod;

        public WorkInProcess(int id, int id_order, int amount, int id_prod)
        {
            Id = id;
            this.id_order = id_order;
            this.amount = amount;
            this.id_prod = id_prod;
        }
    }
    public partial class WIP : Form
    {
        public List<WorkInProcess> works;
        public WIP()
        {
            InitializeComponent();
            works = DataBase.GetWIPList();
            foreach (WorkInProcess work in works)
            {
                WIPTable.Rows.Add(work.Id, work.id_order, work.amount, work.id_prod);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
