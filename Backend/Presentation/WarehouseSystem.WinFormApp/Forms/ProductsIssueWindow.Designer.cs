namespace WarehouseSystem.WinFormApp.Forms
{
    partial class ProductsIssueWindow
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
            this.dataGridView_ProductsIssue = new System.Windows.Forms.DataGridView();
            this.textBox_InputProductSKU = new System.Windows.Forms.TextBox();
            this.textBox_InputProductsExemplarsCount = new System.Windows.Forms.TextBox();
            this.label_InputProductSKU = new System.Windows.Forms.Label();
            this.label_InputProductsExemplarsCount = new System.Windows.Forms.Label();
            this.button_IssueProductsExemplars = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductsIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ProductsIssue
            // 
            this.dataGridView_ProductsIssue.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView_ProductsIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProductsIssue.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_ProductsIssue.Name = "dataGridView_ProductsIssue";
            this.dataGridView_ProductsIssue.RowHeadersWidth = 51;
            this.dataGridView_ProductsIssue.RowTemplate.Height = 29;
            this.dataGridView_ProductsIssue.Size = new System.Drawing.Size(498, 188);
            this.dataGridView_ProductsIssue.TabIndex = 0;
            this.dataGridView_ProductsIssue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ProductsIssue_CellContentClick);
            // 
            // textBox_InputProductSKU
            // 
            this.textBox_InputProductSKU.Location = new System.Drawing.Point(133, 259);
            this.textBox_InputProductSKU.Name = "textBox_InputProductSKU";
            this.textBox_InputProductSKU.Size = new System.Drawing.Size(125, 27);
            this.textBox_InputProductSKU.TabIndex = 1;
            // 
            // textBox_InputProductsExemplarsCount
            // 
            this.textBox_InputProductsExemplarsCount.Location = new System.Drawing.Point(133, 304);
            this.textBox_InputProductsExemplarsCount.Name = "textBox_InputProductsExemplarsCount";
            this.textBox_InputProductsExemplarsCount.Size = new System.Drawing.Size(125, 27);
            this.textBox_InputProductsExemplarsCount.TabIndex = 2;
            // 
            // label_InputProductSKU
            // 
            this.label_InputProductSKU.AutoSize = true;
            this.label_InputProductSKU.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_InputProductSKU.Location = new System.Drawing.Point(48, 260);
            this.label_InputProductSKU.Name = "label_InputProductSKU";
            this.label_InputProductSKU.Size = new System.Drawing.Size(79, 23);
            this.label_InputProductSKU.TabIndex = 3;
            this.label_InputProductSKU.Text = "Артикул:";
            // 
            // label_InputProductsExemplarsCount
            // 
            this.label_InputProductsExemplarsCount.AutoSize = true;
            this.label_InputProductsExemplarsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_InputProductsExemplarsCount.Location = new System.Drawing.Point(21, 305);
            this.label_InputProductsExemplarsCount.Name = "label_InputProductsExemplarsCount";
            this.label_InputProductsExemplarsCount.Size = new System.Drawing.Size(107, 23);
            this.label_InputProductsExemplarsCount.TabIndex = 4;
            this.label_InputProductsExemplarsCount.Text = "Количество:";
            // 
            // button_IssueProductsExemplars
            // 
            this.button_IssueProductsExemplars.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_IssueProductsExemplars.Location = new System.Drawing.Point(347, 303);
            this.button_IssueProductsExemplars.Name = "button_IssueProductsExemplars";
            this.button_IssueProductsExemplars.Size = new System.Drawing.Size(130, 29);
            this.button_IssueProductsExemplars.TabIndex = 5;
            this.button_IssueProductsExemplars.Text = "Выдать";
            this.button_IssueProductsExemplars.UseVisualStyleBackColor = true;
            this.button_IssueProductsExemplars.Click += new System.EventHandler(this.button_IssueProductsExemplars_Click);
            // 
            // ProductsIssueWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 373);
            this.Controls.Add(this.button_IssueProductsExemplars);
            this.Controls.Add(this.label_InputProductsExemplarsCount);
            this.Controls.Add(this.label_InputProductSKU);
            this.Controls.Add(this.textBox_InputProductsExemplarsCount);
            this.Controls.Add(this.textBox_InputProductSKU);
            this.Controls.Add(this.dataGridView_ProductsIssue);
            this.MaximizeBox = false;
            this.Name = "ProductsIssueWindow";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ProductsIssueWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductsIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView_ProductsIssue;
        private TextBox textBox_InputProductSKU;
        private TextBox textBox_InputProductsExemplarsCount;
        private Label label_InputProductSKU;
        private Label label_InputProductsExemplarsCount;
        private Button button_IssueProductsExemplars;
    }
}