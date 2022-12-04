namespace WarehouseSystem.WinFormApp.Forms
{
    partial class RegistrationWindow
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
            this.label_Registration = new System.Windows.Forms.Label();
            this.label_InputLoginReg = new System.Windows.Forms.Label();
            this.textBox_InputLoginReg = new System.Windows.Forms.TextBox();
            this.label_InputPasswordReg = new System.Windows.Forms.Label();
            this.textBox_InputPasswordReg = new System.Windows.Forms.TextBox();
            this.buttonRegistration2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Registration
            // 
            this.label_Registration.AutoSize = true;
            this.label_Registration.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Registration.Location = new System.Drawing.Point(127, 28);
            this.label_Registration.Name = "label_Registration";
            this.label_Registration.Size = new System.Drawing.Size(181, 38);
            this.label_Registration.TabIndex = 5;
            this.label_Registration.Text = "Регистрация";
            // 
            // label_InputLoginReg
            // 
            this.label_InputLoginReg.AutoSize = true;
            this.label_InputLoginReg.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_InputLoginReg.Location = new System.Drawing.Point(66, 114);
            this.label_InputLoginReg.Name = "label_InputLoginReg";
            this.label_InputLoginReg.Size = new System.Drawing.Size(63, 23);
            this.label_InputLoginReg.TabIndex = 6;
            this.label_InputLoginReg.Text = "Логин:";
            // 
            // textBox_InputLoginReg
            // 
            this.textBox_InputLoginReg.Location = new System.Drawing.Point(135, 114);
            this.textBox_InputLoginReg.Name = "textBox_InputLoginReg";
            this.textBox_InputLoginReg.Size = new System.Drawing.Size(200, 27);
            this.textBox_InputLoginReg.TabIndex = 7;
            // 
            // label_InputPasswordReg
            // 
            this.label_InputPasswordReg.AutoSize = true;
            this.label_InputPasswordReg.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_InputPasswordReg.Location = new System.Drawing.Point(54, 169);
            this.label_InputPasswordReg.Name = "label_InputPasswordReg";
            this.label_InputPasswordReg.Size = new System.Drawing.Size(75, 23);
            this.label_InputPasswordReg.TabIndex = 8;
            this.label_InputPasswordReg.Text = "Пароль:";
            // 
            // textBox_InputPasswordReg
            // 
            this.textBox_InputPasswordReg.Location = new System.Drawing.Point(135, 169);
            this.textBox_InputPasswordReg.Name = "textBox_InputPasswordReg";
            this.textBox_InputPasswordReg.Size = new System.Drawing.Size(200, 27);
            this.textBox_InputPasswordReg.TabIndex = 9;
            // 
            // buttonRegistration2
            // 
            this.buttonRegistration2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistration2.Location = new System.Drawing.Point(160, 240);
            this.buttonRegistration2.Name = "buttonRegistration2";
            this.buttonRegistration2.Size = new System.Drawing.Size(125, 29);
            this.buttonRegistration2.TabIndex = 10;
            this.buttonRegistration2.Text = "Регистрация";
            this.buttonRegistration2.UseVisualStyleBackColor = true;
            this.buttonRegistration2.Click += new System.EventHandler(this.buttonRegistration2_Click);
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 342);
            this.Controls.Add(this.buttonRegistration2);
            this.Controls.Add(this.textBox_InputPasswordReg);
            this.Controls.Add(this.label_InputPasswordReg);
            this.Controls.Add(this.textBox_InputLoginReg);
            this.Controls.Add(this.label_InputLoginReg);
            this.Controls.Add(this.label_Registration);
            this.Name = "RegistrationWindow";
            this.Text = "RegistrationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Registration;
        private Label label_InputLoginReg;
        private TextBox textBox_InputLoginReg;
        private Label label_InputPasswordReg;
        private TextBox textBox_InputPasswordReg;
        private Button buttonRegistration2;
    }
}