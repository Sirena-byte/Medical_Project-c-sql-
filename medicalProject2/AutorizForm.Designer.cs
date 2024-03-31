namespace medicalProject2
{
    partial class AutorizForm
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
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.autorizButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.autorizLabel = new System.Windows.Forms.Label();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
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
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(168, 186);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(159, 27);
            this.passwordField.TabIndex = 17;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(168, 120);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(159, 27);
            this.loginField.TabIndex = 16;
            // 
            // autorizButton
            // 
            this.autorizButton.Location = new System.Drawing.Point(94, 279);
            this.autorizButton.Name = "autorizButton";
            this.autorizButton.Size = new System.Drawing.Size(158, 32);
            this.autorizButton.TabIndex = 15;
            this.autorizButton.Text = "Ввойти в аккаунт";
            this.autorizButton.UseVisualStyleBackColor = true;
            this.autorizButton.Click += new System.EventHandler(this.autorizButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(31, 126);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(107, 16);
            this.loginLabel.TabIndex = 14;
            this.loginLabel.Text = "Введите логин:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(31, 192);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(116, 16);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Введите пароль:";
            // 
            // autorizLabel
            // 
            this.autorizLabel.AutoSize = true;
            this.autorizLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizLabel.Location = new System.Drawing.Point(70, 53);
            this.autorizLabel.Name = "autorizLabel";
            this.autorizLabel.Size = new System.Drawing.Size(186, 32);
            this.autorizLabel.TabIndex = 12;
            this.autorizLabel.Text = "Авторизация";
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelRegister.LinkColor = System.Drawing.Color.Black;
            this.linkLabelRegister.Location = new System.Drawing.Point(90, 407);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(170, 20);
            this.linkLabelRegister.TabIndex = 21;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Еще нет аккаунта?";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::medicalProject2.Properties.Resources.clear;
            this.pictureBox3.Location = new System.Drawing.Point(299, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // openPass
            // 
            this.openPass.Image = global::medicalProject2.Properties.Resources.showPass1;
            this.openPass.Location = new System.Drawing.Point(333, 186);
            this.openPass.Name = "openPass";
            this.openPass.Size = new System.Drawing.Size(35, 35);
            this.openPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openPass.TabIndex = 19;
            this.openPass.TabStop = false;
            this.openPass.Click += new System.EventHandler(this.openPass_Click);
            // 
            // closePass
            // 
            this.closePass.Image = global::medicalProject2.Properties.Resources.hidePass;
            this.closePass.Location = new System.Drawing.Point(333, 186);
            this.closePass.Name = "closePass";
            this.closePass.Size = new System.Drawing.Size(35, 35);
            this.closePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePass.TabIndex = 18;
            this.closePass.TabStop = false;
            this.closePass.Click += new System.EventHandler(this.closePass_Click);
            // 
            // AutorizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.openPass);
            this.Controls.Add(this.closePass);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.autorizButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.autorizLabel);
            this.Name = "AutorizForm";
            this.Text = "AutorizForm";
            this.Load += new System.EventHandler(this.AutorizForm_Load);
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
        private System.Windows.Forms.LinkLabel linkLabelRegister;
    }
}