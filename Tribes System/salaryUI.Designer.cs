namespace Tribes_System
{
    partial class salaryUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpGrid = new System.Windows.Forms.DataGridView();
            this.allButt = new System.Windows.Forms.Button();
            this.deetPanel = new System.Windows.Forms.Panel();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.vioButt = new System.Windows.Forms.Button();
            this.bonusButt = new System.Windows.Forms.Button();
            this.vioLabel = new System.Windows.Forms.Label();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.earnedGrid = new System.Windows.Forms.DataGridView();
            this.StatusLab = new System.Windows.Forms.Label();
            this.NameLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).BeginInit();
            this.deetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earnedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(34, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 62);
            this.label9.TabIndex = 73;
            this.label9.Text = "PAYROLL";
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "On-Call",
            "Full-Time",
            "Inactive"});
            this.statusBox.Location = new System.Drawing.Point(197, 155);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(196, 30);
            this.statusBox.TabIndex = 84;
            this.statusBox.Text = "Status";
            this.statusBox.SelectedIndexChanged += new System.EventHandler(this.statusBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 83;
            this.label1.Text = "Employees";
            // 
            // EmpGrid
            // 
            this.EmpGrid.AllowUserToAddRows = false;
            this.EmpGrid.AllowUserToDeleteRows = false;
            this.EmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGrid.Location = new System.Drawing.Point(45, 204);
            this.EmpGrid.Name = "EmpGrid";
            this.EmpGrid.RowTemplate.Height = 24;
            this.EmpGrid.Size = new System.Drawing.Size(715, 575);
            this.EmpGrid.TabIndex = 82;
            this.EmpGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpGrid_CellClick);
            // 
            // allButt
            // 
            this.allButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allButt.FlatAppearance.BorderSize = 0;
            this.allButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.allButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.allButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allButt.ForeColor = System.Drawing.SystemColors.Control;
            this.allButt.Location = new System.Drawing.Point(45, 155);
            this.allButt.Margin = new System.Windows.Forms.Padding(4);
            this.allButt.Name = "allButt";
            this.allButt.Size = new System.Drawing.Size(135, 30);
            this.allButt.TabIndex = 87;
            this.allButt.Text = "ALL";
            this.allButt.UseVisualStyleBackColor = false;
            this.allButt.Click += new System.EventHandler(this.allButt_Click);
            // 
            // deetPanel
            // 
            this.deetPanel.BackColor = System.Drawing.Color.Silver;
            this.deetPanel.Controls.Add(this.yearBox);
            this.deetPanel.Controls.Add(this.monthBox);
            this.deetPanel.Controls.Add(this.vioButt);
            this.deetPanel.Controls.Add(this.bonusButt);
            this.deetPanel.Controls.Add(this.vioLabel);
            this.deetPanel.Controls.Add(this.bonusLabel);
            this.deetPanel.Controls.Add(this.totalLabel);
            this.deetPanel.Controls.Add(this.label4);
            this.deetPanel.Controls.Add(this.label3);
            this.deetPanel.Controls.Add(this.label2);
            this.deetPanel.Controls.Add(this.earnedGrid);
            this.deetPanel.Controls.Add(this.StatusLab);
            this.deetPanel.Controls.Add(this.NameLab);
            this.deetPanel.Location = new System.Drawing.Point(786, 204);
            this.deetPanel.Name = "deetPanel";
            this.deetPanel.Size = new System.Drawing.Size(516, 575);
            this.deetPanel.TabIndex = 88;
            this.deetPanel.Visible = false;
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(191, 88);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(130, 28);
            this.yearBox.TabIndex = 100;
            // 
            // monthBox
            // 
            this.monthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(21, 88);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(164, 28);
            this.monthBox.TabIndex = 99;
            // 
            // vioButt
            // 
            this.vioButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vioButt.FlatAppearance.BorderSize = 0;
            this.vioButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.vioButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.vioButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vioButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vioButt.ForeColor = System.Drawing.SystemColors.Control;
            this.vioButt.Location = new System.Drawing.Point(21, 474);
            this.vioButt.Margin = new System.Windows.Forms.Padding(4);
            this.vioButt.Name = "vioButt";
            this.vioButt.Size = new System.Drawing.Size(144, 37);
            this.vioButt.TabIndex = 98;
            this.vioButt.Text = "Violations";
            this.vioButt.UseVisualStyleBackColor = false;
            this.vioButt.Click += new System.EventHandler(this.vioButt_Click);
            // 
            // bonusButt
            // 
            this.bonusButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bonusButt.FlatAppearance.BorderSize = 0;
            this.bonusButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bonusButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.bonusButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bonusButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusButt.ForeColor = System.Drawing.SystemColors.Control;
            this.bonusButt.Location = new System.Drawing.Point(21, 519);
            this.bonusButt.Margin = new System.Windows.Forms.Padding(4);
            this.bonusButt.Name = "bonusButt";
            this.bonusButt.Size = new System.Drawing.Size(144, 37);
            this.bonusButt.TabIndex = 89;
            this.bonusButt.Text = "Bonus";
            this.bonusButt.UseVisualStyleBackColor = false;
            this.bonusButt.Click += new System.EventHandler(this.bonusButt_Click);
            // 
            // vioLabel
            // 
            this.vioLabel.AutoSize = true;
            this.vioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vioLabel.Location = new System.Drawing.Point(353, 469);
            this.vioLabel.Name = "vioLabel";
            this.vioLabel.Size = new System.Drawing.Size(26, 25);
            this.vioLabel.TabIndex = 97;
            this.vioLabel.Text = "--";
            // 
            // bonusLabel
            // 
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bonusLabel.Location = new System.Drawing.Point(353, 503);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(26, 25);
            this.bonusLabel.TabIndex = 96;
            this.bonusLabel.Text = "--";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalLabel.Location = new System.Drawing.Point(353, 538);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(28, 25);
            this.totalLabel.TabIndex = 95;
            this.totalLabel.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(213, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 94;
            this.label4.Text = "TOTAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(213, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Bonus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(213, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "Violations:";
            // 
            // earnedGrid
            // 
            this.earnedGrid.AllowUserToAddRows = false;
            this.earnedGrid.AllowUserToDeleteRows = false;
            this.earnedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.earnedGrid.Location = new System.Drawing.Point(21, 130);
            this.earnedGrid.Name = "earnedGrid";
            this.earnedGrid.RowTemplate.Height = 24;
            this.earnedGrid.Size = new System.Drawing.Size(471, 323);
            this.earnedGrid.TabIndex = 91;
            // 
            // StatusLab
            // 
            this.StatusLab.AutoSize = true;
            this.StatusLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusLab.Location = new System.Drawing.Point(16, 55);
            this.StatusLab.Name = "StatusLab";
            this.StatusLab.Size = new System.Drawing.Size(94, 25);
            this.StatusLab.TabIndex = 90;
            this.StatusLab.Text = "STATUS";
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameLab.Location = new System.Drawing.Point(16, 26);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(205, 29);
            this.NameLab.TabIndex = 89;
            this.NameLab.Text = "Employees Name";
            // 
            // salaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deetPanel);
            this.Controls.Add(this.allButt);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmpGrid);
            this.Name = "salaryUI";
            this.Size = new System.Drawing.Size(1315, 800);
            this.Load += new System.EventHandler(this.payrollUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).EndInit();
            this.deetPanel.ResumeLayout(false);
            this.deetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earnedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EmpGrid;
        private System.Windows.Forms.Button allButt;
        private System.Windows.Forms.Panel deetPanel;
        private System.Windows.Forms.Label vioLabel;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView earnedGrid;
        private System.Windows.Forms.Label StatusLab;
        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.Button vioButt;
        private System.Windows.Forms.Button bonusButt;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox monthBox;
    }
}
