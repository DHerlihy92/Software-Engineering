namespace WindowsFormsApp1
{
    partial class frmUpdateRoom
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
            this.txtRoomNo = new System.Windows.Forms.Label();
            this.cboSelectRoom = new System.Windows.Forms.ComboBox();
            this.grpSelectRoom = new System.Windows.Forms.GroupBox();
            this.cboSelectType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectedRoomNo = new System.Windows.Forms.TextBox();
            this.btnConfirmUpdate = new System.Windows.Forms.Button();
            this.grpUpdateRoom = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSelectRoom.SuspendLayout();
            this.grpUpdateRoom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.AutoSize = true;
            this.txtRoomNo.Location = new System.Drawing.Point(61, 44);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(103, 17);
            this.txtRoomNo.TabIndex = 0;
            this.txtRoomNo.Text = "Room Number:";
            // 
            // cboSelectRoom
            // 
            this.cboSelectRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectRoom.FormattingEnabled = true;
            this.cboSelectRoom.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105"});
            this.cboSelectRoom.Location = new System.Drawing.Point(173, 41);
            this.cboSelectRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSelectRoom.Name = "cboSelectRoom";
            this.cboSelectRoom.Size = new System.Drawing.Size(160, 24);
            this.cboSelectRoom.TabIndex = 1;
            this.cboSelectRoom.SelectedIndexChanged += new System.EventHandler(this.cboSelectRoom_SelectedIndexChanged);
            // 
            // grpSelectRoom
            // 
            this.grpSelectRoom.Controls.Add(this.cboSelectRoom);
            this.grpSelectRoom.Controls.Add(this.txtRoomNo);
            this.grpSelectRoom.Location = new System.Drawing.Point(92, 82);
            this.grpSelectRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSelectRoom.Name = "grpSelectRoom";
            this.grpSelectRoom.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSelectRoom.Size = new System.Drawing.Size(419, 165);
            this.grpSelectRoom.TabIndex = 3;
            this.grpSelectRoom.TabStop = false;
            this.grpSelectRoom.Text = "Select Room";
            // 
            // cboSelectType
            // 
            this.cboSelectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectType.FormattingEnabled = true;
            this.cboSelectType.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Family Room"});
            this.cboSelectType.Location = new System.Drawing.Point(173, 62);
            this.cboSelectType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSelectType.Name = "cboSelectType";
            this.cboSelectType.Size = new System.Drawing.Size(160, 24);
            this.cboSelectType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room Number:";
            // 
            // txtSelectedRoomNo
            // 
            this.txtSelectedRoomNo.Location = new System.Drawing.Point(173, 18);
            this.txtSelectedRoomNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelectedRoomNo.Name = "txtSelectedRoomNo";
            this.txtSelectedRoomNo.ReadOnly = true;
            this.txtSelectedRoomNo.Size = new System.Drawing.Size(41, 22);
            this.txtSelectedRoomNo.TabIndex = 7;
            // 
            // btnConfirmUpdate
            // 
            this.btnConfirmUpdate.Location = new System.Drawing.Point(173, 148);
            this.btnConfirmUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmUpdate.Name = "btnConfirmUpdate";
            this.btnConfirmUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmUpdate.TabIndex = 8;
            this.btnConfirmUpdate.Text = "Confirm";
            this.btnConfirmUpdate.UseVisualStyleBackColor = true;
            this.btnConfirmUpdate.Click += new System.EventHandler(this.btnConfirmUpdate_Click);
            // 
            // grpUpdateRoom
            // 
            this.grpUpdateRoom.Controls.Add(this.label3);
            this.grpUpdateRoom.Controls.Add(this.txtDescription);
            this.grpUpdateRoom.Controls.Add(this.btnConfirmUpdate);
            this.grpUpdateRoom.Controls.Add(this.txtSelectedRoomNo);
            this.grpUpdateRoom.Controls.Add(this.label2);
            this.grpUpdateRoom.Controls.Add(this.label1);
            this.grpUpdateRoom.Controls.Add(this.cboSelectType);
            this.grpUpdateRoom.Location = new System.Drawing.Point(92, 289);
            this.grpUpdateRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdateRoom.Name = "grpUpdateRoom";
            this.grpUpdateRoom.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdateRoom.Size = new System.Drawing.Size(417, 213);
            this.grpUpdateRoom.TabIndex = 9;
            this.grpUpdateRoom.TabStop = false;
            this.grpUpdateRoom.Text = "Update Room";
            this.grpUpdateRoom.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(173, 107);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(204, 22);
            this.txtDescription.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(603, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 548);
            this.Controls.Add(this.grpUpdateRoom);
            this.Controls.Add(this.grpSelectRoom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUpdateRoom";
            this.Text = "Update Room";
            this.Load += new System.EventHandler(this.frmUpdateRoom_Load);
            this.grpSelectRoom.ResumeLayout(false);
            this.grpSelectRoom.PerformLayout();
            this.grpUpdateRoom.ResumeLayout(false);
            this.grpUpdateRoom.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtRoomNo;
        private System.Windows.Forms.ComboBox cboSelectRoom;
        private System.Windows.Forms.GroupBox grpSelectRoom;
        private System.Windows.Forms.ComboBox cboSelectType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelectedRoomNo;
        private System.Windows.Forms.Button btnConfirmUpdate;
        private System.Windows.Forms.GroupBox grpUpdateRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}