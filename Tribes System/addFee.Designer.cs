namespace Tribes_System
{
    partial class addFee
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
            this.label10 = new System.Windows.Forms.Label();
            this.recievedBox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButt = new System.Windows.Forms.Button();
            this.saveButt = new System.Windows.Forms.Button();
            this.title.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(24, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 101;
            this.label10.Text = "Amount:";
            // 
            // recievedBox
            // 
            this.recievedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recievedBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recievedBox.Location = new System.Drawing.Point(106, 79);
            this.recievedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recievedBox.Name = "recievedBox";
            this.recievedBox.Size = new System.Drawing.Size(198, 26);
            this.recievedBox.TabIndex = 100;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.Controls.Add(this.label2);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(342, 37);
            this.title.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 105;
            this.label2.Text = "Additional Fee";
            // 
            // cancelButt
            // 
            this.cancelButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButt.FlatAppearance.BorderSize = 0;
            this.cancelButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.cancelButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButt.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButt.Location = new System.Drawing.Point(160, 159);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(142, 25);
            this.cancelButt.TabIndex = 104;
            this.cancelButt.Text = "CANCEL";
            this.cancelButt.UseVisualStyleBackColor = false;
            this.cancelButt.Click += new System.EventHandler(this.cancelButt_Click);
            // 
            // saveButt
            // 
            this.saveButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButt.FlatAppearance.BorderSize = 0;
            this.saveButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.saveButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.saveButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButt.ForeColor = System.Drawing.SystemColors.Control;
            this.saveButt.Location = new System.Drawing.Point(160, 128);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(142, 25);
            this.saveButt.TabIndex = 103;
            this.saveButt.Text = "ADD";
            this.saveButt.UseVisualStyleBackColor = false;
            this.saveButt.Click += new System.EventHandler(this.saveButt_Click);
            // 
            // addFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 219);
            this.Controls.Add(this.cancelButt);
            this.Controls.Add(this.saveButt);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.recievedBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addFee";
            this.Load += new System.EventHandler(this.addFee_Load);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox recievedBox;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Button cancelButt;
        private System.Windows.Forms.Button saveButt;
        private System.Windows.Forms.Label label2;
    }
}