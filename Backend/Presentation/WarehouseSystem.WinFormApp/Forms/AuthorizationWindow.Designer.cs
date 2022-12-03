namespace WarehouseSystem.WinFormApp.Forms
{
    partial class AuthorizationWindow
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
            this.textBox_InputLogin = new System.Windows.Forms.TextBox();
            this.textBox_InputPassword = new System.Windows.Forms.TextBox();
            this.label_InputLogin = new System.Windows.Forms.Label();
            this.label_InputPassword = new System.Windows.Forms.Label();
            this.label_Authorization = new System.Windows.Forms.Label();
            this.button_EnterAuthorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_InputLogin
            // 
            this.textBox_InputLogin.Location = new System.Drawing.Point(140, 100);
            this.textBox_InputLogin.Name = "textBox_InputLogin";
            this.textBox_InputLogin.Size = new System.Drawing.Size(200, 27);
            this.textBox_InputLogin.TabIndex = 0;
            // 
            // textBox_InputPassword
            // 
            this.textBox_InputPassword.Location = new System.Drawing.Point(140, 150);
            this.textBox_InputPassword.Name = "textBox_InputPassword";
            this.textBox_InputPassword.Size = new System.Drawing.Size(200, 27);
            this.textBox_InputPassword.TabIndex = 1;
            // 
            // label_InputLogin
            // 
            this.label_InputLogin.AutoSize = true;
            this.label_InputLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_InputLogin.Location = new System.Drawing.Point(78, 103);
            this.label_InputLogin.Name = "label_InputLogin";
            this.label_InputLogin.Size = new System.Drawing.Size(63, 23);
            this.label_InputLogin.TabIndex = 2;
            this.label_InputLogin.Text = "Логин:";
            // 
            // label_InputPassword
            // 
            this.label_InputPassword.AutoSize = true;
            this.label_InputPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_InputPassword.Location = new System.Drawing.Point(66, 153);
            this.label_InputPassword.Name = "label_InputPassword";
            this.label_InputPassword.Size = new System.Drawing.Size(75, 23);
            this.label_InputPassword.TabIndex = 3;
            this.label_InputPassword.Text = "Пароль:";
            // 
            // label_Authorization
            // 
            this.label_Authorization.AutoSize = true;
            this.label_Authorization.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Authorization.Location = new System.Drawing.Point(149, 33);
            this.label_Authorization.Name = "label_Authorization";
            this.label_Authorization.Size = new System.Drawing.Size(191, 38);
            this.label_Authorization.TabIndex = 4;
            this.label_Authorization.Text = "Авторизация";
            // 
            // button_EnterAuthorization
            // 
            this.button_EnterAuthorization.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_EnterAuthorization.Location = new System.Drawing.Point(192, 222);
            this.button_EnterAuthorization.Name = "button_EnterAuthorization";
            this.button_EnterAuthorization.Size = new System.Drawing.Size(94, 29);
            this.button_EnterAuthorization.TabIndex = 5;
            this.button_EnterAuthorization.Text = "Войти";
            this.button_EnterAuthorization.UseVisualStyleBackColor = true;
            this.button_EnterAuthorization.Click += new System.EventHandler(this.button_EnterAuthorization_Click);
            // 
            // AuthorizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 342);
            this.Controls.Add(this.button_EnterAuthorization);
            this.Controls.Add(this.label_Authorization);
            this.Controls.Add(this.label_InputPassword);
            this.Controls.Add(this.label_InputLogin);
            this.Controls.Add(this.textBox_InputPassword);
            this.Controls.Add(this.textBox_InputLogin);
            this.MaximizeBox = false;
            this.Name = "AuthorizationWindow";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_InputLogin;
        private TextBox textBox_InputPassword;
        private Label label_InputLogin;
        private Label label_InputPassword;
        private Label label_Authorization;
        private Button button_EnterAuthorization;
    }
}