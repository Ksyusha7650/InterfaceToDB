namespace InterfaceToDB
{
    partial class WriteOffMaterial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showRestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.buttonWriteOff = new System.Windows.Forms.Button();
            this.dataMaterials = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.menuStrip1.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showRestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(761, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showRestToolStripMenuItem
            // 
            this.showRestToolStripMenuItem.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showRestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showRestToolStripMenuItem.Name = "showRestToolStripMenuItem";
            this.showRestToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.showRestToolStripMenuItem.Text = "Show rest";
            this.showRestToolStripMenuItem.Click += new System.EventHandler(this.showRestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write-off:";
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.buttonAddMaterial.ForeColor = System.Drawing.Color.White;
            this.buttonAddMaterial.Location = new System.Drawing.Point(428, 415);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(149, 36);
            this.buttonAddMaterial.TabIndex = 4;
            this.buttonAddMaterial.Text = "Add material";
            this.buttonAddMaterial.UseVisualStyleBackColor = false;
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // buttonWriteOff
            // 
            this.buttonWriteOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.buttonWriteOff.ForeColor = System.Drawing.Color.White;
            this.buttonWriteOff.Location = new System.Drawing.Point(585, 415);
            this.buttonWriteOff.Name = "buttonWriteOff";
            this.buttonWriteOff.Size = new System.Drawing.Size(149, 36);
            this.buttonWriteOff.TabIndex = 5;
            this.buttonWriteOff.Text = "Write-Off";
            this.buttonWriteOff.UseVisualStyleBackColor = false;
            // 
            // dataMaterials
            // 
            this.dataMaterials.AllowUserToAddRows = false;
            this.dataMaterials.AllowUserToDeleteRows = false;
            this.dataMaterials.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Amount,
            this.Operation});
            this.dataMaterials.Location = new System.Drawing.Point(87, 102);
            this.dataMaterials.Name = "dataMaterials";
            this.dataMaterials.ReadOnly = true;
            this.dataMaterials.RowHeadersVisible = false;
            this.dataMaterials.RowHeadersWidth = 51;
            this.dataMaterials.RowTemplate.Height = 24;
            this.dataMaterials.Size = new System.Drawing.Size(605, 282);
            this.dataMaterials.TabIndex = 6;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 225;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 150;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Operation";
            this.Operation.MinimumWidth = 6;
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Width = 225;
            // 
            // WriteOffMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 471);
            this.Controls.Add(this.dataMaterials);
            this.Controls.Add(this.buttonWriteOff);
            this.Controls.Add(this.buttonAddMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WriteOffMaterial";
            this.Text = "Write-off materials";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showRestToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Button buttonWriteOff;
        private System.Windows.Forms.DataGridView dataMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
    }
}