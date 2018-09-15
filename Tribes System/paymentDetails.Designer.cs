namespace Tribes_System
{
    partial class paymentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.eventLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.minButt = new System.Windows.Forms.Button();
            this.closeButt = new System.Windows.Forms.Button();
            this.paidBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(16, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Payment Details";
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eventLabel.Location = new System.Drawing.Point(10, 48);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(336, 55);
            this.eventLabel.TabIndex = 47;
            this.eventLabel.Text = "EVENT NAME";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.Controls.Add(this.label2);
            this.title.Controls.Add(this.minButt);
            this.title.Controls.Add(this.closeButt);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(464, 37);
            this.title.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Payment Details";
            // 
            // minButt
            // 
            this.minButt.FlatAppearance.BorderSize = 0;
            this.minButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.minButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.minButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButt.Image = ((System.Drawing.Image)(resources.GetObject("minButt.Image")));
            this.minButt.Location = new System.Drawing.Point(392, 1);
            this.minButt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minButt.Name = "minButt";
            this.minButt.Size = new System.Drawing.Size(31, 34);
            this.minButt.TabIndex = 1;
            this.minButt.UseVisualStyleBackColor = true;
            // 
            // closeButt
            // 
            this.closeButt.FlatAppearance.BorderSize = 0;
            this.closeButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.closeButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.closeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButt.Image = ((System.Drawing.Image)(resources.GetObject("closeButt.Image")));
            this.closeButt.Location = new System.Drawing.Point(432, 1);
            this.closeButt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(31, 34);
            this.closeButt.TabIndex = 0;
            this.closeButt.UseVisualStyleBackColor = true;
            // 
            // paidBox
            // 
            this.paidBox.BackColor = System.Drawing.Color.LightGray;
            this.paidBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paidBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidBox.ForeColor = System.Drawing.Color.Gray;
            this.paidBox.Location = new System.Drawing.Point(122, 553);
            this.paidBox.Name = "paidBox";
            this.paidBox.Size = new System.Drawing.Size(171, 22);
            this.paidBox.TabIndex = 49;
            this.paidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(15, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Amount Paid: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 147);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(421, 322);
            this.dataGridView1.TabIndex = 51;
            // 
            // paymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 628);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paidBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "paymentDetails";
            this.Text = "paymentDetails";
            this.Load += new System.EventHandler(this.paymentDetails_Load);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button minButt;
        private System.Windows.Forms.Button closeButt;
        private System.Windows.Forms.TextBox paidBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}