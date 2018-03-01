namespace WindowsFormsApp1
{
    partial class frmCheckOut
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
            this.grpSelectRes = new System.Windows.Forms.GroupBox();
            this.btnSelectRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSelectRes = new System.Windows.Forms.ComboBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(419, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(52, 24);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpSelectRes
            // 
            this.grpSelectRes.Controls.Add(this.btnSelectRes);
            this.grpSelectRes.Controls.Add(this.label1);
            this.grpSelectRes.Controls.Add(this.cboSelectRes);
            this.grpSelectRes.Location = new System.Drawing.Point(64, 80);
            this.grpSelectRes.Name = "grpSelectRes";
            this.grpSelectRes.Size = new System.Drawing.Size(290, 194);
            this.grpSelectRes.TabIndex = 5;
            this.grpSelectRes.TabStop = false;
            this.grpSelectRes.Text = "Select Reservation";
            // 
            // btnSelectRes
            // 
            this.btnSelectRes.Location = new System.Drawing.Point(119, 109);
            this.btnSelectRes.Name = "btnSelectRes";
            this.btnSelectRes.Size = new System.Drawing.Size(75, 23);
            this.btnSelectRes.TabIndex = 3;
            this.btnSelectRes.Text = "Select";
            this.btnSelectRes.UseVisualStyleBackColor = true;
            this.btnSelectRes.Click += new System.EventHandler(this.btnSelectRes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservation:";
            // 
            // cboSelectRes
            // 
            this.cboSelectRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectRes.FormattingEnabled = true;
            this.cboSelectRes.Items.AddRange(new object[] {
            "23. John Smith, 112"});
            this.cboSelectRes.Location = new System.Drawing.Point(119, 65);
            this.cboSelectRes.Name = "cboSelectRes";
            this.cboSelectRes.Size = new System.Drawing.Size(121, 24);
            this.cboSelectRes.TabIndex = 1;
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 355);
            this.Controls.Add(this.grpSelectRes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCheckOut";
            this.Text = "CheckOut";
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
        private System.Windows.Forms.GroupBox grpSelectRes;
        private System.Windows.Forms.Button btnSelectRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSelectRes;
    }
}