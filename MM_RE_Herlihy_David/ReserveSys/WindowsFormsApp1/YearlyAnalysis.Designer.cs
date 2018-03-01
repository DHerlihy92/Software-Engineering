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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyAnalysis));
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpYearSelect = new System.Windows.Forms.DateTimePicker();
            this.picChartYear = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChartYear)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.btnSelect);
            this.grpSelect.Controls.Add(this.label2);
            this.grpSelect.Controls.Add(this.dtpYearSelect);
            this.grpSelect.Location = new System.Drawing.Point(61, 44);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(309, 219);
            this.grpSelect.TabIndex = 7;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "Select Details";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year:";
            // 
            // dtpYearSelect
            // 
            this.dtpYearSelect.CustomFormat = "yyyy";
            this.dtpYearSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearSelect.Location = new System.Drawing.Point(126, 71);
            this.dtpYearSelect.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpYearSelect.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpYearSelect.Name = "dtpYearSelect";
            this.dtpYearSelect.ShowUpDown = true;
            this.dtpYearSelect.Size = new System.Drawing.Size(121, 22);
            this.dtpYearSelect.TabIndex = 3;
            this.dtpYearSelect.Value = new System.DateTime(2017, 12, 25, 23, 59, 59, 0);
            // 
            // picChartYear
            // 
            this.picChartYear.Image = ((System.Drawing.Image)(resources.GetObject("picChartYear.Image")));
            this.picChartYear.InitialImage = ((System.Drawing.Image)(resources.GetObject("picChartYear.InitialImage")));
            this.picChartYear.Location = new System.Drawing.Point(61, 285);
            this.picChartYear.Name = "picChartYear";
            this.picChartYear.Size = new System.Drawing.Size(774, 431);
            this.picChartYear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picChartYear.TabIndex = 8;
            this.picChartYear.TabStop = false;
            this.picChartYear.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(52, 24);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // frmYearlyAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(876, 763);
            this.Controls.Add(this.picChartYear);
            this.Controls.Add(this.grpSelect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmYearlyAnalysis";
            this.Text = "YearlyAnalysis";
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChartYear)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpYearSelect;
        private System.Windows.Forms.PictureBox picChartYear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}