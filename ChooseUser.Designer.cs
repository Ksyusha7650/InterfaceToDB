namespace InterfaceToDB
{
    partial class EnterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.label1.Name = "label1";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxUsers, "comboBoxUsers");
            this.comboBoxUsers.ForeColor = System.Drawing.Color.Black;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Items.AddRange(new object[] {
            resources.GetString("comboBoxUsers.Items"),
            resources.GetString("comboBoxUsers.Items1"),
            resources.GetString("comboBoxUsers.Items2"),
            resources.GetString("comboBoxUsers.Items3")});
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Sorted = true;
            this.comboBoxUsers.Tag = "";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(119)))), ((int)(((byte)(140)))));
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonNext, "buttonNext");
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // EnterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EnterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Button buttonNext;
    }
}

