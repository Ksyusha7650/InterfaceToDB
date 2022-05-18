using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InterfaceToDB
{
    public class DataGridViewDisableButtonCell : DataGridViewButtonCell
    {
        private bool enabledValue;
        public bool Enabled
        {
            get
            {
                return enabledValue;
            }
            set
            {
                enabledValue = value;
            }
        }
        public DataGridViewDisableButtonCell()
        {
            this.enabledValue = true;
            this.Enabled = false;
        }
    }

    internal class Colors : ProfessionalColorTable
    {
        private Color selected()
        {
            Color col = new Color();
            return col = Color.FromArgb(66, 82, 110);
        }
        private Color bgItems()
        {
            Color col = new Color();
            return col = Color.FromArgb(9, 30, 66);
        }
        public override Color MenuItemSelected
        {
            get { return selected(); }
        }
        public override Color ToolStripDropDownBackground
        {
            get { return bgItems(); }
        }
        public override Color ImageMarginGradientBegin
        {
            get { return bgItems(); }
        }
        public override Color ImageMarginGradientEnd
        {
            get { return bgItems(); }
        }
        public override Color ImageMarginGradientMiddle
        {
            get { return bgItems(); }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return selected(); }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get { return selected(); }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return selected(); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return selected(); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return selected(); }
        }
        public override Color MenuItemBorder
        {
            get { return selected(); }
        }
    }

}
