namespace WindowsFormsApp1
{
    partial class frmAddRate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRateDesc = new System.Windows.Forms.TextBox();
            this.txtRateAmount = new System.Windows.Forms.TextBox();
            this.btnAddRate = new System.Windows.Forms.Button();
            this.grpRateAdd = new System.Windows.Forms.GroupBox();
            this.txtRateType = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRateAdd.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rate Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rate:";
            // 
            // txtRateDesc
            // 
            this.txtRateDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRateDesc.Location = new System.Drawing.Point(104, 79);
            this.txtRateDesc.MaxLength = 30;
            this.txtRateDesc.Name = "txtRateDesc";
            this.txtRateDesc.Size = new System.Drawing.Size(155, 20);
            this.txtRateDesc.TabIndex = 1;
            // 
            // txtRateAmount
            // 
            this.txtRateAmount.Location = new System.Drawing.Point(104, 122);
            this.txtRateAmount.MaxLength = 3;
            this.txtRateAmount.Name = "txtRateAmount";
            this.txtRateAmount.Size = new System.Drawing.Size(101, 20);
            this.txtRateAmount.TabIndex = 2;
            // 
            // btnAddRate
            // 
            this.btnAddRate.Location = new System.Drawing.Point(104, 186);
            this.btnAddRate.Name = "btnAddRate";
            this.btnAddRate.Size = new System.Drawing.Size(75, 23);
            this.btnAddRate.TabIndex = 3;
            this.btnAddRate.Text = "Confirm";
            this.btnAddRate.UseVisualStyleBackColor = true;
            this.btnAddRate.Click += new System.EventHandler(this.btnAddRate_Click);
            // 
            // grpRateAdd
            // 
            this.grpRateAdd.Controls.Add(this.txtRateType);
            this.grpRateAdd.Controls.Add(this.btnAddRate);
            this.grpRateAdd.Controls.Add(this.txtRateAmount);
            this.grpRateAdd.Controls.Add(this.txtRateDesc);
            this.grpRateAdd.Controls.Add(this.label3);
            this.grpRateAdd.Controls.Add(this.label2);
            this.grpRateAdd.Controls.Add(this.label1);
            this.grpRateAdd.Location = new System.Drawing.Point(122, 65);
            this.grpRateAdd.Name = "grpRateAdd";
            this.grpRateAdd.Size = new System.Drawing.Size(271, 248);
            this.grpRateAdd.TabIndex = 8;
            this.grpRateAdd.TabStop = false;
            this.grpRateAdd.Text = "Add Rate";
            // 
            // txtRateType
            // 
            this.txtRateType.Location = new System.Drawing.Point(104, 37);
            this.txtRateType.MaxLength = 2;
            this.txtRateType.Name = "txtRateType";
            this.txtRateType.Size = new System.Drawing.Size(100, 20);
            this.txtRateType.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // frmAddRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 419);
            this.Controls.Add(this.grpRateAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddRate";
            this.Text = "Add Rate";
            this.grpRateAdd.ResumeLayout(false);
            this.grpRateAdd.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRateDesc;
        private System.Windows.Forms.TextBox txtRateAmount;
        private System.Windows.Forms.Button btnAddRate;
        private System.Windows.Forms.GroupBox grpRateAdd;
        private System.Windows.Forms.TextBox txtRateType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}