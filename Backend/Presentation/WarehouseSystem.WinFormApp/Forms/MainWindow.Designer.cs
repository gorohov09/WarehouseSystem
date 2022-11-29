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
            this.button_AddProduct = new System.Windows.Forms.Button();
            this.button_AddProductAxemplar = new System.Windows.Forms.Button();
            this.button_IssueProduct = new System.Windows.Forms.Button();
            this.button_DeleteProduct = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // button_AddProduct
            // 
            this.button_AddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AddProduct.Location = new System.Drawing.Point(602, 37);
            this.button_AddProduct.Name = "button_AddProduct";
            this.button_AddProduct.Size = new System.Drawing.Size(187, 40);
            this.button_AddProduct.TabIndex = 1;
            this.button_AddProduct.Text = "Добавить товар";
            this.button_AddProduct.UseVisualStyleBackColor = true;
            // 
            // button_AddProductAxemplar
            // 
            this.button_AddProductAxemplar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AddProductAxemplar.Location = new System.Drawing.Point(602, 105);
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
            this.button_IssueProduct.Location = new System.Drawing.Point(602, 176);
            this.button_IssueProduct.Name = "button_IssueProduct";
            this.button_IssueProduct.Size = new System.Drawing.Size(187, 40);
            this.button_IssueProduct.TabIndex = 3;
            this.button_IssueProduct.Text = "Выдать товар";
            this.button_IssueProduct.UseVisualStyleBackColor = true;
            // 
            // button_DeleteProduct
            // 
            this.button_DeleteProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_DeleteProduct.Location = new System.Drawing.Point(602, 253);
            this.button_DeleteProduct.Name = "button_DeleteProduct";
            this.button_DeleteProduct.Size = new System.Drawing.Size(187, 40);
            this.button_DeleteProduct.TabIndex = 4;
            this.button_DeleteProduct.Text = "Удалить товар";
            this.button_DeleteProduct.UseVisualStyleBackColor = true;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_DeleteProduct);
            this.Controls.Add(this.button_IssueProduct);
            this.Controls.Add(this.button_AddProductAxemplar);
            this.Controls.Add(this.button_AddProduct);
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
        private Button button_AddProduct;
        private Button button_AddProductAxemplar;
        private Button button_IssueProduct;
        private Button button_DeleteProduct;
        private Button button_Exit;
        private Button button1;
    }
}