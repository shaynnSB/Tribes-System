namespace Tribes_System
{
    partial class violations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(violations));
            this.title = new System.Windows.Forms.Panel();
            this.minButt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButt = new System.Windows.Forms.Button();
            this.totLabel = new System.Windows.Forms.Label();
            this.editButt = new System.Windows.Forms.Button();
            this.addButt = new System.Windows.Forms.Button();
            this.remButt = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.violationsGrid = new System.Windows.Forms.DataGridView();
            this.NameLab = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.violationsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.Controls.Add(this.minButt);
            this.title.Controls.Add(this.label2);
            this.title.Controls.Add(this.closeButt);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1037, 46);
            this.title.TabIndex = 107;
            // 
            // minButt
            // 
            this.minButt.Dock = System.Windows.Forms.DockStyle.Right;
            this.minButt.FlatAppearance.BorderSize = 0;
            this.minButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.minButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.minButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButt.Image = ((System.Drawing.Image)(resources.GetObject("minButt.Image")));
            this.minButt.Location = new System.Drawing.Point(955, 0);
            this.minButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minButt.Name = "minButt";
            this.minButt.Size = new System.Drawing.Size(41, 46);
            this.minButt.TabIndex = 111;
            this.minButt.UseVisualStyleBackColor = true;
            this.minButt.Click += new System.EventHandler(this.minButt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 105;
            this.label2.Text = "Violations";
            // 
            // closeButt
            // 
            this.closeButt.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButt.FlatAppearance.BorderSize = 0;
            this.closeButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.closeButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.closeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButt.Image = ((System.Drawing.Image)(resources.GetObject("closeButt.Image")));
            this.closeButt.Location = new System.Drawing.Point(996, 0);
            this.closeButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(41, 46);
            this.closeButt.TabIndex = 110;
            this.closeButt.UseVisualStyleBackColor = true;
            this.closeButt.Click += new System.EventHandler(this.closeButt_Click);
            // 
            // totLabel
            // 
            this.totLabel.AutoSize = true;
            this.totLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totLabel.Location = new System.Drawing.Point(192, 466);
            this.totLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totLabel.Name = "totLabel";
            this.totLabel.Size = new System.Drawing.Size(31, 29);
            this.totLabel.TabIndex = 116;
            this.totLabel.Text = "--";
            // 
            // editButt
            // 
            this.editButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editButt.FlatAppearance.BorderSize = 0;
            this.editButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.editButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.editButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButt.ForeColor = System.Drawing.SystemColors.Control;
            this.editButt.Location = new System.Drawing.Point(844, 414);
            this.editButt.Margin = new System.Windows.Forms.Padding(4);
            this.editButt.Name = "editButt";
            this.editButt.Size = new System.Drawing.Size(127, 37);
            this.editButt.TabIndex = 115;
            this.editButt.Text = "Edit";
            this.editButt.UseVisualStyleBackColor = false;
            this.editButt.Click += new System.EventHandler(this.editButt_Click);
            // 
            // addButt
            // 
            this.addButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButt.FlatAppearance.BorderSize = 0;
            this.addButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.addButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.addButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButt.ForeColor = System.Drawing.SystemColors.Control;
            this.addButt.Location = new System.Drawing.Point(699, 414);
            this.addButt.Margin = new System.Windows.Forms.Padding(4);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(127, 37);
            this.addButt.TabIndex = 114;
            this.addButt.Text = "Add";
            this.addButt.UseVisualStyleBackColor = false;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // remButt
            // 
            this.remButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.remButt.FlatAppearance.BorderSize = 0;
            this.remButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.remButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.remButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remButt.ForeColor = System.Drawing.SystemColors.Control;
            this.remButt.Location = new System.Drawing.Point(775, 462);
            this.remButt.Margin = new System.Windows.Forms.Padding(4);
            this.remButt.Name = "remButt";
            this.remButt.Size = new System.Drawing.Size(127, 37);
            this.remButt.TabIndex = 113;
            this.remButt.Text = "Remove";
            this.remButt.UseVisualStyleBackColor = false;
            this.remButt.Click += new System.EventHandler(this.remButt_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(13, 466);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 29);
            this.label13.TabIndex = 112;
            this.label13.Text = "TOTAL";
            // 
            // violationsGrid
            // 
            this.violationsGrid.AllowUserToAddRows = false;
            this.violationsGrid.AllowUserToDeleteRows = false;
            this.violationsGrid.AllowUserToResizeRows = false;
            this.violationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.violationsGrid.Location = new System.Drawing.Point(18, 104);
            this.violationsGrid.Name = "violationsGrid";
            this.violationsGrid.RowTemplate.Height = 24;
            this.violationsGrid.Size = new System.Drawing.Size(630, 344);
            this.violationsGrid.TabIndex = 111;
            this.violationsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.violationsGrid_CellClick);
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameLab.Location = new System.Drawing.Point(13, 62);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(205, 29);
            this.NameLab.TabIndex = 120;
            this.NameLab.Text = "Employees Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(675, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 25);
            this.label11.TabIndex = 123;
            this.label11.Text = "Date:";
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateBox.Location = new System.Drawing.Point(794, 153);
            this.dateBox.Mask = "0000-00-00";
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(202, 30);
            this.dateBox.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(675, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 122;
            this.label1.Text = "Amount:";
            // 
            // amBox
            // 
            this.amBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amBox.Location = new System.Drawing.Point(794, 104);
            this.amBox.Name = "amBox";
            this.amBox.Size = new System.Drawing.Size(202, 30);
            this.amBox.TabIndex = 121;
            this.amBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(675, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 126;
            this.label3.Text = "Description:";
            // 
            // descBox
            // 
            this.descBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descBox.Location = new System.Drawing.Point(680, 256);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(316, 138);
            this.descBox.TabIndex = 125;
            // 
            // violations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amBox);
            this.Controls.Add(this.NameLab);
            this.Controls.Add(this.totLabel);
            this.Controls.Add(this.editButt);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.remButt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.violationsGrid);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "violations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "violations";
            this.Load += new System.EventHandler(this.violations_Load);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.violationsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button minButt;
        private System.Windows.Forms.Button closeButt;
        private System.Windows.Forms.Label totLabel;
        private System.Windows.Forms.Button editButt;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button remButt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView violationsGrid;
        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox dateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descBox;
    }
}