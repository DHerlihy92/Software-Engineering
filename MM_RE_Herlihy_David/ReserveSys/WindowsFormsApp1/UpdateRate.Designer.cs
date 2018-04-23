namespace WindowsFormsApp1
{
    partial class UpdateRate
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
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdateRate = new System.Windows.Forms.GroupBox();
            this.txtUpdatedAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdatedDescription = new System.Windows.Forms.TextBox();
            this.btnConfirmUpdate = new System.Windows.Forms.Button();
            this.txtSelectedRateType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSelectRate = new System.Windows.Forms.GroupBox();
            this.cboSelectRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpUpdateRate.SuspendLayout();
            this.grpSelectRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grpUpdateRate
            // 
            this.grpUpdateRate.Controls.Add(this.txtUpdatedAmount);
            this.grpUpdateRate.Controls.Add(this.label3);
            this.grpUpdateRate.Controls.Add(this.txtUpdatedDescription);
            this.grpUpdateRate.Controls.Add(this.btnConfirmUpdate);
            this.grpUpdateRate.Controls.Add(this.txtSelectedRateType);
            this.grpUpdateRate.Controls.Add(this.label2);
            this.grpUpdateRate.Controls.Add(this.label1);
            this.grpUpdateRate.Location = new System.Drawing.Point(38, 211);
            this.grpUpdateRate.Name = "grpUpdateRate";
            this.grpUpdateRate.Size = new System.Drawing.Size(313, 160);
            this.grpUpdateRate.TabIndex = 11;
            this.grpUpdateRate.TabStop = false;
            this.grpUpdateRate.Text = "Update Rate";
            this.grpUpdateRate.Visible = false;
            // 
            // txtUpdatedAmount
            // 
            this.txtUpdatedAmount.Location = new System.Drawing.Point(130, 85);
            this.txtUpdatedAmount.MaxLength = 6;
            this.txtUpdatedAmount.Name = "txtUpdatedAmount";
            this.txtUpdatedAmount.Size = new System.Drawing.Size(96, 20);
            this.txtUpdatedAmount.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount:";
            // 
            // txtUpdatedDescription
            // 
            this.txtUpdatedDescription.Location = new System.Drawing.Point(130, 53);
            this.txtUpdatedDescription.MaxLength = 30;
            this.txtUpdatedDescription.Name = "txtUpdatedDescription";
            this.txtUpdatedDescription.Size = new System.Drawing.Size(96, 20);
            this.txtUpdatedDescription.TabIndex = 9;
            // 
            // btnConfirmUpdate
            // 
            this.btnConfirmUpdate.Location = new System.Drawing.Point(130, 120);
            this.btnConfirmUpdate.Name = "btnConfirmUpdate";
            this.btnConfirmUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmUpdate.TabIndex = 8;
            this.btnConfirmUpdate.Text = "Confirm";
            this.btnConfirmUpdate.UseVisualStyleBackColor = true;
            this.btnConfirmUpdate.Click += new System.EventHandler(this.btnConfirmUpdate_Click);
            // 
            // txtSelectedRateType
            // 
            this.txtSelectedRateType.Location = new System.Drawing.Point(130, 17);
            this.txtSelectedRateType.Name = "txtSelectedRateType";
            this.txtSelectedRateType.ReadOnly = true;
            this.txtSelectedRateType.Size = new System.Drawing.Size(35, 20);
            this.txtSelectedRateType.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rate Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description:";
            // 
            // grpSelectRate
            // 
            this.grpSelectRate.Controls.Add(this.label4);
            this.grpSelectRate.Controls.Add(this.cboSelectRate);
            this.grpSelectRate.Location = new System.Drawing.Point(38, 43);
            this.grpSelectRate.Name = "grpSelectRate";
            this.grpSelectRate.Size = new System.Drawing.Size(314, 98);
            this.grpSelectRate.TabIndex = 10;
            this.grpSelectRate.TabStop = false;
            this.grpSelectRate.Text = "Select Rate";
            // 
            // cboSelectRate
            // 
            this.cboSelectRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectRate.FormattingEnabled = true;
            this.cboSelectRate.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.cboSelectRate.Location = new System.Drawing.Point(130, 33);
            this.cboSelectRate.Name = "cboSelectRate";
            this.cboSelectRate.Size = new System.Drawing.Size(144, 21);
            this.cboSelectRate.TabIndex = 1;
            this.cboSelectRate.SelectedIndexChanged += new System.EventHandler(this.cboSelectRate_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rate:";
            // 
            // UpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 399);
            this.Controls.Add(this.grpUpdateRate);
            this.Controls.Add(this.grpSelectRate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateRate";
            this.Text = "UpdateRate";
            this.Load += new System.EventHandler(this.UpdateRate_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpUpdateRate.ResumeLayout(false);
            this.grpUpdateRate.PerformLayout();
            this.grpSelectRate.ResumeLayout(false);
            this.grpSelectRate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpUpdateRate;
        private System.Windows.Forms.Button btnConfirmUpdate;
        private System.Windows.Forms.TextBox txtSelectedRateType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSelectRate;
        private System.Windows.Forms.ComboBox cboSelectRate;
        private System.Windows.Forms.TextBox txtUpdatedDescription;
        private System.Windows.Forms.TextBox txtUpdatedAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}