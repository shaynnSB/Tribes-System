namespace Tribes_System
{
    partial class equipHome
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
            this.equipGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // equipGrid
            // 
            this.equipGrid.AllowUserToAddRows = false;
            this.equipGrid.AllowUserToDeleteRows = false;
            this.equipGrid.AllowUserToResizeColumns = false;
            this.equipGrid.AllowUserToResizeRows = false;
            this.equipGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.equipGrid.Location = new System.Drawing.Point(55, 292);
            this.equipGrid.Margin = new System.Windows.Forms.Padding(4);
            this.equipGrid.Name = "equipGrid";
            this.equipGrid.ReadOnly = true;
            this.equipGrid.RowHeadersVisible = false;
            this.equipGrid.Size = new System.Drawing.Size(811, 442);
            this.equipGrid.TabIndex = 9;
            this.equipGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipGrid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "View";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Text = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // equipHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equipGrid);
            this.Name = "equipHome";
            this.Size = new System.Drawing.Size(1315, 800);
            ((System.ComponentModel.ISupportInitialize)(this.equipGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView equipGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}
