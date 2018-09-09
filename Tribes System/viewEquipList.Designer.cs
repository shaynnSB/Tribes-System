namespace Tribes_System
{
    partial class viewEquipList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewEquipList));
            this.minButt = new System.Windows.Forms.Button();
            this.closeButt = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.eventLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title.SuspendLayout();
            this.SuspendLayout();
            // 
            // minButt
            // 
            this.minButt.FlatAppearance.BorderSize = 0;
            this.minButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.minButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.minButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButt.Image = ((System.Drawing.Image)(resources.GetObject("minButt.Image")));
            this.minButt.Location = new System.Drawing.Point(523, 1);
            this.minButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minButt.Name = "minButt";
            this.minButt.Size = new System.Drawing.Size(41, 42);
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
            this.closeButt.Location = new System.Drawing.Point(576, 1);
            this.closeButt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(41, 42);
            this.closeButt.TabIndex = 0;
            this.closeButt.UseVisualStyleBackColor = true;
            this.closeButt.Click += new System.EventHandler(this.closeButt_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.Controls.Add(this.label2);
            this.title.Controls.Add(this.minButt);
            this.title.Controls.Add(this.closeButt);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(624, 46);
            this.title.TabIndex = 1;
            this.title.Paint += new System.Windows.Forms.PaintEventHandler(this.title_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "List of Equipment";
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eventLabel.Location = new System.Drawing.Point(28, 75);
            this.eventLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(419, 69);
            this.eventLabel.TabIndex = 41;
            this.eventLabel.Text = "EVENT NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(40, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "LIST OF EQUIPMENT";
            // 
            // viewEquipList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 873);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "viewEquipList";
            this.Text = "viewEquipList";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewEquipList_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewEquipList_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewEquipList_MouseUp);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minButt;
        private System.Windows.Forms.Button closeButt;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}