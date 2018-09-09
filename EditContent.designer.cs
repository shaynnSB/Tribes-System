namespace Tribes_System
{
    partial class EditContent
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dd = new System.Windows.Forms.Label();
            this.repcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name / Model Number";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Deployable",
            "Damaged"});
            this.comboBox1.Location = new System.Drawing.Point(483, 78);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(177, 129);
            this.dtp1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(295, 22);
            this.dtp1.TabIndex = 4;
            this.dtp1.Visible = false;
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Location = new System.Drawing.Point(16, 137);
            this.dd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(103, 17);
            this.dd.TabIndex = 5;
            this.dd.Text = "Date Damaged";
            this.dd.Visible = false;
            // 
            // repcount
            // 
            this.repcount.AutoSize = true;
            this.repcount.Location = new System.Drawing.Point(16, 34);
            this.repcount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.repcount.Name = "repcount";
            this.repcount.Size = new System.Drawing.Size(149, 17);
            this.repcount.TabIndex = 6;
            this.repcount.Text = "Name / Model Number";
            this.repcount.Visible = false;
            // 
            // EditContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 262);
            this.Controls.Add(this.repcount);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Content";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.Label repcount;
    }
}