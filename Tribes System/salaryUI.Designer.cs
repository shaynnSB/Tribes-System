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
            this.fullPanel = new System.Windows.Forms.Panel();
            this.fullYearBox = new System.Windows.Forms.ComboBox();
            this.fullMonthBox = new System.Windows.Forms.ComboBox();
            this.fullVio = new System.Windows.Forms.Button();
            this.fullBonus = new System.Windows.Forms.Button();
            this.fullVioLabel = new System.Windows.Forms.Label();
            this.fullBoLabel = new System.Windows.Forms.Label();
            this.fullTotLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fullGrid = new System.Windows.Forms.DataGridView();
            this.fullStatLabel = new System.Windows.Forms.Label();
            this.fullEmpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).BeginInit();
            this.deetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earnedGrid)).BeginInit();
            this.fullPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullGrid)).BeginInit();
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
            this.statusBox.Location = new System.Drawing.Point(197, 153);
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
            this.label1.Location = new System.Drawing.Point(37, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 83;
            this.label1.Text = "Employees";
            // 
            // EmpGrid
            // 
            this.EmpGrid.AllowUserToAddRows = false;
            this.EmpGrid.AllowUserToDeleteRows = false;
            this.EmpGrid.AllowUserToResizeRows = false;
            this.EmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGrid.Location = new System.Drawing.Point(45, 202);
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
            this.allButt.Location = new System.Drawing.Point(45, 153);
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
            this.deetPanel.Location = new System.Drawing.Point(786, 202);
            this.deetPanel.Name = "deetPanel";
            this.deetPanel.Size = new System.Drawing.Size(516, 575);
            this.deetPanel.TabIndex = 88;
            this.deetPanel.Visible = false;
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(191, 88);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(130, 28);
            this.yearBox.TabIndex = 100;
            this.yearBox.SelectedIndexChanged += new System.EventHandler(this.yearBox_SelectedIndexChanged);
            // 
            // monthBox
            // 
            this.monthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.monthBox.SelectedIndexChanged += new System.EventHandler(this.monthBox_SelectedIndexChanged);
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
            this.earnedGrid.AllowUserToResizeRows = false;
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
            // fullPanel
            // 
            this.fullPanel.BackColor = System.Drawing.Color.Silver;
            this.fullPanel.Controls.Add(this.fullYearBox);
            this.fullPanel.Controls.Add(this.fullMonthBox);
            this.fullPanel.Controls.Add(this.fullVio);
            this.fullPanel.Controls.Add(this.fullBonus);
            this.fullPanel.Controls.Add(this.fullVioLabel);
            this.fullPanel.Controls.Add(this.fullBoLabel);
            this.fullPanel.Controls.Add(this.fullTotLabel);
            this.fullPanel.Controls.Add(this.label8);
            this.fullPanel.Controls.Add(this.label10);
            this.fullPanel.Controls.Add(this.label11);
            this.fullPanel.Controls.Add(this.fullGrid);
            this.fullPanel.Controls.Add(this.fullStatLabel);
            this.fullPanel.Controls.Add(this.fullEmpLabel);
            this.fullPanel.Location = new System.Drawing.Point(786, 202);
            this.fullPanel.Name = "fullPanel";
            this.fullPanel.Size = new System.Drawing.Size(516, 575);
            this.fullPanel.TabIndex = 101;
            this.fullPanel.Visible = false;
            // 
            // fullYearBox
            // 
            this.fullYearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullYearBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullYearBox.FormattingEnabled = true;
            this.fullYearBox.Location = new System.Drawing.Point(191, 88);
            this.fullYearBox.Name = "fullYearBox";
            this.fullYearBox.Size = new System.Drawing.Size(130, 28);
            this.fullYearBox.TabIndex = 100;
            // 
            // fullMonthBox
            // 
            this.fullMonthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullMonthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullMonthBox.FormattingEnabled = true;
            this.fullMonthBox.Items.AddRange(new object[] {
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
            this.fullMonthBox.Location = new System.Drawing.Point(21, 88);
            this.fullMonthBox.Name = "fullMonthBox";
            this.fullMonthBox.Size = new System.Drawing.Size(164, 28);
            this.fullMonthBox.TabIndex = 99;
            // 
            // fullVio
            // 
            this.fullVio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullVio.FlatAppearance.BorderSize = 0;
            this.fullVio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.fullVio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.fullVio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullVio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullVio.ForeColor = System.Drawing.SystemColors.Control;
            this.fullVio.Location = new System.Drawing.Point(21, 474);
            this.fullVio.Margin = new System.Windows.Forms.Padding(4);
            this.fullVio.Name = "fullVio";
            this.fullVio.Size = new System.Drawing.Size(144, 37);
            this.fullVio.TabIndex = 98;
            this.fullVio.Text = "Violations";
            this.fullVio.UseVisualStyleBackColor = false;
            this.fullVio.Click += new System.EventHandler(this.fullVio_Click);
            // 
            // fullBonus
            // 
            this.fullBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullBonus.FlatAppearance.BorderSize = 0;
            this.fullBonus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.fullBonus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.fullBonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullBonus.ForeColor = System.Drawing.SystemColors.Control;
            this.fullBonus.Location = new System.Drawing.Point(21, 519);
            this.fullBonus.Margin = new System.Windows.Forms.Padding(4);
            this.fullBonus.Name = "fullBonus";
            this.fullBonus.Size = new System.Drawing.Size(144, 37);
            this.fullBonus.TabIndex = 89;
            this.fullBonus.Text = "Bonus";
            this.fullBonus.UseVisualStyleBackColor = false;
            this.fullBonus.Click += new System.EventHandler(this.fullBonus_Click);
            // 
            // fullVioLabel
            // 
            this.fullVioLabel.AutoSize = true;
            this.fullVioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullVioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullVioLabel.Location = new System.Drawing.Point(353, 469);
            this.fullVioLabel.Name = "fullVioLabel";
            this.fullVioLabel.Size = new System.Drawing.Size(26, 25);
            this.fullVioLabel.TabIndex = 97;
            this.fullVioLabel.Text = "--";
            // 
            // fullBoLabel
            // 
            this.fullBoLabel.AutoSize = true;
            this.fullBoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullBoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullBoLabel.Location = new System.Drawing.Point(353, 503);
            this.fullBoLabel.Name = "fullBoLabel";
            this.fullBoLabel.Size = new System.Drawing.Size(26, 25);
            this.fullBoLabel.TabIndex = 96;
            this.fullBoLabel.Text = "--";
            // 
            // fullTotLabel
            // 
            this.fullTotLabel.AutoSize = true;
            this.fullTotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullTotLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullTotLabel.Location = new System.Drawing.Point(353, 538);
            this.fullTotLabel.Name = "fullTotLabel";
            this.fullTotLabel.Size = new System.Drawing.Size(28, 25);
            this.fullTotLabel.TabIndex = 95;
            this.fullTotLabel.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(213, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 94;
            this.label8.Text = "TOTAL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(213, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 93;
            this.label10.Text = "Bonus:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(213, 469);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 92;
            this.label11.Text = "Violations:";
            // 
            // fullGrid
            // 
            this.fullGrid.AllowUserToAddRows = false;
            this.fullGrid.AllowUserToDeleteRows = false;
            this.fullGrid.AllowUserToResizeRows = false;
            this.fullGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullGrid.Location = new System.Drawing.Point(21, 130);
            this.fullGrid.Name = "fullGrid";
            this.fullGrid.RowTemplate.Height = 24;
            this.fullGrid.Size = new System.Drawing.Size(471, 323);
            this.fullGrid.TabIndex = 91;
            // 
            // fullStatLabel
            // 
            this.fullStatLabel.AutoSize = true;
            this.fullStatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullStatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullStatLabel.Location = new System.Drawing.Point(16, 55);
            this.fullStatLabel.Name = "fullStatLabel";
            this.fullStatLabel.Size = new System.Drawing.Size(94, 25);
            this.fullStatLabel.TabIndex = 90;
            this.fullStatLabel.Text = "STATUS";
            // 
            // fullEmpLabel
            // 
            this.fullEmpLabel.AutoSize = true;
            this.fullEmpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullEmpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullEmpLabel.Location = new System.Drawing.Point(16, 26);
            this.fullEmpLabel.Name = "fullEmpLabel";
            this.fullEmpLabel.Size = new System.Drawing.Size(205, 29);
            this.fullEmpLabel.TabIndex = 89;
            this.fullEmpLabel.Text = "Employees Name";
            // 
            // salaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allButt);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmpGrid);
            this.Controls.Add(this.fullPanel);
            this.Controls.Add(this.deetPanel);
            this.Name = "salaryUI";
            this.Size = new System.Drawing.Size(1315, 800);
            this.Load += new System.EventHandler(this.payrollUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).EndInit();
            this.deetPanel.ResumeLayout(false);
            this.deetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earnedGrid)).EndInit();
            this.fullPanel.ResumeLayout(false);
            this.fullPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullGrid)).EndInit();
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
        private System.Windows.Forms.Panel fullPanel;
        private System.Windows.Forms.ComboBox fullYearBox;
        private System.Windows.Forms.ComboBox fullMonthBox;
        private System.Windows.Forms.Button fullVio;
        private System.Windows.Forms.Button fullBonus;
        private System.Windows.Forms.Label fullVioLabel;
        private System.Windows.Forms.Label fullBoLabel;
        private System.Windows.Forms.Label fullTotLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView fullGrid;
        private System.Windows.Forms.Label fullStatLabel;
        private System.Windows.Forms.Label fullEmpLabel;
    }
}
