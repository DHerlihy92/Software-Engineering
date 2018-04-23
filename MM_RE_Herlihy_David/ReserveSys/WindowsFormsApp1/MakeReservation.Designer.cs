namespace WindowsFormsApp1
{
    partial class frmMakeReservation
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
            this.dtpArrDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDeptDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectRes = new System.Windows.Forms.Button();
            this.grpSelectRes = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRoomNo = new System.Windows.Forms.ComboBox();
            this.grpSelectRoom = new System.Windows.Forms.GroupBox();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpSelectRes.SuspendLayout();
            this.grpSelectRoom.SuspendLayout();
            this.grpCustomer.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // dtpArrDate
            // 
            this.dtpArrDate.Location = new System.Drawing.Point(107, 34);
            this.dtpArrDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpArrDate.MinDate = new System.DateTime(2017, 12, 10, 0, 0, 0, 0);
            this.dtpArrDate.Name = "dtpArrDate";
            this.dtpArrDate.Size = new System.Drawing.Size(151, 20);
            this.dtpArrDate.TabIndex = 0;
            this.dtpArrDate.ValueChanged += new System.EventHandler(this.dtpArrDate_ValueChanged);
            // 
            // dtpDeptDate
            // 
            this.dtpDeptDate.Location = new System.Drawing.Point(107, 72);
            this.dtpDeptDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDeptDate.MinDate = new System.DateTime(2017, 12, 10, 0, 0, 0, 0);
            this.dtpDeptDate.Name = "dtpDeptDate";
            this.dtpDeptDate.Size = new System.Drawing.Size(151, 20);
            this.dtpDeptDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arrival Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departure Date:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.cboType.Location = new System.Drawing.Point(107, 114);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(120, 21);
            this.cboType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room Type:";
            // 
            // btnSelectRes
            // 
            this.btnSelectRes.Location = new System.Drawing.Point(107, 154);
            this.btnSelectRes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectRes.Name = "btnSelectRes";
            this.btnSelectRes.Size = new System.Drawing.Size(56, 19);
            this.btnSelectRes.TabIndex = 3;
            this.btnSelectRes.Text = "Select";
            this.btnSelectRes.UseVisualStyleBackColor = true;
            this.btnSelectRes.Click += new System.EventHandler(this.btnSelectRes_Click);
            // 
            // grpSelectRes
            // 
            this.grpSelectRes.Controls.Add(this.btnSelectRes);
            this.grpSelectRes.Controls.Add(this.label3);
            this.grpSelectRes.Controls.Add(this.cboType);
            this.grpSelectRes.Controls.Add(this.label2);
            this.grpSelectRes.Controls.Add(this.label1);
            this.grpSelectRes.Controls.Add(this.dtpDeptDate);
            this.grpSelectRes.Controls.Add(this.dtpArrDate);
            this.grpSelectRes.Location = new System.Drawing.Point(25, 57);
            this.grpSelectRes.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelectRes.Name = "grpSelectRes";
            this.grpSelectRes.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelectRes.Size = new System.Drawing.Size(274, 194);
            this.grpSelectRes.TabIndex = 8;
            this.grpSelectRes.TabStop = false;
            this.grpSelectRes.Text = "Enter Reservation Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Room Number:";
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomNo.FormattingEnabled = true;
            this.cboRoomNo.Items.AddRange(new object[] {
            "101",
            "102"});
            this.cboRoomNo.Location = new System.Drawing.Point(107, 17);
            this.cboRoomNo.Margin = new System.Windows.Forms.Padding(2);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.Size = new System.Drawing.Size(92, 21);
            this.cboRoomNo.TabIndex = 4;
            // 
            // grpSelectRoom
            // 
            this.grpSelectRoom.Controls.Add(this.btnSelectRoom);
            this.grpSelectRoom.Controls.Add(this.label4);
            this.grpSelectRoom.Controls.Add(this.cboRoomNo);
            this.grpSelectRoom.Location = new System.Drawing.Point(25, 271);
            this.grpSelectRoom.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelectRoom.Name = "grpSelectRoom";
            this.grpSelectRoom.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelectRoom.Size = new System.Drawing.Size(274, 99);
            this.grpSelectRoom.TabIndex = 11;
            this.grpSelectRoom.TabStop = false;
            this.grpSelectRoom.Text = "Select Room";
            this.grpSelectRoom.Visible = false;
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.Location = new System.Drawing.Point(107, 58);
            this.btnSelectRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(56, 19);
            this.btnSelectRoom.TabIndex = 5;
            this.btnSelectRoom.Text = "Select";
            this.btnSelectRoom.UseVisualStyleBackColor = true;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Forename:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(112, 24);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(76, 20);
            this.txtFname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Surname:";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(112, 47);
            this.txtSname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(76, 20);
            this.txtSname.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(112, 70);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(76, 20);
            this.txtStreet.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Street:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Town:";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(112, 93);
            this.txtTown.Margin = new System.Windows.Forms.Padding(2);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(76, 20);
            this.txtTown.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "County:";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(112, 115);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(76, 20);
            this.txtCounty.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Telephone No:";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(112, 138);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(76, 20);
            this.txtTelNo.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 163);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Card Number:";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(112, 161);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(76, 20);
            this.txtCardNo.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 186);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "CardHolder Name:";
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(112, 184);
            this.txtCardName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(76, 20);
            this.txtCardName.TabIndex = 13;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnConfirm);
            this.grpCustomer.Controls.Add(this.label12);
            this.grpCustomer.Controls.Add(this.txtCardName);
            this.grpCustomer.Controls.Add(this.label11);
            this.grpCustomer.Controls.Add(this.txtCardNo);
            this.grpCustomer.Controls.Add(this.label10);
            this.grpCustomer.Controls.Add(this.txtTelNo);
            this.grpCustomer.Controls.Add(this.label9);
            this.grpCustomer.Controls.Add(this.txtCounty);
            this.grpCustomer.Controls.Add(this.label8);
            this.grpCustomer.Controls.Add(this.txtTown);
            this.grpCustomer.Controls.Add(this.label7);
            this.grpCustomer.Controls.Add(this.txtStreet);
            this.grpCustomer.Controls.Add(this.txtSname);
            this.grpCustomer.Controls.Add(this.label6);
            this.grpCustomer.Controls.Add(this.txtFname);
            this.grpCustomer.Controls.Add(this.label5);
            this.grpCustomer.Location = new System.Drawing.Point(335, 57);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.grpCustomer.Size = new System.Drawing.Size(217, 252);
            this.grpCustomer.TabIndex = 28;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Enter Customer\'s Details";
            this.grpCustomer.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(87, 214);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(56, 19);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmMakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 428);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpSelectRoom);
            this.Controls.Add(this.grpSelectRes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMakeReservation";
            this.Text = "MakeReservation";
            this.Load += new System.EventHandler(this.frmMakeReservation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSelectRes.ResumeLayout(false);
            this.grpSelectRes.PerformLayout();
            this.grpSelectRoom.ResumeLayout(false);
            this.grpSelectRoom.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DateTimePicker dtpArrDate;
        private System.Windows.Forms.DateTimePicker dtpDeptDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectRes;
        private System.Windows.Forms.GroupBox grpSelectRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRoomNo;
        private System.Windows.Forms.GroupBox grpSelectRoom;
        private System.Windows.Forms.Button btnSelectRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnConfirm;
    }
}