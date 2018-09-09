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
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.payRepButt = new System.Windows.Forms.Button();
            this.allButt = new System.Windows.Forms.Button();
            this.onCallPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.earnedGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.vioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            this.onCallPanel.SuspendLayout();
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
            // employeeGrid
            // 
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.Location = new System.Drawing.Point(45, 204);
            this.employeeGrid.Name = "employeeGrid";
            this.employeeGrid.RowTemplate.Height = 24;
            this.employeeGrid.Size = new System.Drawing.Size(715, 505);
            this.employeeGrid.TabIndex = 82;
            // 
            // payRepButt
            // 
            this.payRepButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.payRepButt.FlatAppearance.BorderSize = 0;
            this.payRepButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.payRepButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.payRepButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payRepButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payRepButt.ForeColor = System.Drawing.SystemColors.Control;
            this.payRepButt.Location = new System.Drawing.Point(45, 731);
            this.payRepButt.Margin = new System.Windows.Forms.Padding(4);
            this.payRepButt.Name = "payRepButt";
            this.payRepButt.Size = new System.Drawing.Size(303, 37);
            this.payRepButt.TabIndex = 86;
            this.payRepButt.Text = "SALARY REPORT";
            this.payRepButt.UseVisualStyleBackColor = false;
            this.payRepButt.Click += new System.EventHandler(this.payRepButt_Click);
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
            // onCallPanel
            // 
            this.onCallPanel.BackColor = System.Drawing.Color.Silver;
            this.onCallPanel.Controls.Add(this.vioLabel);
            this.onCallPanel.Controls.Add(this.bonusLabel);
            this.onCallPanel.Controls.Add(this.label5);
            this.onCallPanel.Controls.Add(this.label4);
            this.onCallPanel.Controls.Add(this.label3);
            this.onCallPanel.Controls.Add(this.label2);
            this.onCallPanel.Controls.Add(this.earnedGrid);
            this.onCallPanel.Controls.Add(this.statusLabel);
            this.onCallPanel.Controls.Add(this.nameLabel);
            this.onCallPanel.Location = new System.Drawing.Point(786, 204);
            this.onCallPanel.Name = "onCallPanel";
            this.onCallPanel.Size = new System.Drawing.Size(516, 505);
            this.onCallPanel.TabIndex = 88;
            this.onCallPanel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameLabel.Location = new System.Drawing.Point(16, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(205, 29);
            this.nameLabel.TabIndex = 89;
            this.nameLabel.Text = "Employees Name";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusLabel.Location = new System.Drawing.Point(16, 55);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(94, 25);
            this.statusLabel.TabIndex = 90;
            this.statusLabel.Text = "STATUS";
            // 
            // earnedGrid
            // 
            this.earnedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.earnedGrid.Location = new System.Drawing.Point(21, 86);
            this.earnedGrid.Name = "earnedGrid";
            this.earnedGrid.RowTemplate.Height = 24;
            this.earnedGrid.Size = new System.Drawing.Size(471, 280);
            this.earnedGrid.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(247, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "Violations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(247, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Bonus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(247, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 94;
            this.label4.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(387, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 95;
            this.label5.Text = "--";
            // 
            // bonusLabel
            // 
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bonusLabel.Location = new System.Drawing.Point(387, 418);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(26, 25);
            this.bonusLabel.TabIndex = 96;
            this.bonusLabel.Text = "--";
            // 
            // vioLabel
            // 
            this.vioLabel.AutoSize = true;
            this.vioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vioLabel.Location = new System.Drawing.Point(387, 384);
            this.vioLabel.Name = "vioLabel";
            this.vioLabel.Size = new System.Drawing.Size(26, 25);
            this.vioLabel.TabIndex = 97;
            this.vioLabel.Text = "--";
            // 
            // salaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.onCallPanel);
            this.Controls.Add(this.allButt);
            this.Controls.Add(this.payRepButt);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.employeeGrid);
            this.Name = "salaryUI";
            this.Size = new System.Drawing.Size(1315, 800);
            this.Load += new System.EventHandler(this.payrollUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            this.onCallPanel.ResumeLayout(false);
            this.onCallPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earnedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView employeeGrid;
        private System.Windows.Forms.Button payRepButt;
        private System.Windows.Forms.Button allButt;
        private System.Windows.Forms.Panel onCallPanel;
        private System.Windows.Forms.Label vioLabel;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView earnedGrid;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}
