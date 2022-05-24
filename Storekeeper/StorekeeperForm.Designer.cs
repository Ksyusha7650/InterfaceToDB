namespace InterfaceToDB
{
    partial class StorekeeperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.showProductionOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recievingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRecieve = new System.Windows.Forms.Button();
            this.buttonShip = new System.Windows.Forms.Button();
            this.tableOrders = new System.Windows.Forms.DataGridView();
            this.ID_prod_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateShipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRecieving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrders)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(44)))));
            this.menu.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProductionOrdersToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(955, 32);
            this.menu.Stretch = false;
            this.menu.TabIndex = 19;
            this.menu.Text = "menuStrip1";
            // 
            // showProductionOrdersToolStripMenuItem
            // 
            this.showProductionOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shoToolStripMenuItem});
            this.showProductionOrdersToolStripMenuItem.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showProductionOrdersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showProductionOrdersToolStripMenuItem.Name = "showProductionOrdersToolStripMenuItem";
            this.showProductionOrdersToolStripMenuItem.Size = new System.Drawing.Size(72, 28);
            this.showProductionOrdersToolStripMenuItem.Text = "Show";
            // 
            // shoToolStripMenuItem
            // 
            this.shoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shipmentToolStripMenuItem,
            this.recievingToolStripMenuItem});
            this.shoToolStripMenuItem.Name = "shoToolStripMenuItem";
            this.shoToolStripMenuItem.Size = new System.Drawing.Size(248, 28);
            this.shoToolStripMenuItem.Text = "Show documents";
            // 
            // shipmentToolStripMenuItem
            // 
            this.shipmentToolStripMenuItem.Name = "shipmentToolStripMenuItem";
            this.shipmentToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.shipmentToolStripMenuItem.Text = "Shipment";
            this.shipmentToolStripMenuItem.Click += new System.EventHandler(this.shipmentToolStripMenuItem_Click);
            // 
            // recievingToolStripMenuItem
            // 
            this.recievingToolStripMenuItem.Name = "recievingToolStripMenuItem";
            this.recievingToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.recievingToolStripMenuItem.Text = "Recieving";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 28);
            this.toolStripMenuItem1.Text = "Show rest";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.storeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(57, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonRecieve
            // 
            this.buttonRecieve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRecieve.BackColor = System.Drawing.Color.White;
            this.buttonRecieve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecieve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(227)))));
            this.buttonRecieve.FlatAppearance.BorderSize = 2;
            this.buttonRecieve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonRecieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonRecieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecieve.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRecieve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(227)))));
            this.buttonRecieve.Location = new System.Drawing.Point(610, 21);
            this.buttonRecieve.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRecieve.Name = "buttonRecieve";
            this.buttonRecieve.Size = new System.Drawing.Size(202, 58);
            this.buttonRecieve.TabIndex = 19;
            this.buttonRecieve.Text = "Recieve";
            this.buttonRecieve.UseVisualStyleBackColor = false;
            this.buttonRecieve.Click += new System.EventHandler(this.buttonRecieve_Click);
            // 
            // buttonShip
            // 
            this.buttonShip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShip.BackColor = System.Drawing.Color.White;
            this.buttonShip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(44)))));
            this.buttonShip.FlatAppearance.BorderSize = 2;
            this.buttonShip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonShip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShip.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(44)))));
            this.buttonShip.Location = new System.Drawing.Point(136, 21);
            this.buttonShip.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShip.Name = "buttonShip";
            this.buttonShip.Size = new System.Drawing.Size(202, 58);
            this.buttonShip.TabIndex = 18;
            this.buttonShip.Text = "Ship";
            this.buttonShip.UseVisualStyleBackColor = false;
            this.buttonShip.Click += new System.EventHandler(this.buttonShip_Click);
            // 
            // tableOrders
            // 
            this.tableOrders.AllowUserToAddRows = false;
            this.tableOrders.AllowUserToDeleteRows = false;
            this.tableOrders.AllowUserToResizeColumns = false;
            this.tableOrders.AllowUserToResizeRows = false;
            this.tableOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_prod_order,
            this.Route,
            this.Status,
            this.DateCreation,
            this.DateShipment,
            this.DateRecieving});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.tableOrders.Location = new System.Drawing.Point(78, 106);
            this.tableOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableOrders.Name = "tableOrders";
            this.tableOrders.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableOrders.RowHeadersVisible = false;
            this.tableOrders.RowHeadersWidth = 51;
            this.tableOrders.RowTemplate.Height = 24;
            this.tableOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableOrders.Size = new System.Drawing.Size(798, 337);
            this.tableOrders.TabIndex = 20;
            // 
            // ID_prod_order
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_prod_order.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID_prod_order.HeaderText = "ID";
            this.ID_prod_order.MinimumWidth = 6;
            this.ID_prod_order.Name = "ID_prod_order";
            this.ID_prod_order.ReadOnly = true;
            this.ID_prod_order.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_prod_order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_prod_order.Width = 90;
            // 
            // Route
            // 
            this.Route.HeaderText = "Route";
            this.Route.MinimumWidth = 6;
            this.Route.Name = "Route";
            this.Route.ReadOnly = true;
            this.Route.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Route.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Route.Width = 90;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Status.Width = 90;
            // 
            // DateCreation
            // 
            this.DateCreation.HeaderText = "Date";
            this.DateCreation.MinimumWidth = 6;
            this.DateCreation.Name = "DateCreation";
            this.DateCreation.ReadOnly = true;
            this.DateCreation.Width = 175;
            // 
            // DateShipment
            // 
            this.DateShipment.HeaderText = "Shipment";
            this.DateShipment.MinimumWidth = 6;
            this.DateShipment.Name = "DateShipment";
            this.DateShipment.ReadOnly = true;
            this.DateShipment.Width = 175;
            // 
            // DateRecieving
            // 
            this.DateRecieving.HeaderText = "Recieving";
            this.DateRecieving.MinimumWidth = 6;
            this.DateRecieving.Name = "DateRecieving";
            this.DateRecieving.ReadOnly = true;
            this.DateRecieving.Width = 175;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Noto Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(951, 102);
            this.label1.TabIndex = 22;
            this.label1.Text = "Transfer orders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableOrders, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.25131F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.74869F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(955, 573);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonShip, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonRecieve, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 463);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(949, 100);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // StorekeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 591);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StorekeeperForm";
            this.Text = "StorekeeperForm";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrders)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem showProductionOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recievingToolStripMenuItem;
        private System.Windows.Forms.DataGridView tableOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_prod_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateShipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRecieving;
        private System.Windows.Forms.Button buttonRecieve;
        private System.Windows.Forms.Button buttonShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}