namespace Tribes_System
{
    partial class EmployeeTab
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
            this.button1 = new System.Windows.Forms.Button();
            this.EmpGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.genderLab = new System.Windows.Forms.Label();
            this.addressLab = new System.Windows.Forms.Label();
            this.numLab = new System.Windows.Forms.Label();
            this.ENameLab = new System.Windows.Forms.Label();
            this.EmergencyContactLab = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.StatusLab = new System.Windows.Forms.Label();
            this.BdayLab = new System.Windows.Forms.Label();
            this.NameLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(138, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpGrid
            // 
            this.EmpGrid.AllowUserToAddRows = false;
            this.EmpGrid.AllowUserToDeleteRows = false;
            this.EmpGrid.AllowUserToResizeColumns = false;
            this.EmpGrid.AllowUserToResizeRows = false;
            this.EmpGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmpGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmpGrid.Location = new System.Drawing.Point(13, 143);
            this.EmpGrid.Margin = new System.Windows.Forms.Padding(4);
            this.EmpGrid.Name = "EmpGrid";
            this.EmpGrid.ReadOnly = true;
            this.EmpGrid.RowHeadersVisible = false;
            this.EmpGrid.Size = new System.Drawing.Size(729, 645);
            this.EmpGrid.TabIndex = 2;
            this.EmpGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            this.EmpGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(750, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(750, 88);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 22);
            this.textBox1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(13, 87);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "On-Call",
            "Full-Time",
            "Inactive"});
            this.comboBox1.Location = new System.Drawing.Point(576, 111);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.MaxDropDownItems = 3;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(4, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 62);
            this.label9.TabIndex = 72;
            this.label9.Text = "EMPLOYEES";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.salaryLab);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.genderLab);
            this.panel1.Controls.Add(this.addressLab);
            this.panel1.Controls.Add(this.numLab);
            this.panel1.Controls.Add(this.ENameLab);
            this.panel1.Controls.Add(this.EmergencyContactLab);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.StatusLab);
            this.panel1.Controls.Add(this.BdayLab);
            this.panel1.Controls.Add(this.NameLab);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(750, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 638);
            this.panel1.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Employee Schedule:";
            // 
            // genderLab
            // 
            this.genderLab.AutoSize = true;
            this.genderLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLab.Location = new System.Drawing.Point(6, 169);
            this.genderLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLab.Name = "genderLab";
            this.genderLab.Size = new System.Drawing.Size(69, 20);
            this.genderLab.TabIndex = 30;
            this.genderLab.Text = "Gender:";
            this.genderLab.Click += new System.EventHandler(this.genderLab_Click);
            // 
            // addressLab
            // 
            this.addressLab.AutoSize = true;
            this.addressLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLab.Location = new System.Drawing.Point(6, 72);
            this.addressLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLab.Name = "addressLab";
            this.addressLab.Size = new System.Drawing.Size(71, 20);
            this.addressLab.TabIndex = 29;
            this.addressLab.Text = "Address";
            // 
            // numLab
            // 
            this.numLab.AutoSize = true;
            this.numLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLab.Location = new System.Drawing.Point(6, 92);
            this.numLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numLab.Name = "numLab";
            this.numLab.Size = new System.Drawing.Size(136, 20);
            this.numLab.TabIndex = 28;
            this.numLab.Text = "Contact Number:";
            // 
            // ENameLab
            // 
            this.ENameLab.AutoSize = true;
            this.ENameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENameLab.Location = new System.Drawing.Point(6, 129);
            this.ENameLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ENameLab.Name = "ENameLab";
            this.ENameLab.Size = new System.Drawing.Size(147, 20);
            this.ENameLab.TabIndex = 27;
            this.ENameLab.Text = "Emergency Name:";
            // 
            // EmergencyContactLab
            // 
            this.EmergencyContactLab.AutoSize = true;
            this.EmergencyContactLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmergencyContactLab.Location = new System.Drawing.Point(6, 109);
            this.EmergencyContactLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmergencyContactLab.Name = "EmergencyContactLab";
            this.EmergencyContactLab.Size = new System.Drawing.Size(161, 20);
            this.EmergencyContactLab.TabIndex = 26;
            this.EmergencyContactLab.Text = "Emergency Contact:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 246);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(530, 380);
            this.dataGridView2.TabIndex = 25;
            // 
            // StatusLab
            // 
            this.StatusLab.AutoSize = true;
            this.StatusLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLab.Location = new System.Drawing.Point(6, 52);
            this.StatusLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLab.Name = "StatusLab";
            this.StatusLab.Size = new System.Drawing.Size(62, 20);
            this.StatusLab.TabIndex = 22;
            this.StatusLab.Text = "Status:";
            // 
            // BdayLab
            // 
            this.BdayLab.AutoSize = true;
            this.BdayLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BdayLab.Location = new System.Drawing.Point(6, 149);
            this.BdayLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BdayLab.Name = "BdayLab";
            this.BdayLab.Size = new System.Drawing.Size(82, 20);
            this.BdayLab.TabIndex = 21;
            this.BdayLab.Text = "Birthdate:";
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLab.Location = new System.Drawing.Point(6, 32);
            this.NameLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(58, 20);
            this.NameLab.TabIndex = 20;
            this.NameLab.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = " Employee Details: ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(405, 88);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 47);
            this.button2.TabIndex = 74;
            this.button2.Text = "Edit Employee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Filter:";
            // 
            // salaryLab
            // 
            this.salaryLab.AutoSize = true;
            this.salaryLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLab.Location = new System.Drawing.Point(6, 189);
            this.salaryLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryLab.Name = "salaryLab";
            this.salaryLab.Size = new System.Drawing.Size(66, 20);
            this.salaryLab.TabIndex = 32;
            this.salaryLab.Text = "Salary: ";
            // 
            // EmployeeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EmpGrid);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeTab";
            this.Size = new System.Drawing.Size(1300, 800);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView EmpGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label StatusLab;
        private System.Windows.Forms.Label BdayLab;
        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ENameLab;
        private System.Windows.Forms.Label EmergencyContactLab;
        private System.Windows.Forms.Label addressLab;
        private System.Windows.Forms.Label numLab;
        private System.Windows.Forms.Label genderLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label salaryLab;
    }
}
