namespace WarehouseSystem.WinFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button_PER_test = new System.Windows.Forms.Button();
            this.button_inputSKU_test = new System.Windows.Forms.Button();
            this.textBox_inputSKU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_PER_test
            // 
            this.button_PER_test.Location = new System.Drawing.Point(582, 172);
            this.button_PER_test.Name = "button_PER_test";
            this.button_PER_test.Size = new System.Drawing.Size(94, 29);
            this.button_PER_test.TabIndex = 1;
            this.button_PER_test.Text = "PER_TEST";
            this.button_PER_test.UseVisualStyleBackColor = true;
            this.button_PER_test.Click += new System.EventHandler(this.button_PER_test_Click);
            // 
            // button_inputSKU_test
            // 
            this.button_inputSKU_test.Location = new System.Drawing.Point(134, 172);
            this.button_inputSKU_test.Name = "button_inputSKU_test";
            this.button_inputSKU_test.Size = new System.Drawing.Size(132, 29);
            this.button_inputSKU_test.TabIndex = 2;
            this.button_inputSKU_test.Text = "GetBySKU_TEST";
            this.button_inputSKU_test.UseVisualStyleBackColor = true;
            this.button_inputSKU_test.Click += new System.EventHandler(this.button_inputSKU_test_Click);
            // 
            // textBox_inputSKU
            // 
            this.textBox_inputSKU.Location = new System.Drawing.Point(134, 139);
            this.textBox_inputSKU.Name = "textBox_inputSKU";
            this.textBox_inputSKU.Size = new System.Drawing.Size(125, 27);
            this.textBox_inputSKU.TabIndex = 3;
            this.textBox_inputSKU.Text = "Введите текст";
            this.textBox_inputSKU.TextChanged += new System.EventHandler(this.textBox_inputSKU_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_inputSKU);
            this.Controls.Add(this.button_inputSKU_test);
            this.Controls.Add(this.button_PER_test);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button_PER_test;
        private Button button_inputSKU_test;
        private TextBox textBox_inputSKU;
    }
}