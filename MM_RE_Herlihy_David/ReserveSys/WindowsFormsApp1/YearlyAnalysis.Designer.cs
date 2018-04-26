namespace WindowsFormsApp1
{
    partial class frmYearlyAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpYearSelect = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.chtYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpSelect.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtYear)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.btnSelect);
            this.grpSelect.Controls.Add(this.label2);
            this.grpSelect.Controls.Add(this.dtpYearSelect);
            this.grpSelect.Location = new System.Drawing.Point(46, 36);
            this.grpSelect.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelect.Size = new System.Drawing.Size(232, 178);
            this.grpSelect.TabIndex = 7;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "Select Details";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year:";
            // 
            // dtpYearSelect
            // 
            this.dtpYearSelect.CustomFormat = "yyyy";
            this.dtpYearSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearSelect.Location = new System.Drawing.Point(94, 58);
            this.dtpYearSelect.Margin = new System.Windows.Forms.Padding(2);
            this.dtpYearSelect.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtpYearSelect.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpYearSelect.Name = "dtpYearSelect";
            this.dtpYearSelect.ShowUpDown = true;
            this.dtpYearSelect.Size = new System.Drawing.Size(92, 20);
            this.dtpYearSelect.TabIndex = 3;
            this.dtpYearSelect.Value = new System.DateTime(2018, 4, 12, 0, 0, 0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1193, 24);
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
            // chtYear
            // 
            chartArea4.Name = "Revenue";
            this.chtYear.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtYear.Legends.Add(legend4);
            this.chtYear.Location = new System.Drawing.Point(46, 251);
            this.chtYear.Name = "chtYear";
            series4.ChartArea = "Revenue";
            series4.Legend = "Legend1";
            series4.Name = "Income";
            this.chtYear.Series.Add(series4);
            this.chtYear.Size = new System.Drawing.Size(572, 300);
            this.chtYear.TabIndex = 6;
            this.chtYear.Text = "chart1";
            this.chtYear.Visible = false;
            // 
            // frmYearlyAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1193, 797);
            this.Controls.Add(this.chtYear);
            this.Controls.Add(this.grpSelect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmYearlyAnalysis";
            this.Text = "YearlyAnalysis";
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpYearSelect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtYear;
    }
}