namespace Tribes_System
{
    partial class customPack
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
            this.allButt = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addButt = new System.Windows.Forms.Button();
            this.removeButt = new System.Windows.Forms.Button();
            this.okButt = new System.Windows.Forms.Button();
            this.availEmpGrid = new System.Windows.Forms.DataGridView();
            this.cancelButt = new System.Windows.Forms.Button();
            this.addEquipGrid = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.availEmpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEquipGrid)).BeginInit();
            this.SuspendLayout();
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
            this.allButt.Location = new System.Drawing.Point(20, 61);
            this.allButt.Name = "allButt";
            this.allButt.Size = new System.Drawing.Size(73, 24);
            this.allButt.TabIndex = 91;
            this.allButt.Text = "ALL";
            this.allButt.UseVisualStyleBackColor = false;
            this.allButt.Click += new System.EventHandler(this.allButt_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Staging",
            "Lights",
            "Speakers",
            "Misc.",
            "Video",
            "LED Wall",
            "LCD"});
            this.categoryBox.Location = new System.Drawing.Point(98, 61);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(120, 25);
            this.categoryBox.TabIndex = 90;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 26);
            this.label3.TabIndex = 95;
            this.label3.Text = "EQUIPMENT AVAILABLE";
            // 
            // addButt
            // 
            this.addButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButt.FlatAppearance.BorderSize = 0;
            this.addButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.addButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.addButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButt.ForeColor = System.Drawing.SystemColors.Control;
            this.addButt.Location = new System.Drawing.Point(344, 61);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(73, 24);
            this.addButt.TabIndex = 98;
            this.addButt.Text = "Add";
            this.addButt.UseVisualStyleBackColor = false;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // removeButt
            // 
            this.removeButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeButt.FlatAppearance.BorderSize = 0;
            this.removeButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.removeButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.removeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButt.ForeColor = System.Drawing.SystemColors.Control;
            this.removeButt.Location = new System.Drawing.Point(722, 61);
            this.removeButt.Name = "removeButt";
            this.removeButt.Size = new System.Drawing.Size(124, 24);
            this.removeButt.TabIndex = 97;
            this.removeButt.Text = "Remove";
            this.removeButt.UseVisualStyleBackColor = false;
            this.removeButt.Click += new System.EventHandler(this.removeButt_Click);
            // 
            // okButt
            // 
            this.okButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.okButt.FlatAppearance.BorderSize = 0;
            this.okButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.okButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.okButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButt.ForeColor = System.Drawing.SystemColors.Control;
            this.okButt.Location = new System.Drawing.Point(581, 641);
            this.okButt.Name = "okButt";
            this.okButt.Size = new System.Drawing.Size(124, 24);
            this.okButt.TabIndex = 96;
            this.okButt.Text = "Okay";
            this.okButt.UseVisualStyleBackColor = false;
            this.okButt.Click += new System.EventHandler(this.okButt_Click);
            // 
            // availEmpGrid
            // 
            this.availEmpGrid.AllowUserToAddRows = false;
            this.availEmpGrid.AllowUserToDeleteRows = false;
            this.availEmpGrid.AllowUserToResizeColumns = false;
            this.availEmpGrid.AllowUserToResizeRows = false;
            this.availEmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availEmpGrid.Location = new System.Drawing.Point(20, 100);
            this.availEmpGrid.Margin = new System.Windows.Forms.Padding(2);
            this.availEmpGrid.MultiSelect = false;
            this.availEmpGrid.Name = "availEmpGrid";
            this.availEmpGrid.ReadOnly = true;
            this.availEmpGrid.RowHeadersVisible = false;
            this.availEmpGrid.RowTemplate.Height = 24;
            this.availEmpGrid.Size = new System.Drawing.Size(398, 528);
            this.availEmpGrid.TabIndex = 94;
            // 
            // cancelButt
            // 
            this.cancelButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButt.FlatAppearance.BorderSize = 0;
            this.cancelButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.cancelButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.cancelButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButt.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButt.Location = new System.Drawing.Point(722, 641);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(124, 24);
            this.cancelButt.TabIndex = 99;
            this.cancelButt.Text = "Cancel";
            this.cancelButt.UseVisualStyleBackColor = false;
            this.cancelButt.Click += new System.EventHandler(this.cancelButt_Click);
            // 
            // addEquipGrid
            // 
            this.addEquipGrid.AllowUserToAddRows = false;
            this.addEquipGrid.AllowUserToDeleteRows = false;
            this.addEquipGrid.AllowUserToResizeColumns = false;
            this.addEquipGrid.AllowUserToResizeRows = false;
            this.addEquipGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addEquipGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.addEquipGrid.Location = new System.Drawing.Point(449, 100);
            this.addEquipGrid.Margin = new System.Windows.Forms.Padding(2);
            this.addEquipGrid.MultiSelect = false;
            this.addEquipGrid.Name = "addEquipGrid";
            this.addEquipGrid.ReadOnly = true;
            this.addEquipGrid.RowHeadersVisible = false;
            this.addEquipGrid.RowTemplate.Height = 24;
            this.addEquipGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addEquipGrid.Size = new System.Drawing.Size(398, 528);
            this.addEquipGrid.TabIndex = 100;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Model Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Equipment Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Permanent",
            "Temporary"});
            this.statusBox.Location = new System.Drawing.Point(221, 61);
            this.statusBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(120, 25);
            this.statusBox.TabIndex = 101;
            this.statusBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 1);
            this.panel1.TabIndex = 102;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(875, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 683);
            this.panel2.TabIndex = 103;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 683);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 1);
            this.panel3.TabIndex = 103;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 682);
            this.panel4.TabIndex = 103;
            // 
            // customPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 684);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.addEquipGrid);
            this.Controls.Add(this.cancelButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.removeButt);
            this.Controls.Add(this.okButt);
            this.Controls.Add(this.availEmpGrid);
            this.Controls.Add(this.allButt);
            this.Controls.Add(this.categoryBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "customPack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customPack";
            this.Load += new System.EventHandler(this.customPack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availEmpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEquipGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allButt;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button removeButt;
        private System.Windows.Forms.Button okButt;
        private System.Windows.Forms.DataGridView availEmpGrid;
        private System.Windows.Forms.Button cancelButt;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView addEquipGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}