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
    public partial class EnterForm : Form
    {

        public enum USERS
        {
            Foreman, LogisticsSpecialist, Manager, Storekeeper
        }
        public EnterForm()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int userIndex = comboBoxUsers.SelectedIndex;
            USERS userSelected = (USERS) userIndex;
            switch (userSelected)
            {
                case USERS.Foreman:
                    {
                        ForemanForm form = new ForemanForm(this);
                        form.ShowDialog();
                        break;
                    }
                    case USERS.LogisticsSpecialist:
                    {
                        LogisticsSpecialistForm form = new LogisticsSpecialistForm(this);
                        form.ShowDialog();
                        break;
                    }
                   
                    case USERS.Manager:
                    {
                        ManagerForm form = new ManagerForm(this);
                        form.ShowDialog();
                        break;
                    }
            }
            
        }
    }
}
