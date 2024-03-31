namespace medicalProject2
{
    partial class RegisterForm
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
            this.registerLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.Location = new System.Drawing.Point(76, 66);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(182, 32);
            this.registerLabel.TabIndex = 0;
            this.registerLabel.Text = "Регистрация";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(37, 205);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(116, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Введите пароль:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(37, 139);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(107, 16);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Введите логин:";
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(100, 292);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(158, 32);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Создать аккаунт";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(186, 133);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(159, 27);
            this.loginField.TabIndex = 6;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(186, 199);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(159, 27);
            this.passwordField.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::medicalProject2.Properties.Resources.clear;
            this.pictureBox3.Location = new System.Drawing.Point(305, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 381);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.registerLabel);
            this.Name = "RegisterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

