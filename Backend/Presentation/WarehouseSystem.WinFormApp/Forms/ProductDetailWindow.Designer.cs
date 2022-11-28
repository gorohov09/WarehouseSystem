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
            this.label_ProductDetail_ProductSKU = new System.Windows.Forms.Label();
            this.label_ProductDetail_ProductSKU_Output = new System.Windows.Forms.Label();
            this.label_ProductDetail_Name_Output = new System.Windows.Forms.Label();
            this.label_productDetail_Name = new System.Windows.Forms.Label();
            this.label_ProductDetail_CityProd_Output = new System.Windows.Forms.Label();
            this.label_ProductDetail_CityProd = new System.Windows.Forms.Label();
            this.label_ProductDetail_DateProd_Output = new System.Windows.Forms.Label();
            this.label_ProductDetail_DateProd = new System.Windows.Forms.Label();
            this.label_ProductDetail_NumbOfCopies_Output = new System.Windows.Forms.Label();
            this.label_ProductDetail_NumbOfCopies = new System.Windows.Forms.Label();
            this.label_ProductDetail_PriceProd_Output = new System.Windows.Forms.Label();
            this.label_ProductDetail_PriceProd = new System.Windows.Forms.Label();
            this.label_ProductDetail_VendorNumber_Output = new System.Windows.Forms.Label();
            this.label_ProductDetail_VendorNumber = new System.Windows.Forms.Label();
            this.label_ProductDetail_IsCertificatePresent_Output = new System.Windows.Forms.Label();
            this.label_ProductDetail_IsCertificatePresent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ProductDetail
            // 
            this.dataGridView_ProductDetail.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView_ProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProductDetail.Location = new System.Drawing.Point(418, 12);
            this.dataGridView_ProductDetail.Name = "dataGridView_ProductDetail";
            this.dataGridView_ProductDetail.RowHeadersWidth = 51;
            this.dataGridView_ProductDetail.RowTemplate.Height = 29;
            this.dataGridView_ProductDetail.Size = new System.Drawing.Size(272, 309);
            this.dataGridView_ProductDetail.TabIndex = 0;
            // 
            // label_ProductDetail_ProductSKU
            // 
            this.label_ProductDetail_ProductSKU.AutoSize = true;
            this.label_ProductDetail_ProductSKU.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductDetail_ProductSKU.Location = new System.Drawing.Point(12, 15);
            this.label_ProductDetail_ProductSKU.Name = "label_ProductDetail_ProductSKU";
            this.label_ProductDetail_ProductSKU.Size = new System.Drawing.Size(84, 23);
            this.label_ProductDetail_ProductSKU.TabIndex = 1;
            this.label_ProductDetail_ProductSKU.Text = "Артикул: ";
            // 
            // label_ProductDetail_ProductSKU_Output
            // 
            this.label_ProductDetail_ProductSKU_Output.AutoSize = true;
            this.label_ProductDetail_ProductSKU_Output.Location = new System.Drawing.Point(102, 18);
            this.label_ProductDetail_ProductSKU_Output.Name = "label_ProductDetail_ProductSKU_Output";
            this.label_ProductDetail_ProductSKU_Output.Size = new System.Drawing.Size(42, 20);
            this.label_ProductDetail_ProductSKU_Output.TabIndex = 2;
            this.label_ProductDetail_ProductSKU_Output.Text = "none";
            // 
            // label_ProductDetail_Name_Output
            // 
            this.label_ProductDetail_Name_Output.AutoSize = true;
            this.label_ProductDetail_Name_Output.Location = new System.Drawing.Point(153, 52);
            this.label_ProductDetail_Name_Output.Name = "label_ProductDetail_Name_Output";
            this.label_ProductDetail_Name_Output.Size = new System.Drawing.Size(42, 20);
            this.label_ProductDetail_Name_Output.TabIndex = 4;
            this.label_ProductDetail_Name_Output.Text = "none";
            // 
            // label_productDetail_Name
            // 
            this.label_productDetail_Name.AutoSize = true;
            this.label_productDetail_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_productDetail_Name.Location = new System.Drawing.Point(12, 49);
            this.label_productDetail_Name.Name = "label_productDetail_Name";
            this.label_productDetail_Name.Size = new System.Drawing.Size(135, 23);
            this.label_productDetail_Name.TabIndex = 3;
            this.label_productDetail_Name.Text = "Наименование:";
            // 
            // label_ProductDetail_CityProd_Output
            // 
            this.label_ProductDetail_CityProd_Output.AutoSize = true;
            this.label_ProductDetail_CityProd_Output.Location = new System.Drawing.Point(78, 88);
            this.label_ProductDetail_CityProd_Output.Name = "label_ProductDetail_CityProd_Output";
            this.label_ProductDetail_CityProd_Output.Size = new System.Drawing.Size(42, 20);
            this.label_ProductDetail_CityProd_Output.TabIndex = 6;
            this.label_ProductDetail_CityProd_Output.Text = "none";
            // 
            // label_ProductDetail_CityProd
            // 
            this.label_ProductDetail_CityProd.AutoSize = true;
            this.label_ProductDetail_CityProd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductDetail_CityProd.Location = new System.Drawing.Point(12, 86);
            this.label_ProductDetail_CityProd.Name = "label_ProductDetail_CityProd";
            this.label_ProductDetail_CityProd.Size = new System.Drawing.Size(60, 23);
            this.label_ProductDetail_CityProd.TabIndex = 5;
            this.label_ProductDetail_CityProd.Text = "Город:";
            // 
            // label_ProductDetail_DateProd_Output
            // 
            this.label_ProductDetail_DateProd_Output.AutoSize = true;
            this.label_ProductDetail_DateProd_Output.Location = new System.Drawing.Point(183, 126);
            this.label_ProductDetail_DateProd_Output.Name = "label_ProductDetail_DateProd_Output";
            this.label_ProductDetail_DateProd_Output.Size = new System.Drawing.Size(42, 20);
            this.label_ProductDetail_DateProd_Output.TabIndex = 8;
            this.label_ProductDetail_DateProd_Output.Text = "none";
            // 
            // label_ProductDetail_DateProd
            // 
            this.label_ProductDetail_DateProd.AutoSize = true;
            this.label_ProductDetail_DateProd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductDetail_DateProd.Location = new System.Drawing.Point(12, 124);
            this.label_ProductDetail_DateProd.Name = "label_ProductDetail_DateProd";
            this.label_ProductDetail_DateProd.Size = new System.Drawing.Size(165, 23);
            this.label_ProductDetail_DateProd.TabIndex = 7;
            this.label_ProductDetail_DateProd.Text = "Дата изготовления:";
            this.label_ProductDetail_DateProd.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_ProductDetail_NumbOfCopies_Output
            // 
            this.label_ProductDetail_NumbOfCopies_Output.AutoSize = true;
            this.label_ProductDetail_NumbOfCopies_Output.Location = new System.Drawing.Point(129, 165);
            this.label_ProductDetail_NumbOfCopies_Output.Name = "label_ProductDetail_NumbOfCopies_Output";
            this.label_ProductDetail_NumbOfCopies_Output.Size = new System.Drawing.Size(42, 20);
            this.label_ProductDetail_NumbOfCopies_Output.TabIndex = 10;
            this.label_ProductDetail_NumbOfCopies_Output.Text = "none";
            // 
            // label_ProductDetail_NumbOfCopies
            // 
            this.label_ProductDetail_NumbOfCopies.AutoSize = true;
            this.label_ProductDetail_NumbOfCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductDetail_NumbOfCopies.Location = new System.Drawing.Point(16, 162);
            this.label_ProductDetail_NumbOfCopies.Name = "label_ProductDetail_NumbOfCopies";
            this.label_ProductDetail_NumbOfCopies.Size = new System.Drawing.Size(107, 23);
            this.label_ProductDetail_NumbOfCopies.TabIndex = 9;
            this.label_ProductDetail_NumbOfCopies.Text = "Количество:";
            // 
            // label_ProductDetail_PriceProd_Output
            // 
            this.label_ProductDetail_PriceProd_Output.AutoSize = true;
            this.label_ProductDetail_PriceProd_Output.Location = new System.Drawing.Point(77, 201);
            this.label_ProductDetail_PriceProd_Output.Name = "label_ProductDetail_PriceProd_Output";
            this.label_ProductDetail_PriceProd_Output.Size = new System.Drawing.Size(42, 20);
            this.label_ProductDetail_PriceProd_Output.TabIndex = 12;
            this.label_ProductDetail_PriceProd_Output.Text = "none";
            // 
            // label_ProductDetail_PriceProd
            // 
            this.label_ProductDetail_PriceProd.AutoSize = true;
            this.label_ProductDetail_PriceProd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductDetail_PriceProd.Location = new System.Drawing.Point(16, 198);
            this.label_ProductDetail_PriceProd.Name = "label_ProductDetail_PriceProd";
            this.label_ProductDetail_PriceProd.Size = new System.Drawing.Size(55, 23);
            this.label_ProductDetail_PriceProd.TabIndex = 11;
            this.label_ProductDetail_PriceProd.Text = "Цена:";
            // 
            // label_ProductDetail_VendorNumber_Output
            // 
            this.label_ProductDetail_VendorNumber_Output.AutoSize = true;
            this.label_ProductDetail_VendorNumber_Output.Location = new System.Drawing.Point(192, 239);
            this.label_ProductDetail_VendorNumber_Output.Name = "label_ProductDetail_VendorNumber_Output";
            this.label_ProductDetail_VendorNumber_Output.Size = new System.Drawing.Size(42, 20);
            this.label_ProductDetail_VendorNumber_Output.TabIndex = 14;
            this.label_ProductDetail_VendorNumber_Output.Text = "none";
            // 
            // label_ProductDetail_VendorNumber
            // 
            this.label_ProductDetail_VendorNumber.AutoSize = true;
            this.label_ProductDetail_VendorNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductDetail_VendorNumber.Location = new System.Drawing.Point(16, 237);
            this.label_ProductDetail_VendorNumber.Name = "label_ProductDetail_VendorNumber";
            this.label_ProductDetail_VendorNumber.Size = new System.Drawing.Size(170, 23);
            this.label_ProductDetail_VendorNumber.TabIndex = 13;
            this.label_ProductDetail_VendorNumber.Text = "Номер поставщика:";
            // 
            // label_ProductDetail_IsCertificatePresent_Output
            // 
            this.label_ProductDetail_IsCertificatePresent_Output.AutoSize = true;
            this.label_ProductDetail_IsCertificatePresent_Output.Location = new System.Drawing.Point(129, 279);
            this.label_ProductDetail_IsCertificatePresent_Output.Name = "label_ProductDetail_IsCertificatePresent_Output";
            this.label_ProductDetail_IsCertificatePresent_Output.Size = new System.Drawing.Size(42, 20);
            this.label_ProductDetail_IsCertificatePresent_Output.TabIndex = 16;
            this.label_ProductDetail_IsCertificatePresent_Output.Text = "none";
            // 
            // label_ProductDetail_IsCertificatePresent
            // 
            this.label_ProductDetail_IsCertificatePresent.AutoSize = true;
            this.label_ProductDetail_IsCertificatePresent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductDetail_IsCertificatePresent.Location = new System.Drawing.Point(15, 276);
            this.label_ProductDetail_IsCertificatePresent.Name = "label_ProductDetail_IsCertificatePresent";
            this.label_ProductDetail_IsCertificatePresent.Size = new System.Drawing.Size(108, 23);
            this.label_ProductDetail_IsCertificatePresent.TabIndex = 15;
            this.label_ProductDetail_IsCertificatePresent.Text = "Сертификат:";
            // 
            // ProductDetailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.label_ProductDetail_IsCertificatePresent_Output);
            this.Controls.Add(this.label_ProductDetail_IsCertificatePresent);
            this.Controls.Add(this.label_ProductDetail_VendorNumber_Output);
            this.Controls.Add(this.label_ProductDetail_VendorNumber);
            this.Controls.Add(this.label_ProductDetail_PriceProd_Output);
            this.Controls.Add(this.label_ProductDetail_PriceProd);
            this.Controls.Add(this.label_ProductDetail_NumbOfCopies_Output);
            this.Controls.Add(this.label_ProductDetail_NumbOfCopies);
            this.Controls.Add(this.label_ProductDetail_DateProd_Output);
            this.Controls.Add(this.label_ProductDetail_DateProd);
            this.Controls.Add(this.label_ProductDetail_CityProd_Output);
            this.Controls.Add(this.label_ProductDetail_CityProd);
            this.Controls.Add(this.label_ProductDetail_Name_Output);
            this.Controls.Add(this.label_productDetail_Name);
            this.Controls.Add(this.label_ProductDetail_ProductSKU_Output);
            this.Controls.Add(this.label_ProductDetail_ProductSKU);
            this.Controls.Add(this.dataGridView_ProductDetail);
            this.MaximizeBox = false;
            this.Name = "ProductDetailWindow";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView_ProductDetail;
        private Label label_ProductDetail_ProductSKU;
        private Label label_ProductDetail_ProductSKU_Output;
        private Label label_ProductDetail_Name_Output;
        private Label label_productDetail_Name;
        private Label label_ProductDetail_CityProd_Output;
        private Label label_ProductDetail_CityProd;
        private Label label_ProductDetail_DateProd_Output;
        private Label label_ProductDetail_DateProd;
        private Label label_ProductDetail_NumbOfCopies_Output;
        private Label label_ProductDetail_NumbOfCopies;
        private Label label_ProductDetail_PriceProd_Output;
        private Label label_ProductDetail_PriceProd;
        private Label label_ProductDetail_VendorNumber_Output;
        private Label label_ProductDetail_VendorNumber;
        private Label label_ProductDetail_IsCertificatePresent_Output;
        private Label label_ProductDetail_IsCertificatePresent;
    }
}