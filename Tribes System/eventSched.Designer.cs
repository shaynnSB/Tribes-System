namespace Tribes_System
{
    partial class eventSched
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.eventGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.editButt = new System.Windows.Forms.Button();
            this.deetPanel = new System.Windows.Forms.Panel();
            this.amLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancellationButt = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.viewPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewEquip = new System.Windows.Forms.Button();
            this.viewStaff = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.locLabel = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).BeginInit();
            this.deetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(51, 100);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // eventGrid
            // 
            this.eventGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.eventGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGrid.Location = new System.Drawing.Point(51, 318);
            this.eventGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventGrid.Name = "eventGrid";
            this.eventGrid.ReadOnly = true;
            this.eventGrid.RowTemplate.Height = 24;
            this.eventGrid.Size = new System.Drawing.Size(302, 386);
            this.eventGrid.TabIndex = 1;
            this.eventGrid.Visible = false;
            this.eventGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventGrid_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(50, 715);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 37);
            this.button2.TabIndex = 69;
            this.button2.Text = "Add New Event";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // editButt
            // 
            this.editButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editButt.FlatAppearance.BorderSize = 0;
            this.editButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.editButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.editButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButt.ForeColor = System.Drawing.SystemColors.Control;
            this.editButt.Location = new System.Drawing.Point(635, 613);
            this.editButt.Margin = new System.Windows.Forms.Padding(4);
            this.editButt.Name = "editButt";
            this.editButt.Size = new System.Drawing.Size(255, 37);
            this.editButt.TabIndex = 68;
            this.editButt.Text = "Edit Details";
            this.editButt.UseVisualStyleBackColor = false;
            this.editButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // deetPanel
            // 
            this.deetPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deetPanel.Controls.Add(this.amLabel);
            this.deetPanel.Controls.Add(this.label6);
            this.deetPanel.Controls.Add(this.cancellationButt);
            this.deetPanel.Controls.Add(this.clientLabel);
            this.deetPanel.Controls.Add(this.numLabel);
            this.deetPanel.Controls.Add(this.timeLabel);
            this.deetPanel.Controls.Add(this.label5);
            this.deetPanel.Controls.Add(this.viewPay);
            this.deetPanel.Controls.Add(this.label2);
            this.deetPanel.Controls.Add(this.label3);
            this.deetPanel.Controls.Add(this.label4);
            this.deetPanel.Controls.Add(this.viewEquip);
            this.deetPanel.Controls.Add(this.viewStaff);
            this.deetPanel.Controls.Add(this.dateLabel);
            this.deetPanel.Controls.Add(this.locLabel);
            this.deetPanel.Controls.Add(this.notesBox);
            this.deetPanel.Controls.Add(this.label47);
            this.deetPanel.Controls.Add(this.editButt);
            this.deetPanel.Controls.Add(this.label46);
            this.deetPanel.Controls.Add(this.label45);
            this.deetPanel.Controls.Add(this.nameLabel);
            this.deetPanel.Location = new System.Drawing.Point(380, 94);
            this.deetPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deetPanel.Name = "deetPanel";
            this.deetPanel.Size = new System.Drawing.Size(914, 686);
            this.deetPanel.TabIndex = 70;
            this.deetPanel.Visible = false;
            // 
            // amLabel
            // 
            this.amLabel.AutoSize = true;
            this.amLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.amLabel.Location = new System.Drawing.Point(174, 170);
            this.amLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amLabel.Name = "amLabel";
            this.amLabel.Size = new System.Drawing.Size(28, 25);
            this.amLabel.TabIndex = 83;
            this.amLabel.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(57, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 82;
            this.label6.Text = "Amount: ";
            // 
            // cancellationButt
            // 
            this.cancellationButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancellationButt.FlatAppearance.BorderSize = 0;
            this.cancellationButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cancellationButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cancellationButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancellationButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancellationButt.ForeColor = System.Drawing.SystemColors.Control;
            this.cancellationButt.Location = new System.Drawing.Point(635, 568);
            this.cancellationButt.Margin = new System.Windows.Forms.Padding(4);
            this.cancellationButt.Name = "cancellationButt";
            this.cancellationButt.Size = new System.Drawing.Size(256, 37);
            this.cancellationButt.TabIndex = 81;
            this.cancellationButt.Text = "Cancel Event";
            this.cancellationButt.UseVisualStyleBackColor = false;
            this.cancellationButt.Click += new System.EventHandler(this.cancellationButt_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.clientLabel.Location = new System.Drawing.Point(175, 478);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(28, 25);
            this.clientLabel.TabIndex = 80;
            this.clientLabel.Text = "--";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.numLabel.Location = new System.Drawing.Point(248, 509);
            this.numLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(28, 25);
            this.numLabel.TabIndex = 79;
            this.numLabel.Text = "--";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timeLabel.Location = new System.Drawing.Point(174, 107);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(28, 25);
            this.timeLabel.TabIndex = 78;
            this.timeLabel.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(60, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 77;
            this.label5.Text = "Time:";
            // 
            // viewPay
            // 
            this.viewPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewPay.FlatAppearance.BorderSize = 0;
            this.viewPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPay.ForeColor = System.Drawing.SystemColors.Control;
            this.viewPay.Location = new System.Drawing.Point(635, 358);
            this.viewPay.Margin = new System.Windows.Forms.Padding(0);
            this.viewPay.Name = "viewPay";
            this.viewPay.Size = new System.Drawing.Size(255, 38);
            this.viewPay.TabIndex = 76;
            this.viewPay.Text = "View Monetary Details";
            this.viewPay.UseVisualStyleBackColor = false;
            this.viewPay.Click += new System.EventHandler(this.viewPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(60, 509);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(60, 478);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "Client:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(31, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 38);
            this.label4.TabIndex = 72;
            this.label4.Text = "CLIENT DETAILS";
            // 
            // viewEquip
            // 
            this.viewEquip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewEquip.FlatAppearance.BorderSize = 0;
            this.viewEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEquip.ForeColor = System.Drawing.SystemColors.Control;
            this.viewEquip.Location = new System.Drawing.Point(65, 358);
            this.viewEquip.Margin = new System.Windows.Forms.Padding(0);
            this.viewEquip.Name = "viewEquip";
            this.viewEquip.Size = new System.Drawing.Size(255, 38);
            this.viewEquip.TabIndex = 70;
            this.viewEquip.Text = "View List of Equipment";
            this.viewEquip.UseVisualStyleBackColor = false;
            this.viewEquip.Click += new System.EventHandler(this.viewEquip_Click);
            // 
            // viewStaff
            // 
            this.viewStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewStaff.FlatAppearance.BorderSize = 0;
            this.viewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStaff.ForeColor = System.Drawing.SystemColors.Control;
            this.viewStaff.Location = new System.Drawing.Point(350, 358);
            this.viewStaff.Margin = new System.Windows.Forms.Padding(0);
            this.viewStaff.Name = "viewStaff";
            this.viewStaff.Size = new System.Drawing.Size(256, 38);
            this.viewStaff.TabIndex = 69;
            this.viewStaff.Text = "View Staff Lineup";
            this.viewStaff.UseVisualStyleBackColor = false;
            this.viewStaff.Click += new System.EventHandler(this.viewStaff_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLabel.Location = new System.Drawing.Point(174, 76);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(28, 25);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "--";
            // 
            // locLabel
            // 
            this.locLabel.AutoSize = true;
            this.locLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.locLabel.Location = new System.Drawing.Point(174, 137);
            this.locLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(28, 25);
            this.locLabel.TabIndex = 9;
            this.locLabel.Text = "--";
            // 
            // notesBox
            // 
            this.notesBox.BackColor = System.Drawing.Color.Silver;
            this.notesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesBox.Enabled = false;
            this.notesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.notesBox.Location = new System.Drawing.Point(65, 239);
            this.notesBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(825, 97);
            this.notesBox.TabIndex = 8;
            this.notesBox.Text = "Notes...";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.SystemColors.Control;
            this.label47.Location = new System.Drawing.Point(58, 201);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(68, 25);
            this.label47.TabIndex = 7;
            this.label47.Text = "Notes:";
            this.label47.Click += new System.EventHandler(this.label47_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.SystemColors.Control;
            this.label46.Location = new System.Drawing.Point(60, 137);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(96, 25);
            this.label46.TabIndex = 6;
            this.label46.Text = "Location: ";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.SystemColors.Control;
            this.label45.Location = new System.Drawing.Point(59, 76);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(57, 25);
            this.label45.TabIndex = 5;
            this.label45.Text = "Date:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Location = new System.Drawing.Point(30, 34);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(241, 38);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "NAME OF EVENT";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(15, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(420, 62);
            this.label9.TabIndex = 71;
            this.label9.Text = "EVENT  SCHEDULE";
            // 
            // eventSched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deetPanel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.eventGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "eventSched";
            this.Size = new System.Drawing.Size(1315, 800);
            this.Load += new System.EventHandler(this.eventSched_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).EndInit();
            this.deetPanel.ResumeLayout(false);
            this.deetPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.DataGridView eventGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button editButt;
        private System.Windows.Forms.Panel deetPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label locLabel;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Button viewEquip;
        private System.Windows.Forms.Button viewStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button viewPay;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Button cancellationButt;
        private System.Windows.Forms.Label amLabel;
        private System.Windows.Forms.Label label6;
    }
}
