namespace WindowsFormsApp1
{
    partial class frmMainMenu
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
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddRate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdRate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeRes = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelRes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcessNS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoomAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem,
            this.mnuMakeRes,
            this.mnu,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddRate,
            this.mnuUpdRate,
            this.mnuAddRoom,
            this.mnuCloseRoom,
            this.mnuUpdRoom});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // mnuAddRate
            // 
            this.mnuAddRate.Name = "mnuAddRate";
            this.mnuAddRate.Size = new System.Drawing.Size(177, 26);
            this.mnuAddRate.Text = "Add Rate";
            this.mnuAddRate.Click += new System.EventHandler(this.addRateToolStripMenuItem_Click);
            // 
            // mnuUpdRate
            // 
            this.mnuUpdRate.Name = "mnuUpdRate";
            this.mnuUpdRate.Size = new System.Drawing.Size(177, 26);
            this.mnuUpdRate.Text = "Update Rate";
            this.mnuUpdRate.Click += new System.EventHandler(this.mnuUpdRate_Click);
            // 
            // mnuAddRoom
            // 
            this.mnuAddRoom.Name = "mnuAddRoom";
            this.mnuAddRoom.Size = new System.Drawing.Size(177, 26);
            this.mnuAddRoom.Text = "Add Room";
            this.mnuAddRoom.Click += new System.EventHandler(this.mnuAddRoom_Click);
            // 
            // mnuCloseRoom
            // 
            this.mnuCloseRoom.Name = "mnuCloseRoom";
            this.mnuCloseRoom.Size = new System.Drawing.Size(177, 26);
            this.mnuCloseRoom.Text = "Close Room";
            this.mnuCloseRoom.Click += new System.EventHandler(this.mnuCloseRoom_Click);
            // 
            // mnuUpdRoom
            // 
            this.mnuUpdRoom.Name = "mnuUpdRoom";
            this.mnuUpdRoom.Size = new System.Drawing.Size(177, 26);
            this.mnuUpdRoom.Text = "Update Room";
            this.mnuUpdRoom.Click += new System.EventHandler(this.mnuUpdRoom_Click);
            // 
            // mnuMakeRes
            // 
            this.mnuMakeRes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeReservationToolStripMenuItem,
            this.mnuCancelRes,
            this.mnuProcessNS,
            this.mnuCheckIn,
            this.mnuCheckOut});
            this.mnuMakeRes.Name = "mnuMakeRes";
            this.mnuMakeRes.Size = new System.Drawing.Size(104, 24);
            this.mnuMakeRes.Text = "Reservations";
            // 
            // makeReservationToolStripMenuItem
            // 
            this.makeReservationToolStripMenuItem.Name = "makeReservationToolStripMenuItem";
            this.makeReservationToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.makeReservationToolStripMenuItem.Text = "Make Reservation";
            this.makeReservationToolStripMenuItem.Click += new System.EventHandler(this.makeReservationToolStripMenuItem_Click);
            // 
            // mnuCancelRes
            // 
            this.mnuCancelRes.Name = "mnuCancelRes";
            this.mnuCancelRes.Size = new System.Drawing.Size(209, 26);
            this.mnuCancelRes.Text = "Cancel Reservation";
            this.mnuCancelRes.Click += new System.EventHandler(this.cancelReservationToolStripMenuItem_Click);
            // 
            // mnuProcessNS
            // 
            this.mnuProcessNS.Name = "mnuProcessNS";
            this.mnuProcessNS.Size = new System.Drawing.Size(209, 26);
            this.mnuProcessNS.Text = "Process No-Show";
            this.mnuProcessNS.Click += new System.EventHandler(this.mnuProcessNS_Click);
            // 
            // mnuCheckIn
            // 
            this.mnuCheckIn.Name = "mnuCheckIn";
            this.mnuCheckIn.Size = new System.Drawing.Size(209, 26);
            this.mnuCheckIn.Text = "Check In";
            this.mnuCheckIn.Click += new System.EventHandler(this.mnuCheckIn_Click);
            // 
            // mnuCheckOut
            // 
            this.mnuCheckOut.Name = "mnuCheckOut";
            this.mnuCheckOut.Size = new System.Drawing.Size(209, 26);
            this.mnuCheckOut.Text = "Check Out";
            this.mnuCheckOut.Click += new System.EventHandler(this.mnuCheckOut_Click);
            // 
            // mnu
            // 
            this.mnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRoomAnalysis,
            this.mnuYearAnalysis});
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(74, 24);
            this.mnu.Text = "Analysis";
            // 
            // mnuRoomAnalysis
            // 
            this.mnuRoomAnalysis.Name = "mnuRoomAnalysis";
            this.mnuRoomAnalysis.Size = new System.Drawing.Size(216, 26);
            this.mnuRoomAnalysis.Text = "Room Type Analysis";
            this.mnuRoomAnalysis.Click += new System.EventHandler(this.mnuRoomAnalysis_Click);
            // 
            // mnuYearAnalysis
            // 
            this.mnuYearAnalysis.Name = "mnuYearAnalysis";
            this.mnuYearAnalysis.Size = new System.Drawing.Size(216, 26);
            this.mnuYearAnalysis.Text = "Yearly Analysis";
            this.mnuYearAnalysis.Click += new System.EventHandler(this.mnuYearAnalysis_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(45, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to ReserveSys!!";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "ReserveSys";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddRate;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeRes;
        private System.Windows.Forms.ToolStripMenuItem mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdRate;
        private System.Windows.Forms.ToolStripMenuItem mnuAddRoom;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseRoom;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdRoom;
        private System.Windows.Forms.ToolStripMenuItem makeReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelRes;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessNS;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckIn;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckOut;
        private System.Windows.Forms.ToolStripMenuItem mnuRoomAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuYearAnalysis;
        private System.Windows.Forms.Label label1;
    }
}