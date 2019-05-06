namespace Chuck_Time_Bakery
{
    partial class Form_Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.button_login_guest = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.linkLabel_forgot_pas = new System.Windows.Forms.LinkLabel();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_login_guest
            // 
            this.button_login_guest.Location = new System.Drawing.Point(213, 142);
            this.button_login_guest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_login_guest.Name = "button_login_guest";
            this.button_login_guest.Size = new System.Drawing.Size(109, 24);
            this.button_login_guest.TabIndex = 14;
            this.button_login_guest.Text = "Войти как гость";
            this.button_login_guest.UseVisualStyleBackColor = true;
            this.button_login_guest.Click += new System.EventHandler(this.Button_login_guest_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(142, 142);
            this.button_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(56, 24);
            this.button_login.TabIndex = 13;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // linkLabel_forgot_pas
            // 
            this.linkLabel_forgot_pas.AutoSize = true;
            this.linkLabel_forgot_pas.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_forgot_pas.LinkColor = System.Drawing.Color.White;
            this.linkLabel_forgot_pas.Location = new System.Drawing.Point(178, 187);
            this.linkLabel_forgot_pas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_forgot_pas.Name = "linkLabel_forgot_pas";
            this.linkLabel_forgot_pas.Size = new System.Drawing.Size(91, 13);
            this.linkLabel_forgot_pas.TabIndex = 12;
            this.linkLabel_forgot_pas.TabStop = true;
            this.linkLabel_forgot_pas.Text = "Забыли пароль?";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(142, 103);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(180, 26);
            this.textBox_password.TabIndex = 11;
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(142, 50);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(180, 26);
            this.textBox_login.TabIndex = 10;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(55, 100);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(101, 31);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "Пароль: ";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(62, 47);
            this.label_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(95, 31);
            this.label_login.TabIndex = 8;
            this.label_login.Text = "Логин: ";
            // 
            // Form_Login
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chuck_Time_Bakery.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 234);
            this.Controls.Add(this.button_login_guest);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.linkLabel_forgot_pas);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Login";
            this.Text = "Вход в систему";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login_guest;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel linkLabel_forgot_pas;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
    }
}

