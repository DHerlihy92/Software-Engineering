namespace WindowsFormsApp1
{
    partial class frmProcessNoShows
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
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSelectRes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectRes = new System.Windows.Forms.Button();
            this.grpSelectRes = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.grpSelectRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // cboSelectRes
            // 
            this.cboSelectRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectRes.FormattingEnabled = true;
            this.cboSelectRes.Items.AddRange(new object[] {
            "15. John Smith, 112",
            "19. Jane Doe, 103"});
            this.cboSelectRes.Location = new System.Drawing.Point(86, 47);
            this.cboSelectRes.Margin = new System.Windows.Forms.Padding(2);
            this.cboSelectRes.Name = "cboSelectRes";
            this.cboSelectRes.Size = new System.Drawing.Size(92, 21);
            this.cboSelectRes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservation:";
            // 
            // btnSelectRes
            // 
            this.btnSelectRes.Location = new System.Drawing.Point(86, 89);
            this.btnSelectRes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectRes.Name = "btnSelectRes";
            this.btnSelectRes.Size = new System.Drawing.Size(56, 19);
            this.btnSelectRes.TabIndex = 2;
            this.btnSelectRes.Text = "Select";
            this.btnSelectRes.UseVisualStyleBackColor = true;
            this.btnSelectRes.Click += new System.EventHandler(this.btnSelectRes_Click);
            // 
            // grpSelectRes
            // 
            this.grpSelectRes.Controls.Add(this.btnSelectRes);
            this.grpSelectRes.Controls.Add(this.label1);
            this.grpSelectRes.Controls.Add(this.cboSelectRes);
            this.grpSelectRes.Location = new System.Drawing.Point(58, 56);
            this.grpSelectRes.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelectRes.Name = "grpSelectRes";
            this.grpSelectRes.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelectRes.Size = new System.Drawing.Size(205, 158);
            this.grpSelectRes.TabIndex = 4;
            this.grpSelectRes.TabStop = false;
            this.grpSelectRes.Text = "Select Reservation";
            // 
            // frmProcessNoShows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 258);
            this.Controls.Add(this.grpSelectRes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProcessNoShows";
            this.Text = "ProcessNoShows";
            this.Load += new System.EventHandler(this.frmProcessNoShows_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSelectRes.ResumeLayout(false);
            this.grpSelectRes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox cboSelectRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectRes;
        private System.Windows.Forms.GroupBox grpSelectRes;
    }
}