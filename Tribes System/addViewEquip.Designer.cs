namespace Tribes_System
{
    partial class addViewEquip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addViewEquip));
            this.title = new System.Windows.Forms.Panel();
            this.minButt = new System.Windows.Forms.Button();
            this.closeButt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.assignedGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customButt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.removeButt = new System.Windows.Forms.Button();
            this.confirmButt = new System.Windows.Forms.Button();
            this.listEmpGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eventLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listEmpGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.Controls.Add(this.minButt);
            this.title.Controls.Add(this.closeButt);
            this.title.Controls.Add(this.label2);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(1, 0);
            this.title.Margin = new System.Windows.Forms.Padding(2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(606, 37);
            this.title.TabIndex = 58;
            // 
            // minButt
            // 
            this.minButt.FlatAppearance.BorderSize = 0;
            this.minButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.minButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.minButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButt.Image = ((System.Drawing.Image)(resources.GetObject("minButt.Image")));
            this.minButt.Location = new System.Drawing.Point(538, 2);
            this.minButt.Margin = new System.Windows.Forms.Padding(2);
            this.minButt.Name = "minButt";
            this.minButt.Size = new System.Drawing.Size(31, 34);
            this.minButt.TabIndex = 45;
            this.minButt.UseVisualStyleBackColor = true;
            this.minButt.Click += new System.EventHandler(this.minButt_Click);
            // 
            // closeButt
            // 
            this.closeButt.FlatAppearance.BorderSize = 0;
            this.closeButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.closeButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.closeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButt.Image = ((System.Drawing.Image)(resources.GetObject("closeButt.Image")));
            this.closeButt.Location = new System.Drawing.Point(574, 2);
            this.closeButt.Margin = new System.Windows.Forms.Padding(2);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(31, 34);
            this.closeButt.TabIndex = 44;
            this.closeButt.UseVisualStyleBackColor = true;
            this.closeButt.Click += new System.EventHandler(this.closeButt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "List of Equipment";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 132);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 540);
            this.tabControl1.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.assignedGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(567, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Equipment Selected";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // assignedGrid
            // 
            this.assignedGrid.AllowUserToAddRows = false;
            this.assignedGrid.AllowUserToDeleteRows = false;
            this.assignedGrid.AllowUserToResizeColumns = false;
            this.assignedGrid.AllowUserToResizeRows = false;
            this.assignedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedGrid.Location = new System.Drawing.Point(12, 17);
            this.assignedGrid.Margin = new System.Windows.Forms.Padding(2);
            this.assignedGrid.MultiSelect = false;
            this.assignedGrid.Name = "assignedGrid";
            this.assignedGrid.ReadOnly = true;
            this.assignedGrid.RowHeadersVisible = false;
            this.assignedGrid.RowTemplate.Height = 24;
            this.assignedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assignedGrid.Size = new System.Drawing.Size(544, 483);
            this.assignedGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customButt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.removeButt);
            this.tabPage2.Controls.Add(this.confirmButt);
            this.tabPage2.Controls.Add(this.listEmpGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(567, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add and Edit List of Equipment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customButt
            // 
            this.customButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customButt.FlatAppearance.BorderSize = 0;
            this.customButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.customButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.customButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButt.ForeColor = System.Drawing.SystemColors.Control;
            this.customButt.Location = new System.Drawing.Point(431, 47);
            this.customButt.Name = "customButt";
            this.customButt.Size = new System.Drawing.Size(124, 24);
            this.customButt.TabIndex = 95;
            this.customButt.Text = "Add Equipment";
            this.customButt.UseVisualStyleBackColor = false;
            this.customButt.Click += new System.EventHandler(this.customButt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "EQUIPMENTS TO BE CONFIRMED";
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
            this.removeButt.Location = new System.Drawing.Point(348, 47);
            this.removeButt.Name = "removeButt";
            this.removeButt.Size = new System.Drawing.Size(77, 24);
            this.removeButt.TabIndex = 91;
            this.removeButt.Text = "Remove";
            this.removeButt.UseVisualStyleBackColor = false;
            // 
            // confirmButt
            // 
            this.confirmButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmButt.FlatAppearance.BorderSize = 0;
            this.confirmButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.confirmButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.confirmButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButt.ForeColor = System.Drawing.SystemColors.Control;
            this.confirmButt.Location = new System.Drawing.Point(433, 481);
            this.confirmButt.Name = "confirmButt";
            this.confirmButt.Size = new System.Drawing.Size(124, 24);
            this.confirmButt.TabIndex = 90;
            this.confirmButt.Text = "Confirm";
            this.confirmButt.UseVisualStyleBackColor = false;
            this.confirmButt.Click += new System.EventHandler(this.confirmButt_Click);
            // 
            // listEmpGrid
            // 
            this.listEmpGrid.AllowUserToAddRows = false;
            this.listEmpGrid.AllowUserToDeleteRows = false;
            this.listEmpGrid.AllowUserToResizeColumns = false;
            this.listEmpGrid.AllowUserToResizeRows = false;
            this.listEmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEmpGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.col2,
            this.col3,
            this.col4});
            this.listEmpGrid.Location = new System.Drawing.Point(12, 76);
            this.listEmpGrid.Margin = new System.Windows.Forms.Padding(2);
            this.listEmpGrid.MultiSelect = false;
            this.listEmpGrid.Name = "listEmpGrid";
            this.listEmpGrid.ReadOnly = true;
            this.listEmpGrid.RowHeadersVisible = false;
            this.listEmpGrid.RowTemplate.Height = 24;
            this.listEmpGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listEmpGrid.Size = new System.Drawing.Size(545, 396);
            this.listEmpGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 36);
            this.label1.TabIndex = 57;
            this.label1.Text = "LIST OF EQUIPMENT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(607, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 688);
            this.panel2.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 688);
            this.panel1.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(0, 688);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 1);
            this.panel3.TabIndex = 61;
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eventLabel.Location = new System.Drawing.Point(11, 93);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(144, 29);
            this.eventLabel.TabIndex = 63;
            this.eventLabel.Text = "Event Name";
            // 
            // id
            // 
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // col2
            // 
            this.col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col2.HeaderText = "Model Number / Name";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col3.HeaderText = "Equipment Name";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col4
            // 
            this.col4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col4.HeaderText = "Category";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            // 
            // addViewEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 689);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addViewEquip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addViewEquip";
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assignedGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listEmpGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Button minButt;
        private System.Windows.Forms.Button closeButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView assignedGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button customButt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeButt;
        private System.Windows.Forms.Button confirmButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label eventLabel;
        public System.Windows.Forms.DataGridView listEmpGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
    }
}