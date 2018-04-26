namespace WindowsFormsApp1
{
    partial class frmRoomClose
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
            this.cboCloseRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseRoom = new System.Windows.Forms.Button();
            this.grpCloseRoom = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCloseRoom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCloseRoom
            // 
            this.cboCloseRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCloseRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCloseRoom.FormattingEnabled = true;
            this.cboCloseRoom.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105"});
            this.cboCloseRoom.Location = new System.Drawing.Point(77, 58);
            this.cboCloseRoom.Name = "cboCloseRoom";
            this.cboCloseRoom.Size = new System.Drawing.Size(106, 21);
            this.cboCloseRoom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room:";
            // 
            // btnCloseRoom
            // 
            this.btnCloseRoom.Location = new System.Drawing.Point(77, 99);
            this.btnCloseRoom.Name = "btnCloseRoom";
            this.btnCloseRoom.Size = new System.Drawing.Size(75, 23);
            this.btnCloseRoom.TabIndex = 2;
            this.btnCloseRoom.Text = "Confirm";
            this.btnCloseRoom.UseVisualStyleBackColor = true;
            this.btnCloseRoom.Click += new System.EventHandler(this.btnCloseRoom_Click);
            // 
            // grpCloseRoom
            // 
            this.grpCloseRoom.Controls.Add(this.btnCloseRoom);
            this.grpCloseRoom.Controls.Add(this.label1);
            this.grpCloseRoom.Controls.Add(this.cboCloseRoom);
            this.grpCloseRoom.Location = new System.Drawing.Point(73, 46);
            this.grpCloseRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCloseRoom.Name = "grpCloseRoom";
            this.grpCloseRoom.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCloseRoom.Size = new System.Drawing.Size(230, 171);
            this.grpCloseRoom.TabIndex = 3;
            this.grpCloseRoom.TabStop = false;
            this.grpCloseRoom.Text = "Close Room";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmRoomClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 290);
            this.Controls.Add(this.grpCloseRoom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRoomClose";
            this.Text = "Close Room";
            this.Load += new System.EventHandler(this.frmRoomClose_Load);
            this.grpCloseRoom.ResumeLayout(false);
            this.grpCloseRoom.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCloseRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseRoom;
        private System.Windows.Forms.GroupBox grpCloseRoom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}