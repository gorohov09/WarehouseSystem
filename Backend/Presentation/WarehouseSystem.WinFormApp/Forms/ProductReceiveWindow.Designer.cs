namespace WarehouseSystem.WinFormApp.Forms
{
    partial class ProductReceiveWindow
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
            this.label_ProductReceive_ProductSKU = new System.Windows.Forms.Label();
            this.textBox_ProductReceive_Name_Input = new System.Windows.Forms.TextBox();
            this.label_ProductReceive_Name = new System.Windows.Forms.Label();
            this.textBox_ProductReceive_CityProd_Input = new System.Windows.Forms.TextBox();
            this.label_ProductReceive_CityProd = new System.Windows.Forms.Label();
            this.textBox_ProductReceive_DateProd_Input = new System.Windows.Forms.TextBox();
            this.label_ProductReceive_DateProd = new System.Windows.Forms.Label();
            this.textBox_ProductReceive_NumbOfCopies_Input = new System.Windows.Forms.TextBox();
            this.label_ProductReceive_NumbOfCopies = new System.Windows.Forms.Label();
            this.textBox_ProductReceive_PriceProd_Input = new System.Windows.Forms.TextBox();
            this.label_ProductReceive_PriceProd = new System.Windows.Forms.Label();
            this.textBox_ProductReceive_VendorNumber_Input = new System.Windows.Forms.TextBox();
            this.label_ProductReceive_VendorNumber = new System.Windows.Forms.Label();
            this.radioButton_ProductReceive_IsCertificatePresent_True = new System.Windows.Forms.RadioButton();
            this.radioButton_ProductReceive_IsCertificatePresent_False = new System.Windows.Forms.RadioButton();
            this.groupBox_ProductReceive_IsCertificatePresent = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_ProductReceiveWindow_Suppliers = new System.Windows.Forms.DataGridView();
            this.groupBox_ProductReceive_IsCertificatePresent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductReceiveWindow_Suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ProductReceive_ProductSKU
            // 
            this.label_ProductReceive_ProductSKU.AutoSize = true;
            this.label_ProductReceive_ProductSKU.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductReceive_ProductSKU.Location = new System.Drawing.Point(41, 9);
            this.label_ProductReceive_ProductSKU.Name = "label_ProductReceive_ProductSKU";
            this.label_ProductReceive_ProductSKU.Size = new System.Drawing.Size(0, 23);
            this.label_ProductReceive_ProductSKU.TabIndex = 0;
            // 
            // textBox_ProductReceive_Name_Input
            // 
            this.textBox_ProductReceive_Name_Input.Location = new System.Drawing.Point(31, 35);
            this.textBox_ProductReceive_Name_Input.Name = "textBox_ProductReceive_Name_Input";
            this.textBox_ProductReceive_Name_Input.Size = new System.Drawing.Size(260, 27);
            this.textBox_ProductReceive_Name_Input.TabIndex = 3;
            // 
            // label_ProductReceive_Name
            // 
            this.label_ProductReceive_Name.AutoSize = true;
            this.label_ProductReceive_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductReceive_Name.Location = new System.Drawing.Point(31, 9);
            this.label_ProductReceive_Name.Name = "label_ProductReceive_Name";
            this.label_ProductReceive_Name.Size = new System.Drawing.Size(131, 23);
            this.label_ProductReceive_Name.TabIndex = 2;
            this.label_ProductReceive_Name.Text = "Наименование";
            // 
            // textBox_ProductReceive_CityProd_Input
            // 
            this.textBox_ProductReceive_CityProd_Input.Location = new System.Drawing.Point(31, 91);
            this.textBox_ProductReceive_CityProd_Input.Name = "textBox_ProductReceive_CityProd_Input";
            this.textBox_ProductReceive_CityProd_Input.Size = new System.Drawing.Size(260, 27);
            this.textBox_ProductReceive_CityProd_Input.TabIndex = 5;
            // 
            // label_ProductReceive_CityProd
            // 
            this.label_ProductReceive_CityProd.AutoSize = true;
            this.label_ProductReceive_CityProd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductReceive_CityProd.Location = new System.Drawing.Point(31, 65);
            this.label_ProductReceive_CityProd.Name = "label_ProductReceive_CityProd";
            this.label_ProductReceive_CityProd.Size = new System.Drawing.Size(175, 23);
            this.label_ProductReceive_CityProd.TabIndex = 4;
            this.label_ProductReceive_CityProd.Text = "Город производства:";
            // 
            // textBox_ProductReceive_DateProd_Input
            // 
            this.textBox_ProductReceive_DateProd_Input.Location = new System.Drawing.Point(31, 148);
            this.textBox_ProductReceive_DateProd_Input.Name = "textBox_ProductReceive_DateProd_Input";
            this.textBox_ProductReceive_DateProd_Input.Size = new System.Drawing.Size(260, 27);
            this.textBox_ProductReceive_DateProd_Input.TabIndex = 7;
            // 
            // label_ProductReceive_DateProd
            // 
            this.label_ProductReceive_DateProd.AutoSize = true;
            this.label_ProductReceive_DateProd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductReceive_DateProd.Location = new System.Drawing.Point(31, 122);
            this.label_ProductReceive_DateProd.Name = "label_ProductReceive_DateProd";
            this.label_ProductReceive_DateProd.Size = new System.Drawing.Size(166, 23);
            this.label_ProductReceive_DateProd.TabIndex = 6;
            this.label_ProductReceive_DateProd.Text = "Дата производства:";
            // 
            // textBox_ProductReceive_NumbOfCopies_Input
            // 
            this.textBox_ProductReceive_NumbOfCopies_Input.Location = new System.Drawing.Point(306, 35);
            this.textBox_ProductReceive_NumbOfCopies_Input.Name = "textBox_ProductReceive_NumbOfCopies_Input";
            this.textBox_ProductReceive_NumbOfCopies_Input.Size = new System.Drawing.Size(260, 27);
            this.textBox_ProductReceive_NumbOfCopies_Input.TabIndex = 9;
            // 
            // label_ProductReceive_NumbOfCopies
            // 
            this.label_ProductReceive_NumbOfCopies.AutoSize = true;
            this.label_ProductReceive_NumbOfCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductReceive_NumbOfCopies.Location = new System.Drawing.Point(316, 9);
            this.label_ProductReceive_NumbOfCopies.Name = "label_ProductReceive_NumbOfCopies";
            this.label_ProductReceive_NumbOfCopies.Size = new System.Drawing.Size(107, 23);
            this.label_ProductReceive_NumbOfCopies.TabIndex = 8;
            this.label_ProductReceive_NumbOfCopies.Text = "Количество:";
            // 
            // textBox_ProductReceive_PriceProd_Input
            // 
            this.textBox_ProductReceive_PriceProd_Input.Location = new System.Drawing.Point(306, 91);
            this.textBox_ProductReceive_PriceProd_Input.Name = "textBox_ProductReceive_PriceProd_Input";
            this.textBox_ProductReceive_PriceProd_Input.Size = new System.Drawing.Size(260, 27);
            this.textBox_ProductReceive_PriceProd_Input.TabIndex = 11;
            // 
            // label_ProductReceive_PriceProd
            // 
            this.label_ProductReceive_PriceProd.AutoSize = true;
            this.label_ProductReceive_PriceProd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductReceive_PriceProd.Location = new System.Drawing.Point(316, 65);
            this.label_ProductReceive_PriceProd.Name = "label_ProductReceive_PriceProd";
            this.label_ProductReceive_PriceProd.Size = new System.Drawing.Size(55, 23);
            this.label_ProductReceive_PriceProd.TabIndex = 10;
            this.label_ProductReceive_PriceProd.Text = "Цена:";
            // 
            // textBox_ProductReceive_VendorNumber_Input
            // 
            this.textBox_ProductReceive_VendorNumber_Input.Location = new System.Drawing.Point(306, 148);
            this.textBox_ProductReceive_VendorNumber_Input.Name = "textBox_ProductReceive_VendorNumber_Input";
            this.textBox_ProductReceive_VendorNumber_Input.Size = new System.Drawing.Size(260, 27);
            this.textBox_ProductReceive_VendorNumber_Input.TabIndex = 13;
            // 
            // label_ProductReceive_VendorNumber
            // 
            this.label_ProductReceive_VendorNumber.AutoSize = true;
            this.label_ProductReceive_VendorNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ProductReceive_VendorNumber.Location = new System.Drawing.Point(316, 122);
            this.label_ProductReceive_VendorNumber.Name = "label_ProductReceive_VendorNumber";
            this.label_ProductReceive_VendorNumber.Size = new System.Drawing.Size(170, 23);
            this.label_ProductReceive_VendorNumber.TabIndex = 12;
            this.label_ProductReceive_VendorNumber.Text = "Номер поставщика:";
            // 
            // radioButton_ProductReceive_IsCertificatePresent_True
            // 
            this.radioButton_ProductReceive_IsCertificatePresent_True.AutoSize = true;
            this.radioButton_ProductReceive_IsCertificatePresent_True.Location = new System.Drawing.Point(6, 29);
            this.radioButton_ProductReceive_IsCertificatePresent_True.Name = "radioButton_ProductReceive_IsCertificatePresent_True";
            this.radioButton_ProductReceive_IsCertificatePresent_True.Size = new System.Drawing.Size(115, 27);
            this.radioButton_ProductReceive_IsCertificatePresent_True.TabIndex = 16;
            this.radioButton_ProductReceive_IsCertificatePresent_True.TabStop = true;
            this.radioButton_ProductReceive_IsCertificatePresent_True.Text = "В наличии";
            this.radioButton_ProductReceive_IsCertificatePresent_True.UseVisualStyleBackColor = true;
            // 
            // radioButton_ProductReceive_IsCertificatePresent_False
            // 
            this.radioButton_ProductReceive_IsCertificatePresent_False.AutoSize = true;
            this.radioButton_ProductReceive_IsCertificatePresent_False.Location = new System.Drawing.Point(6, 62);
            this.radioButton_ProductReceive_IsCertificatePresent_False.Name = "radioButton_ProductReceive_IsCertificatePresent_False";
            this.radioButton_ProductReceive_IsCertificatePresent_False.Size = new System.Drawing.Size(124, 27);
            this.radioButton_ProductReceive_IsCertificatePresent_False.TabIndex = 17;
            this.radioButton_ProductReceive_IsCertificatePresent_False.TabStop = true;
            this.radioButton_ProductReceive_IsCertificatePresent_False.Text = "Отсутствует";
            this.radioButton_ProductReceive_IsCertificatePresent_False.UseVisualStyleBackColor = true;
            // 
            // groupBox_ProductReceive_IsCertificatePresent
            // 
            this.groupBox_ProductReceive_IsCertificatePresent.Controls.Add(this.radioButton_ProductReceive_IsCertificatePresent_True);
            this.groupBox_ProductReceive_IsCertificatePresent.Controls.Add(this.radioButton_ProductReceive_IsCertificatePresent_False);
            this.groupBox_ProductReceive_IsCertificatePresent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_ProductReceive_IsCertificatePresent.Location = new System.Drawing.Point(306, 189);
            this.groupBox_ProductReceive_IsCertificatePresent.Name = "groupBox_ProductReceive_IsCertificatePresent";
            this.groupBox_ProductReceive_IsCertificatePresent.Size = new System.Drawing.Size(230, 96);
            this.groupBox_ProductReceive_IsCertificatePresent.TabIndex = 18;
            this.groupBox_ProductReceive_IsCertificatePresent.TabStop = false;
            this.groupBox_ProductReceive_IsCertificatePresent.Text = "Сертификат";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(184, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Получить товар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_ProductReceiveWindow_Suppliers
            // 
            this.dataGridView_ProductReceiveWindow_Suppliers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_ProductReceiveWindow_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProductReceiveWindow_Suppliers.Location = new System.Drawing.Point(608, 12);
            this.dataGridView_ProductReceiveWindow_Suppliers.Name = "dataGridView_ProductReceiveWindow_Suppliers";
            this.dataGridView_ProductReceiveWindow_Suppliers.RowHeadersWidth = 51;
            this.dataGridView_ProductReceiveWindow_Suppliers.RowTemplate.Height = 29;
            this.dataGridView_ProductReceiveWindow_Suppliers.Size = new System.Drawing.Size(300, 349);
            this.dataGridView_ProductReceiveWindow_Suppliers.TabIndex = 20;
            // 
            // ProductReceiveWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 373);
            this.Controls.Add(this.dataGridView_ProductReceiveWindow_Suppliers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_ProductReceive_IsCertificatePresent);
            this.Controls.Add(this.textBox_ProductReceive_VendorNumber_Input);
            this.Controls.Add(this.label_ProductReceive_VendorNumber);
            this.Controls.Add(this.textBox_ProductReceive_PriceProd_Input);
            this.Controls.Add(this.label_ProductReceive_PriceProd);
            this.Controls.Add(this.textBox_ProductReceive_NumbOfCopies_Input);
            this.Controls.Add(this.label_ProductReceive_NumbOfCopies);
            this.Controls.Add(this.textBox_ProductReceive_DateProd_Input);
            this.Controls.Add(this.label_ProductReceive_DateProd);
            this.Controls.Add(this.textBox_ProductReceive_CityProd_Input);
            this.Controls.Add(this.label_ProductReceive_CityProd);
            this.Controls.Add(this.textBox_ProductReceive_Name_Input);
            this.Controls.Add(this.label_ProductReceive_Name);
            this.Controls.Add(this.label_ProductReceive_ProductSKU);
            this.Name = "ProductReceiveWindow";
            this.Text = "ProductReceiveWindow";
            this.Load += new System.EventHandler(this.ProductReceiveWindow_Load);
            this.groupBox_ProductReceive_IsCertificatePresent.ResumeLayout(false);
            this.groupBox_ProductReceive_IsCertificatePresent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductReceiveWindow_Suppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_ProductReceive_ProductSKU;
        private TextBox textBox_ProductReceive_Name_Input;
        private Label label_ProductReceive_Name;
        private TextBox textBox_ProductReceive_CityProd_Input;
        private Label label_ProductReceive_CityProd;
        private TextBox textBox_ProductReceive_DateProd_Input;
        private Label label_ProductReceive_DateProd;
        private TextBox textBox_ProductReceive_NumbOfCopies_Input;
        private Label label_ProductReceive_NumbOfCopies;
        private TextBox textBox_ProductReceive_PriceProd_Input;
        private Label label_ProductReceive_PriceProd;
        private TextBox textBox_ProductReceive_VendorNumber_Input;
        private Label label_ProductReceive_VendorNumber;
        private RadioButton radioButton_ProductReceive_IsCertificatePresent_True;
        private RadioButton radioButton_ProductReceive_IsCertificatePresent_False;
        private GroupBox groupBox_ProductReceive_IsCertificatePresent;
        private Button button1;
        private DataGridView dataGridView_ProductReceiveWindow_Suppliers;
    }
}