namespace Tribes_System
{
    partial class editAccounts
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
            this.EmpGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.nameLab = new System.Windows.Forms.Label();
            this.empLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.button8 = new System.Windows.Forms.Button();
            this.addPassBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addNameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.NameLabs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpGrid
            // 
            this.EmpGrid.AllowUserToAddRows = false;
            this.EmpGrid.AllowUserToDeleteRows = false;
            this.EmpGrid.AllowUserToResizeColumns = false;
            this.EmpGrid.AllowUserToResizeRows = false;
            this.EmpGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.EmpGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmpGrid.Location = new System.Drawing.Point(13, 143);
            this.EmpGrid.Margin = new System.Windows.Forms.Padding(4);
            this.EmpGrid.Name = "EmpGrid";
            this.EmpGrid.ReadOnly = true;
            this.EmpGrid.RowHeadersVisible = false;
            this.EmpGrid.Size = new System.Drawing.Size(549, 653);
            this.EmpGrid.TabIndex = 2;
            this.EmpGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            this.EmpGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(4, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 62);
            this.label9.TabIndex = 72;
            this.label9.Text = "PROFILES";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.NameLabs);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.nameLab);
            this.panel1.Controls.Add(this.empLab);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(591, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 286);
            this.panel1.TabIndex = 73;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(12, 228);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 44);
            this.button7.TabIndex = 75;
            this.button7.Text = "Edit Profile";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLab.Location = new System.Drawing.Point(44, 79);
            this.nameLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(316, 25);
            this.nameLab.TabIndex = 87;
            this.nameLab.Text = "Lastname, Firstname Secondname";
            // 
            // empLab
            // 
            this.empLab.AutoSize = true;
            this.empLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLab.Location = new System.Drawing.Point(1, 44);
            this.empLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empLab.Name = "empLab";
            this.empLab.Size = new System.Drawing.Size(162, 25);
            this.empLab.TabIndex = 85;
            this.empLab.Text = "Employee Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Profile Details:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.radioButton7);
            this.panel2.Controls.Add(this.radioButton8);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.addPassBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.addNameBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(591, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 286);
            this.panel2.TabIndex = 88;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(8, 203);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 44);
            this.button6.TabIndex = 75;
            this.button6.Text = "Add Profile";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 86;
            this.label6.Text = "Access:";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(274, 175);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(90, 21);
            this.radioButton6.TabIndex = 83;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Secretary";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(198, 175);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(70, 21);
            this.radioButton7.TabIndex = 82;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Owner";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(97, 175);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(95, 21);
            this.radioButton8.TabIndex = 81;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "superUser";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(550, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 23);
            this.button8.TabIndex = 80;
            this.button8.Text = "Show";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // addPassBox
            // 
            this.addPassBox.BackColor = System.Drawing.Color.LightGray;
            this.addPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addPassBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPassBox.ForeColor = System.Drawing.Color.Gray;
            this.addPassBox.Location = new System.Drawing.Point(126, 136);
            this.addPassBox.Margin = new System.Windows.Forms.Padding(4);
            this.addPassBox.Name = "addPassBox";
            this.addPassBox.Size = new System.Drawing.Size(421, 27);
            this.addPassBox.TabIndex = 79;
            this.addPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addPassBox.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 78;
            this.label8.Text = "Password:";
            // 
            // addNameBox
            // 
            this.addNameBox.BackColor = System.Drawing.Color.LightGray;
            this.addNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addNameBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNameBox.ForeColor = System.Drawing.Color.Gray;
            this.addNameBox.Location = new System.Drawing.Point(126, 101);
            this.addNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.addNameBox.Name = "addNameBox";
            this.addNameBox.Size = new System.Drawing.Size(422, 27);
            this.addNameBox.TabIndex = 75;
            this.addNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "User Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 32);
            this.label11.TabIndex = 18;
            this.label11.Text = "Add Profile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 51);
            this.label2.TabIndex = 89;
            this.label2.Text = "Users";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 97;
            this.label5.Text = "Access:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(91, 188);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 21);
            this.radioButton4.TabIndex = 96;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Employee";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(269, 189);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 21);
            this.radioButton3.TabIndex = 95;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Secretary";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(193, 189);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 21);
            this.radioButton2.TabIndex = 94;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Owner";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(92, 189);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 21);
            this.radioButton1.TabIndex = 93;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "superUser";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(550, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 23);
            this.button5.TabIndex = 92;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.LightGray;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.ForeColor = System.Drawing.Color.Gray;
            this.passBox.Location = new System.Drawing.Point(121, 150);
            this.passBox.Margin = new System.Windows.Forms.Padding(4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(422, 27);
            this.passBox.TabIndex = 91;
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 90;
            this.label4.Text = "Password:";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.LightGray;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Gray;
            this.nameBox.Location = new System.Drawing.Point(121, 115);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(422, 27);
            this.nameBox.TabIndex = 89;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameLabs
            // 
            this.NameLabs.AutoSize = true;
            this.NameLabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabs.Location = new System.Drawing.Point(2, 115);
            this.NameLabs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabs.Name = "NameLabs";
            this.NameLabs.Size = new System.Drawing.Size(116, 25);
            this.NameLabs.TabIndex = 88;
            this.NameLabs.Text = "User Name:";
            // 
            // editAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmpGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editAccounts";
            this.Size = new System.Drawing.Size(1300, 800);
            this.Load += new System.EventHandler(this.editAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView EmpGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Label empLab;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox addPassBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addNameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label NameLabs;
        private System.Windows.Forms.Label label2;
    }
}
