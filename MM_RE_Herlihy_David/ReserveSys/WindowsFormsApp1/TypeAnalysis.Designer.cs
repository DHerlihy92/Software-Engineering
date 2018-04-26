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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpYearSelect = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.chtType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            this.grpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtType)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
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
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.cboRoomType.Location = new System.Drawing.Point(94, 44);
            this.cboRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(92, 21);
            this.cboRoomType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Type:";
            // 
            // dtpYearSelect
            // 
            this.dtpYearSelect.CustomFormat = "yyyy";
            this.dtpYearSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearSelect.Location = new System.Drawing.Point(94, 79);
            this.dtpYearSelect.Margin = new System.Windows.Forms.Padding(2);
            this.dtpYearSelect.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtpYearSelect.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpYearSelect.Name = "dtpYearSelect";
            this.dtpYearSelect.ShowUpDown = true;
            this.dtpYearSelect.Size = new System.Drawing.Size(92, 20);
            this.dtpYearSelect.TabIndex = 3;
            this.dtpYearSelect.Value = new System.DateTime(2018, 4, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year:";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(94, 111);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(56, 19);
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
            this.grpSelect.Location = new System.Drawing.Point(34, 46);
            this.grpSelect.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelect.Size = new System.Drawing.Size(232, 178);
            this.grpSelect.TabIndex = 6;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "Select Details";
            // 
            // chtType
            // 
            chartArea1.Name = "Revenue";
            this.chtType.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtType.Legends.Add(legend1);
            this.chtType.Location = new System.Drawing.Point(34, 248);
            this.chtType.Name = "chtType";
            series1.ChartArea = "Revenue";
            series1.Legend = "Legend1";
            series1.Name = "Income";
            this.chtType.Series.Add(series1);
            this.chtType.Size = new System.Drawing.Size(146, 63);
            this.chtType.TabIndex = 7;
            this.chtType.Text = "chart1";
            this.chtType.Visible = false;
            // 
            // frmTypeAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(302, 313);
            this.Controls.Add(this.chtType);
            this.Controls.Add(this.grpSelect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTypeAnalysis";
            this.Text = "TypeAnalysis";
            this.Load += new System.EventHandler(this.frmTypeAnalysis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtType)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chtType;
    }
}