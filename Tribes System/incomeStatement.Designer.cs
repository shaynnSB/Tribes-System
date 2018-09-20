namespace Tribes_System
{
    partial class incomeStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(incomeStatement));
            this.label1 = new System.Windows.Forms.Label();
            this.minButt = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButt = new System.Windows.Forms.Button();
            this.reportTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.monthInc = new System.Windows.Forms.DataGridView();
            this.myearBox = new System.Windows.Forms.ComboBox();
            this.mmonthBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.quarInc = new System.Windows.Forms.DataGridView();
            this.qyearBox = new System.Windows.Forms.ComboBox();
            this.qmonthBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.annInc = new System.Windows.Forms.DataGridView();
            this.ayearBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.title.SuspendLayout();
            this.reportTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthInc)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quarInc)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.annInc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 46);
            this.label1.TabIndex = 96;
            this.label1.Text = "Income Statement";
            // 
            // minButt
            // 
            this.minButt.Dock = System.Windows.Forms.DockStyle.Right;
            this.minButt.FlatAppearance.BorderSize = 0;
            this.minButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.minButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.minButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButt.Image = ((System.Drawing.Image)(resources.GetObject("minButt.Image")));
            this.minButt.Location = new System.Drawing.Point(916, 0);
            this.minButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minButt.Name = "minButt";
            this.minButt.Size = new System.Drawing.Size(41, 46);
            this.minButt.TabIndex = 1;
            this.minButt.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.Controls.Add(this.label2);
            this.title.Controls.Add(this.minButt);
            this.title.Controls.Add(this.closeButt);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(1, 0);
            this.title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(998, 46);
            this.title.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 27);
            this.label2.TabIndex = 87;
            this.label2.Text = "Income Statement";
            // 
            // closeButt
            // 
            this.closeButt.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButt.FlatAppearance.BorderSize = 0;
            this.closeButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.closeButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.closeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButt.Image = ((System.Drawing.Image)(resources.GetObject("closeButt.Image")));
            this.closeButt.Location = new System.Drawing.Point(957, 0);
            this.closeButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(41, 46);
            this.closeButt.TabIndex = 0;
            this.closeButt.UseVisualStyleBackColor = true;
            this.closeButt.Click += new System.EventHandler(this.closeButt_Click);
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.tabPage1);
            this.reportTab.Controls.Add(this.tabPage2);
            this.reportTab.Controls.Add(this.tabPage3);
            this.reportTab.Location = new System.Drawing.Point(44, 103);
            this.reportTab.Name = "reportTab";
            this.reportTab.SelectedIndex = 0;
            this.reportTab.Size = new System.Drawing.Size(909, 738);
            this.reportTab.TabIndex = 98;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.monthInc);
            this.tabPage1.Controls.Add(this.myearBox);
            this.tabPage1.Controls.Add(this.mmonthBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monthly Statement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // monthInc
            // 
            this.monthInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthInc.Location = new System.Drawing.Point(21, 76);
            this.monthInc.Name = "monthInc";
            this.monthInc.RowTemplate.Height = 24;
            this.monthInc.Size = new System.Drawing.Size(858, 610);
            this.monthInc.TabIndex = 2;
            // 
            // myearBox
            // 
            this.myearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myearBox.FormattingEnabled = true;
            this.myearBox.Location = new System.Drawing.Point(749, 24);
            this.myearBox.Name = "myearBox";
            this.myearBox.Size = new System.Drawing.Size(130, 28);
            this.myearBox.TabIndex = 1;
            // 
            // mmonthBox
            // 
            this.mmonthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmonthBox.FormattingEnabled = true;
            this.mmonthBox.Items.AddRange(new object[] {
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
            this.mmonthBox.Location = new System.Drawing.Point(579, 24);
            this.mmonthBox.Name = "mmonthBox";
            this.mmonthBox.Size = new System.Drawing.Size(164, 28);
            this.mmonthBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.quarInc);
            this.tabPage2.Controls.Add(this.qyearBox);
            this.tabPage2.Controls.Add(this.qmonthBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quarterly Statement";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // quarInc
            // 
            this.quarInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quarInc.Location = new System.Drawing.Point(21, 74);
            this.quarInc.Name = "quarInc";
            this.quarInc.RowTemplate.Height = 24;
            this.quarInc.Size = new System.Drawing.Size(858, 610);
            this.quarInc.TabIndex = 4;
            // 
            // qyearBox
            // 
            this.qyearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qyearBox.FormattingEnabled = true;
            this.qyearBox.Location = new System.Drawing.Point(749, 24);
            this.qyearBox.Name = "qyearBox";
            this.qyearBox.Size = new System.Drawing.Size(130, 28);
            this.qyearBox.TabIndex = 3;
            // 
            // qmonthBox
            // 
            this.qmonthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qmonthBox.FormattingEnabled = true;
            this.qmonthBox.Items.AddRange(new object[] {
            "First Quarter",
            "Second Quarter",
            "Third Quarter",
            "Fourth Quarter"});
            this.qmonthBox.Location = new System.Drawing.Point(579, 24);
            this.qmonthBox.Name = "qmonthBox";
            this.qmonthBox.Size = new System.Drawing.Size(164, 28);
            this.qmonthBox.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.annInc);
            this.tabPage3.Controls.Add(this.ayearBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(901, 709);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Annual Statement";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // annInc
            // 
            this.annInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.annInc.Location = new System.Drawing.Point(21, 76);
            this.annInc.Name = "annInc";
            this.annInc.RowTemplate.Height = 24;
            this.annInc.Size = new System.Drawing.Size(858, 610);
            this.annInc.TabIndex = 6;
            // 
            // ayearBox
            // 
            this.ayearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayearBox.FormattingEnabled = true;
            this.ayearBox.Location = new System.Drawing.Point(749, 24);
            this.ayearBox.Name = "ayearBox";
            this.ayearBox.Size = new System.Drawing.Size(130, 28);
            this.ayearBox.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(999, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 876);
            this.panel2.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 876);
            this.panel1.TabIndex = 99;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 876);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 1);
            this.panel3.TabIndex = 101;
            // 
            // incomeStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 877);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.reportTab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "incomeStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "incomeStatement";
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.reportTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthInc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quarInc)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.annInc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minButt;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButt;
        private System.Windows.Forms.TabControl reportTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView monthInc;
        private System.Windows.Forms.ComboBox myearBox;
        private System.Windows.Forms.ComboBox mmonthBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView quarInc;
        private System.Windows.Forms.ComboBox qyearBox;
        private System.Windows.Forms.ComboBox qmonthBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView annInc;
        private System.Windows.Forms.ComboBox ayearBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}