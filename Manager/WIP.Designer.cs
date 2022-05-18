namespace InterfaceToDB
{
    partial class WIP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WIPTable = new System.Windows.Forms.DataGridView();
            this.ID_WIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WIPTable)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.buttonOK.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(324, 417);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 39);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(275, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Work in Process:";
            // 
            // WIPTable
            // 
            this.WIPTable.AllowUserToAddRows = false;
            this.WIPTable.AllowUserToDeleteRows = false;
            this.WIPTable.AllowUserToResizeColumns = false;
            this.WIPTable.AllowUserToResizeRows = false;
            this.WIPTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WIPTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.WIPTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WIPTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_WIP,
            this.ID_Order,
            this.Product,
            this.Amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WIPTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.WIPTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.WIPTable.Location = new System.Drawing.Point(37, 70);
            this.WIPTable.Name = "WIPTable";
            this.WIPTable.ReadOnly = true;
            this.WIPTable.RowHeadersVisible = false;
            this.WIPTable.RowHeadersWidth = 51;
            this.WIPTable.RowTemplate.Height = 24;
            this.WIPTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WIPTable.Size = new System.Drawing.Size(621, 341);
            this.WIPTable.TabIndex = 7;
            // 
            // ID_WIP
            // 
            this.ID_WIP.HeaderText = "ID";
            this.ID_WIP.MinimumWidth = 6;
            this.ID_WIP.Name = "ID_WIP";
            this.ID_WIP.ReadOnly = true;
            this.ID_WIP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_WIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_WIP.Width = 125;
            // 
            // ID_Order
            // 
            this.ID_Order.HeaderText = "ID Order";
            this.ID_Order.MinimumWidth = 6;
            this.ID_Order.Name = "ID_Order";
            this.ID_Order.ReadOnly = true;
            this.ID_Order.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_Order.Width = 125;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Product.Width = 200;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Amount.Width = 175;
            // 
            // WIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 468);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WIPTable);
            this.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Work in process";
            ((System.ComponentModel.ISupportInitialize)(this.WIPTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView WIPTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_WIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}