namespace WindowsFormsApp1
{
    partial class frmCancelReservation
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
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSelectCust = new System.Windows.Forms.GroupBox();
            this.btnSelectCust = new System.Windows.Forms.Button();
            this.cboReservation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectRes = new System.Windows.Forms.Button();
            this.grpSelectRes = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.grpSelectCust.SuspendLayout();
            this.grpSelectRes.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
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
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(96, 23);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(76, 20);
            this.txtFname.TabIndex = 0;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(96, 55);
            this.txtSname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(76, 20);
            this.txtSname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forename:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname:";
            // 
            // grpSelectCust
            // 
            this.grpSelectCust.Controls.Add(this.btnSelectCust);
            this.grpSelectCust.Controls.Add(this.label2);
            this.grpSelectCust.Controls.Add(this.label1);
            this.grpSelectCust.Controls.Add(this.txtSname);
            this.grpSelectCust.Controls.Add(this.txtFname);
            this.grpSelectCust.Location = new System.Drawing.Point(50, 47);
            this.grpSelectCust.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelectCust.Name = "grpSelectCust";
            this.grpSelectCust.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelectCust.Size = new System.Drawing.Size(222, 132);
            this.grpSelectCust.TabIndex = 5;
            this.grpSelectCust.TabStop = false;
            this.grpSelectCust.Text = "Enter Customer\'s Details";
            // 
            // btnSelectCust
            // 
            this.btnSelectCust.Location = new System.Drawing.Point(96, 88);
            this.btnSelectCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectCust.Name = "btnSelectCust";
            this.btnSelectCust.Size = new System.Drawing.Size(56, 19);
            this.btnSelectCust.TabIndex = 2;
            this.btnSelectCust.Text = "Select";
            this.btnSelectCust.UseVisualStyleBackColor = true;
            this.btnSelectCust.Click += new System.EventHandler(this.btnSelectCust_Click);
            // 
            // cboReservation
            // 
            this.cboReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReservation.FormattingEnabled = true;
            this.cboReservation.Items.AddRange(new object[] {
            "12. John Smith, 110",
            "15. John Smith, 104"});
            this.cboReservation.Location = new System.Drawing.Point(96, 20);
            this.cboReservation.Margin = new System.Windows.Forms.Padding(2);
            this.cboReservation.Name = "cboReservation";
            this.cboReservation.Size = new System.Drawing.Size(111, 21);
            this.cboReservation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reservation:";
            // 
            // btnSelectRes
            // 
            this.btnSelectRes.Location = new System.Drawing.Point(96, 52);
            this.btnSelectRes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectRes.Name = "btnSelectRes";
            this.btnSelectRes.Size = new System.Drawing.Size(56, 19);
            this.btnSelectRes.TabIndex = 4;
            this.btnSelectRes.Text = "Select";
            this.btnSelectRes.UseVisualStyleBackColor = true;
            this.btnSelectRes.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpSelectRes
            // 
            this.grpSelectRes.Controls.Add(this.btnSelectRes);
            this.grpSelectRes.Controls.Add(this.label3);
            this.grpSelectRes.Controls.Add(this.cboReservation);
            this.grpSelectRes.Location = new System.Drawing.Point(50, 210);
            this.grpSelectRes.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelectRes.Name = "grpSelectRes";
            this.grpSelectRes.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelectRes.Size = new System.Drawing.Size(221, 102);
            this.grpSelectRes.TabIndex = 9;
            this.grpSelectRes.TabStop = false;
            this.grpSelectRes.Text = "Select Reservation";
            this.grpSelectRes.Visible = false;
            // 
            // frmCancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 336);
            this.Controls.Add(this.grpSelectRes);
            this.Controls.Add(this.grpSelectCust);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCancelReservation";
            this.Text = "CancelReservation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSelectCust.ResumeLayout(false);
            this.grpSelectCust.PerformLayout();
            this.grpSelectRes.ResumeLayout(false);
            this.grpSelectRes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSelectCust;
        private System.Windows.Forms.Button btnSelectCust;
        private System.Windows.Forms.ComboBox cboReservation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectRes;
        private System.Windows.Forms.GroupBox grpSelectRes;
    }
}