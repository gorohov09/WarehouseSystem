namespace WarehouseSystem.WinFormApp.Forms
{
    partial class ProductDetailWindow
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
            this.dataGridView_ProductDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ProductDetail
            // 
            this.dataGridView_ProductDetail.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView_ProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProductDetail.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_ProductDetail.Name = "dataGridView_ProductDetail";
            this.dataGridView_ProductDetail.RowHeadersWidth = 51;
            this.dataGridView_ProductDetail.RowTemplate.Height = 29;
            this.dataGridView_ProductDetail.Size = new System.Drawing.Size(678, 324);
            this.dataGridView_ProductDetail.TabIndex = 0;
            // 
            // ProductDetailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 493);
            this.Controls.Add(this.dataGridView_ProductDetail);
            this.MaximizeBox = false;
            this.Name = "ProductDetailWindow";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_ProductDetail;
    }
}