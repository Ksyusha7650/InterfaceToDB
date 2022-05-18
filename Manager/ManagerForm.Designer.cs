namespace InterfaceToDB
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.showProductionOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOK = new System.Windows.Forms.Button();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxWh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.menu.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProductionOrdersToolStripMenuItem,
            this.showRestToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(486, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // showProductionOrdersToolStripMenuItem
            // 
            this.showProductionOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showRestToolStripMenuItem1,
            this.shoToolStripMenuItem});
            this.showProductionOrdersToolStripMenuItem.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showProductionOrdersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showProductionOrdersToolStripMenuItem.Name = "showProductionOrdersToolStripMenuItem";
            this.showProductionOrdersToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.showProductionOrdersToolStripMenuItem.Text = "Show";
            // 
            // showRestToolStripMenuItem1
            // 
            this.showRestToolStripMenuItem1.Name = "showRestToolStripMenuItem1";
            this.showRestToolStripMenuItem1.Size = new System.Drawing.Size(259, 26);
            this.showRestToolStripMenuItem1.Text = "Show production orders";
            this.showRestToolStripMenuItem1.Click += new System.EventHandler(this.showRestToolStripMenuItem1_Click);
            // 
            // shoToolStripMenuItem
            // 
            this.shoToolStripMenuItem.Name = "shoToolStripMenuItem";
            this.shoToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.shoToolStripMenuItem.Text = "Show work in process";
            this.shoToolStripMenuItem.Click += new System.EventHandler(this.shoToolStripMenuItem_Click);
            // 
            // showRestToolStripMenuItem
            // 
            this.showRestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showRestToolStripMenuItem.Name = "showRestToolStripMenuItem";
            this.showRestToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.showRestToolStripMenuItem.Text = "Show rest";
            this.showRestToolStripMenuItem.Click += new System.EventHandler(this.showRestToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(193, 376);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 39);
            this.buttonOK.TabIndex = 17;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownAmount.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmount.ForeColor = System.Drawing.Color.Black;
            this.numericUpDownAmount.Location = new System.Drawing.Point(236, 210);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(135, 31);
            this.numericUpDownAmount.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(95, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Amount:";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxProduct.ForeColor = System.Drawing.Color.Black;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(236, 141);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(132, 31);
            this.comboBoxProduct.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(98, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product:";
            // 
            // comboBoxWh
            // 
            this.comboBoxWh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxWh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWh.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWh.ForeColor = System.Drawing.Color.Black;
            this.comboBoxWh.FormattingEnabled = true;
            this.comboBoxWh.Location = new System.Drawing.Point(236, 283);
            this.comboBoxWh.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWh.Name = "comboBoxWh";
            this.comboBoxWh.Size = new System.Drawing.Size(132, 31);
            this.comboBoxWh.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(98, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(110, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Creating production order";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 449);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxWh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manager";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem showProductionOrdersToolStripMenuItem;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxWh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRestToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shoToolStripMenuItem;
    }
}