namespace WarehouseSystem.WinFormApp.Forms
{
    partial class SupplierAddWindow
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
            this.textBox_SupplierAddWindow_Name_Input = new System.Windows.Forms.TextBox();
            this.textBox_SupplierAddWindow_Phone_Input = new System.Windows.Forms.TextBox();
            this.textBox_SupplierAddWindow_Address_Input = new System.Windows.Forms.TextBox();
            this.label_SupplierAddWindow_Name = new System.Windows.Forms.Label();
            this.label_SupplierAddWindow_Phone_Input = new System.Windows.Forms.Label();
            this.label_SupplierAddWindow_Address_Input = new System.Windows.Forms.Label();
            this.button_SupplierAddWindow_AddSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_SupplierAddWindow_Name_Input
            // 
            this.textBox_SupplierAddWindow_Name_Input.Location = new System.Drawing.Point(100, 66);
            this.textBox_SupplierAddWindow_Name_Input.Name = "textBox_SupplierAddWindow_Name_Input";
            this.textBox_SupplierAddWindow_Name_Input.Size = new System.Drawing.Size(177, 27);
            this.textBox_SupplierAddWindow_Name_Input.TabIndex = 0;
            // 
            // textBox_SupplierAddWindow_Phone_Input
            // 
            this.textBox_SupplierAddWindow_Phone_Input.Location = new System.Drawing.Point(100, 139);
            this.textBox_SupplierAddWindow_Phone_Input.Name = "textBox_SupplierAddWindow_Phone_Input";
            this.textBox_SupplierAddWindow_Phone_Input.Size = new System.Drawing.Size(177, 27);
            this.textBox_SupplierAddWindow_Phone_Input.TabIndex = 1;
            // 
            // textBox_SupplierAddWindow_Address_Input
            // 
            this.textBox_SupplierAddWindow_Address_Input.Location = new System.Drawing.Point(100, 204);
            this.textBox_SupplierAddWindow_Address_Input.Name = "textBox_SupplierAddWindow_Address_Input";
            this.textBox_SupplierAddWindow_Address_Input.Size = new System.Drawing.Size(177, 27);
            this.textBox_SupplierAddWindow_Address_Input.TabIndex = 2;
            // 
            // label_SupplierAddWindow_Name
            // 
            this.label_SupplierAddWindow_Name.AutoSize = true;
            this.label_SupplierAddWindow_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SupplierAddWindow_Name.Location = new System.Drawing.Point(116, 40);
            this.label_SupplierAddWindow_Name.Name = "label_SupplierAddWindow_Name";
            this.label_SupplierAddWindow_Name.Size = new System.Drawing.Size(146, 23);
            this.label_SupplierAddWindow_Name.TabIndex = 3;
            this.label_SupplierAddWindow_Name.Text = "Имя поставщика";
            // 
            // label_SupplierAddWindow_Phone_Input
            // 
            this.label_SupplierAddWindow_Phone_Input.AutoSize = true;
            this.label_SupplierAddWindow_Phone_Input.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SupplierAddWindow_Phone_Input.Location = new System.Drawing.Point(116, 113);
            this.label_SupplierAddWindow_Phone_Input.Name = "label_SupplierAddWindow_Phone_Input";
            this.label_SupplierAddWindow_Phone_Input.Size = new System.Drawing.Size(146, 23);
            this.label_SupplierAddWindow_Phone_Input.TabIndex = 4;
            this.label_SupplierAddWindow_Phone_Input.Text = "Номер телефона";
            // 
            // label_SupplierAddWindow_Address_Input
            // 
            this.label_SupplierAddWindow_Address_Input.AutoSize = true;
            this.label_SupplierAddWindow_Address_Input.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SupplierAddWindow_Address_Input.Location = new System.Drawing.Point(158, 178);
            this.label_SupplierAddWindow_Address_Input.Name = "label_SupplierAddWindow_Address_Input";
            this.label_SupplierAddWindow_Address_Input.Size = new System.Drawing.Size(59, 23);
            this.label_SupplierAddWindow_Address_Input.TabIndex = 5;
            this.label_SupplierAddWindow_Address_Input.Text = "Адрес";
            // 
            // button_SupplierAddWindow_AddSupplier
            // 
            this.button_SupplierAddWindow_AddSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_SupplierAddWindow_AddSupplier.Location = new System.Drawing.Point(94, 266);
            this.button_SupplierAddWindow_AddSupplier.Name = "button_SupplierAddWindow_AddSupplier";
            this.button_SupplierAddWindow_AddSupplier.Size = new System.Drawing.Size(187, 40);
            this.button_SupplierAddWindow_AddSupplier.TabIndex = 6;
            this.button_SupplierAddWindow_AddSupplier.Text = "Добавить";
            this.button_SupplierAddWindow_AddSupplier.UseVisualStyleBackColor = true;
            this.button_SupplierAddWindow_AddSupplier.Click += new System.EventHandler(this.button_SupplierAddWindow_AddSupplier_Click);
            // 
            // SupplierAddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 373);
            this.Controls.Add(this.button_SupplierAddWindow_AddSupplier);
            this.Controls.Add(this.label_SupplierAddWindow_Address_Input);
            this.Controls.Add(this.label_SupplierAddWindow_Phone_Input);
            this.Controls.Add(this.label_SupplierAddWindow_Name);
            this.Controls.Add(this.textBox_SupplierAddWindow_Address_Input);
            this.Controls.Add(this.textBox_SupplierAddWindow_Phone_Input);
            this.Controls.Add(this.textBox_SupplierAddWindow_Name_Input);
            this.MaximizeBox = false;
            this.Name = "SupplierAddWindow";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_SupplierAddWindow_Name_Input;
        private TextBox textBox_SupplierAddWindow_Phone_Input;
        private TextBox textBox_SupplierAddWindow_Address_Input;
        private Label label_SupplierAddWindow_Name;
        private Label label_SupplierAddWindow_Phone_Input;
        private Label label_SupplierAddWindow_Address_Input;
        private Button button_SupplierAddWindow_AddSupplier;
    }
}