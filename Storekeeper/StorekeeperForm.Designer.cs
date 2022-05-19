namespace InterfaceToDB.Storekeeper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showRestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTransferOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRoutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recievingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.showRestToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showRestToolStripMenuItem
            // 
            this.showRestToolStripMenuItem.Name = "showRestToolStripMenuItem";
            this.showRestToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.showRestToolStripMenuItem.Text = "Show rest";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTransferOrdersToolStripMenuItem,
            this.showRoutesToolStripMenuItem,
            this.showDocumentsToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // showTransferOrdersToolStripMenuItem
            // 
            this.showTransferOrdersToolStripMenuItem.Name = "showTransferOrdersToolStripMenuItem";
            this.showTransferOrdersToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.showTransferOrdersToolStripMenuItem.Text = "Show transfer orders";
            // 
            // showRoutesToolStripMenuItem
            // 
            this.showRoutesToolStripMenuItem.Name = "showRoutesToolStripMenuItem";
            this.showRoutesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.showRoutesToolStripMenuItem.Text = "Show routes";
            // 
            // showDocumentsToolStripMenuItem
            // 
            this.showDocumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shipmentToolStripMenuItem,
            this.recievingToolStripMenuItem});
            this.showDocumentsToolStripMenuItem.Name = "showDocumentsToolStripMenuItem";
            this.showDocumentsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.showDocumentsToolStripMenuItem.Text = "Show documents";
            // 
            // shipmentToolStripMenuItem
            // 
            this.shipmentToolStripMenuItem.Name = "shipmentToolStripMenuItem";
            this.shipmentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shipmentToolStripMenuItem.Text = "Shipment";
            // 
            // recievingToolStripMenuItem
            // 
            this.recievingToolStripMenuItem.Name = "recievingToolStripMenuItem";
            this.recievingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recievingToolStripMenuItem.Text = "Recieving";
            // 
            // StorekeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 426);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StorekeeperForm";
            this.Text = "StorekeeperForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTransferOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRoutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recievingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}