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
    public partial class MessageWithQuestion : Form
    {
        public bool answer = false;
        private int type = 0;
        public MessageWithQuestion (int type = 0)
        {
            InitializeComponent();
            this.type = type;
            string text = (type == 0) ? "Are you sure?" : "You have orders with same routes. Join orders?";
            labelQuestion.Text = text;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            answer = true;
            this.Close();
        }
    }
}
