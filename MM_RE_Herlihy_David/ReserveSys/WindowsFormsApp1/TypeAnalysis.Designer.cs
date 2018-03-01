namespace WindowsFormsApp1
{
    partial class frmTypeAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypeAnalysis));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpYearSelect = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.picChartType = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.grpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChartType)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(52, 24);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.cboRoomType.Location = new System.Drawing.Point(126, 54);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(121, 24);
            this.cboRoomType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Type:";
            // 
            // dtpYearSelect
            // 
            this.dtpYearSelect.CustomFormat = "yyyy";
            this.dtpYearSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearSelect.Location = new System.Drawing.Point(126, 97);
            this.dtpYearSelect.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpYearSelect.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpYearSelect.Name = "dtpYearSelect";
            this.dtpYearSelect.ShowUpDown = true;
            this.dtpYearSelect.Size = new System.Drawing.Size(121, 22);
            this.dtpYearSelect.TabIndex = 3;
            this.dtpYearSelect.Value = new System.DateTime(2017, 12, 25, 23, 59, 59, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year:";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(126, 137);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.btnSelect);
            this.grpSelect.Controls.Add(this.label2);
            this.grpSelect.Controls.Add(this.dtpYearSelect);
            this.grpSelect.Controls.Add(this.label1);
            this.grpSelect.Controls.Add(this.cboRoomType);
            this.grpSelect.Location = new System.Drawing.Point(45, 56);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(309, 219);
            this.grpSelect.TabIndex = 6;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "Select Details";
            // 
            // picChartType
            // 
            this.picChartType.Image = ((System.Drawing.Image)(resources.GetObject("picChartType.Image")));
            this.picChartType.InitialImage = ((System.Drawing.Image)(resources.GetObject("picChartType.InitialImage")));
            this.picChartType.Location = new System.Drawing.Point(45, 303);
            this.picChartType.Name = "picChartType";
            this.picChartType.Size = new System.Drawing.Size(779, 426);
            this.picChartType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picChartType.TabIndex = 7;
            this.picChartType.TabStop = false;
            this.picChartType.Visible = false;
            // 
            // frmTypeAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(980, 737);
            this.Controls.Add(this.picChartType);
            this.Controls.Add(this.grpSelect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(885, 784);
            this.Name = "frmTypeAnalysis";
            this.Text = "TypeAnalysis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChartType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpYearSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.PictureBox picChartType;
    }
}