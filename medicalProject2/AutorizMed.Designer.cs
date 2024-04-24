namespace medicalProject2
{
    partial class AutorizMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizMed));
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.autorizButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.autorizLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openPass = new System.Windows.Forms.PictureBox();
            this.closePass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePass)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(158, 154);
            this.passwordField.Margin = new System.Windows.Forms.Padding(2);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(192, 26);
            this.passwordField.TabIndex = 27;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(158, 114);
            this.loginField.Margin = new System.Windows.Forms.Padding(2);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(192, 26);
            this.loginField.TabIndex = 26;
            // 
            // autorizButton
            // 
            this.autorizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizButton.Location = new System.Drawing.Point(105, 219);
            this.autorizButton.Margin = new System.Windows.Forms.Padding(2);
            this.autorizButton.Name = "autorizButton";
            this.autorizButton.Size = new System.Drawing.Size(205, 35);
            this.autorizButton.TabIndex = 25;
            this.autorizButton.Text = "Войти в аккаунт";
            this.autorizButton.UseVisualStyleBackColor = true;
            this.autorizButton.Click += new System.EventHandler(this.autorizButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(26, 114);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(128, 20);
            this.loginLabel.TabIndex = 24;
            this.loginLabel.Text = "Введите логин:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(11, 157);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(139, 20);
            this.passwordLabel.TabIndex = 23;
            this.passwordLabel.Text = "Введите пароль:";
            // 
            // autorizLabel
            // 
            this.autorizLabel.AutoSize = true;
            this.autorizLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizLabel.Location = new System.Drawing.Point(100, 56);
            this.autorizLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autorizLabel.Name = "autorizLabel";
            this.autorizLabel.Size = new System.Drawing.Size(166, 29);
            this.autorizLabel.TabIndex = 22;
            this.autorizLabel.Text = "Авторизация";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::medicalProject2.Properties.Resources.clear;
            this.pictureBox3.Location = new System.Drawing.Point(270, 50);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // openPass
            // 
            this.openPass.Image = global::medicalProject2.Properties.Resources.showPass1;
            this.openPass.Location = new System.Drawing.Point(354, 154);
            this.openPass.Margin = new System.Windows.Forms.Padding(2);
            this.openPass.Name = "openPass";
            this.openPass.Size = new System.Drawing.Size(26, 26);
            this.openPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openPass.TabIndex = 29;
            this.openPass.TabStop = false;
            this.openPass.Click += new System.EventHandler(this.openPass_Click);
            // 
            // closePass
            // 
            this.closePass.Image = global::medicalProject2.Properties.Resources.hidePass;
            this.closePass.Location = new System.Drawing.Point(354, 154);
            this.closePass.Margin = new System.Windows.Forms.Padding(2);
            this.closePass.Name = "closePass";
            this.closePass.Size = new System.Drawing.Size(26, 26);
            this.closePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePass.TabIndex = 28;
            this.closePass.TabStop = false;
            this.closePass.Click += new System.EventHandler(this.closePass_Click);
            // 
            // AutorizMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(400, 388);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.openPass);
            this.Controls.Add(this.closePass);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.autorizButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.autorizLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AutorizMed";
            this.Load += new System.EventHandler(this.AutorizMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox openPass;
        private System.Windows.Forms.PictureBox closePass;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button autorizButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label autorizLabel;
    }
}