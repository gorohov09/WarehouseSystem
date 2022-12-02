namespace WarehouseSystem.WinFormApp.Forms
{
    partial class MainWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_AddProductAxemplar = new System.Windows.Forms.Button();
            this.button_IssueProduct = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_MainWindow_SupplierDetail = new System.Windows.Forms.Button();
            this.button_MainWindow_AddSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.Location = new System.Drawing.Point(23, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(546, 385);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_AddProductAxemplar
            // 
            this.button_AddProductAxemplar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AddProductAxemplar.Location = new System.Drawing.Point(602, 52);
            this.button_AddProductAxemplar.Name = "button_AddProductAxemplar";
            this.button_AddProductAxemplar.Size = new System.Drawing.Size(187, 40);
            this.button_AddProductAxemplar.TabIndex = 2;
            this.button_AddProductAxemplar.Text = "Получить товар";
            this.button_AddProductAxemplar.UseVisualStyleBackColor = true;
            this.button_AddProductAxemplar.Click += new System.EventHandler(this.button_AddProductAxemplar_Click);
            // 
            // button_IssueProduct
            // 
            this.button_IssueProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_IssueProduct.Location = new System.Drawing.Point(602, 115);
            this.button_IssueProduct.Name = "button_IssueProduct";
            this.button_IssueProduct.Size = new System.Drawing.Size(187, 40);
            this.button_IssueProduct.TabIndex = 3;
            this.button_IssueProduct.Text = "Выдать товар";
            this.button_IssueProduct.UseVisualStyleBackColor = true;
            this.button_IssueProduct.Click += new System.EventHandler(this.button_IssueProduct_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Exit.Location = new System.Drawing.Point(602, 405);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(187, 40);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Выйти";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_MainWindow_SupplierDetail
            // 
            this.button_MainWindow_SupplierDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_MainWindow_SupplierDetail.Location = new System.Drawing.Point(602, 260);
            this.button_MainWindow_SupplierDetail.Name = "button_MainWindow_SupplierDetail";
            this.button_MainWindow_SupplierDetail.Size = new System.Drawing.Size(187, 57);
            this.button_MainWindow_SupplierDetail.TabIndex = 7;
            this.button_MainWindow_SupplierDetail.Text = "Вывести поставщиков";
            this.button_MainWindow_SupplierDetail.UseVisualStyleBackColor = true;
            this.button_MainWindow_SupplierDetail.Click += new System.EventHandler(this.button_MainWindow_SupplierDetail_Click);
            // 
            // button_MainWindow_AddSupplier
            // 
            this.button_MainWindow_AddSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_MainWindow_AddSupplier.Location = new System.Drawing.Point(602, 178);
            this.button_MainWindow_AddSupplier.Name = "button_MainWindow_AddSupplier";
            this.button_MainWindow_AddSupplier.Size = new System.Drawing.Size(187, 58);
            this.button_MainWindow_AddSupplier.TabIndex = 8;
            this.button_MainWindow_AddSupplier.Text = "Добавить поставщика";
            this.button_MainWindow_AddSupplier.UseVisualStyleBackColor = true;
            this.button_MainWindow_AddSupplier.Click += new System.EventHandler(this.button_MainWindow_AddSupplier_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 493);
            this.Controls.Add(this.button_MainWindow_AddSupplier);
            this.Controls.Add(this.button_MainWindow_SupplierDetail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_IssueProduct);
            this.Controls.Add(this.button_AddProductAxemplar);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_AddProductAxemplar;
        private Button button_IssueProduct;
        private Button button_Exit;
        private Button button1;
        private Button button_MainWindow_SupplierDetail;
        private Button button_MainWindow_AddSupplier;
    }
}