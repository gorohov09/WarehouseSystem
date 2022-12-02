namespace WarehouseSystem.WinFormApp.Forms
{
    partial class SupplierDetailWindow
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
            this.dataGridView_SupplierDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupplierDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SupplierDetail
            // 
            this.dataGridView_SupplierDetail.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView_SupplierDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SupplierDetail.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_SupplierDetail.Name = "dataGridView_SupplierDetail";
            this.dataGridView_SupplierDetail.RowHeadersWidth = 51;
            this.dataGridView_SupplierDetail.RowTemplate.Height = 29;
            this.dataGridView_SupplierDetail.Size = new System.Drawing.Size(822, 469);
            this.dataGridView_SupplierDetail.TabIndex = 0;
            // 
            // SupplierDetailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 493);
            this.Controls.Add(this.dataGridView_SupplierDetail);
            this.MaximizeBox = false;
            this.Name = "SupplierDetailWindow";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.SupplierDetailWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupplierDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_SupplierDetail;
    }
}