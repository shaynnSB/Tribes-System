namespace Tribes_System
{
    partial class payrollUI
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
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
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
            this.statusBox.Location = new System.Drawing.Point(233, 155);
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
            this.label1.Location = new System.Drawing.Point(73, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 83;
            this.label1.Text = "Employees";
            // 
            // employeeGrid
            // 
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.Location = new System.Drawing.Point(81, 204);
            this.employeeGrid.Name = "employeeGrid";
            this.employeeGrid.RowTemplate.Height = 24;
            this.employeeGrid.Size = new System.Drawing.Size(1189, 505);
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
            this.payRepButt.Location = new System.Drawing.Point(81, 731);
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
            this.allButt.Location = new System.Drawing.Point(81, 155);
            this.allButt.Margin = new System.Windows.Forms.Padding(4);
            this.allButt.Name = "allButt";
            this.allButt.Size = new System.Drawing.Size(135, 30);
            this.allButt.TabIndex = 87;
            this.allButt.Text = "ALL";
            this.allButt.UseVisualStyleBackColor = false;
            this.allButt.Click += new System.EventHandler(this.allButt_Click);
            // 
            // payrollUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allButt);
            this.Controls.Add(this.payRepButt);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.employeeGrid);
            this.Name = "payrollUI";
            this.Size = new System.Drawing.Size(1315, 800);
            this.Load += new System.EventHandler(this.payrollUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
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
    }
}
