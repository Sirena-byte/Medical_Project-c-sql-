namespace medicalProject2
{
    partial class MedicalForm
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
            this.idName = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.TextBox();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.employysButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.MaskedTextBox();
            this.supervisorField = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.categoryField = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.hauseField = new System.Windows.Forms.TextBox();
            this.NewsButton = new System.Windows.Forms.Button();
            this.streetField = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.PictureBox();
            this.restartButtonn = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButtonn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // idName
            // 
            this.idName.AutoSize = true;
            this.idName.Location = new System.Drawing.Point(5, 102);
            this.idName.Name = "idName";
            this.idName.Size = new System.Drawing.Size(23, 16);
            this.idName.TabIndex = 68;
            this.idName.Text = "ID:";
            // 
            // idField
            // 
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idField.Location = new System.Drawing.Point(5, 127);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(267, 24);
            this.idField.TabIndex = 67;
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.exitButton);
            this.panelmenu.Controls.Add(this.employysButton);
            this.panelmenu.Controls.Add(this.registerButton);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(1173, 41);
            this.panelmenu.TabIndex = 66;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(1132, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(29, 29);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // employysButton
            // 
            this.employysButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.employysButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employysButton.Location = new System.Drawing.Point(13, 6);
            this.employysButton.Name = "employysButton";
            this.employysButton.Size = new System.Drawing.Size(90, 29);
            this.employysButton.TabIndex = 9;
            this.employysButton.Text = "Работники";
            this.employysButton.UseVisualStyleBackColor = false;
            this.employysButton.Click += new System.EventHandler(this.employysButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerButton.Location = new System.Drawing.Point(1051, 3);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 29);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Войти";
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(327, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Медицинские организации города X";
            // 
            // searchField
            // 
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchField.Location = new System.Drawing.Point(973, 6);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(188, 27);
            this.searchField.TabIndex = 3;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // phoneField
            // 
            this.phoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneField.Location = new System.Drawing.Point(2, 321);
            this.phoneField.Mask = "+375 00 000-00-00";
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(270, 24);
            this.phoneField.TabIndex = 65;
            // 
            // supervisorField
            // 
            this.supervisorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supervisorField.FormattingEnabled = true;
            this.supervisorField.Location = new System.Drawing.Point(0, 369);
            this.supervisorField.Name = "supervisorField";
            this.supervisorField.Size = new System.Drawing.Size(272, 26);
            this.supervisorField.TabIndex = 64;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveButton.Location = new System.Drawing.Point(29, 594);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(177, 30);
            this.saveButton.TabIndex = 56;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Изменение записи:";
            // 
            // changeButton
            // 
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeButton.Location = new System.Drawing.Point(29, 486);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(177, 30);
            this.changeButton.TabIndex = 53;
            this.changeButton.Text = "Изменить запись";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // categoryField
            // 
            this.categoryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryField.FormattingEnabled = true;
            this.categoryField.Location = new System.Drawing.Point(2, 223);
            this.categoryField.Name = "categoryField";
            this.categoryField.Size = new System.Drawing.Size(270, 26);
            this.categoryField.TabIndex = 59;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteButton.Location = new System.Drawing.Point(29, 522);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(177, 30);
            this.deleteButton.TabIndex = 51;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // hauseField
            // 
            this.hauseField.Location = new System.Drawing.Point(212, 273);
            this.hauseField.Name = "hauseField";
            this.hauseField.Size = new System.Drawing.Size(60, 22);
            this.hauseField.TabIndex = 63;
            // 
            // NewsButton
            // 
            this.NewsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NewsButton.Location = new System.Drawing.Point(29, 558);
            this.NewsButton.Name = "NewsButton";
            this.NewsButton.Size = new System.Drawing.Size(177, 30);
            this.NewsButton.TabIndex = 49;
            this.NewsButton.Text = "Новая запись";
            this.NewsButton.UseVisualStyleBackColor = true;
            this.NewsButton.Click += new System.EventHandler(this.NewsButton_Click);
            // 
            // streetField
            // 
            this.streetField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetField.Location = new System.Drawing.Point(2, 273);
            this.streetField.Name = "streetField";
            this.streetField.Size = new System.Drawing.Size(204, 24);
            this.streetField.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(895, 536);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(2, 175);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(270, 24);
            this.nameField.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Руководитель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Категория:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Название:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchField);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Controls.Add(this.restartButtonn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 41);
            this.panel2.TabIndex = 69;
            // 
            // searchButton
            // 
            this.searchButton.Image = global::medicalProject2.Properties.Resources.loupe;
            this.searchButton.Location = new System.Drawing.Point(937, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 30);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::medicalProject2.Properties.Resources.hospital1;
            this.pictureBox1.Location = new System.Drawing.Point(278, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Image = global::medicalProject2.Properties.Resources.clear1;
            this.clearButton.Location = new System.Drawing.Point(885, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(30, 30);
            this.clearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clearButton.TabIndex = 0;
            this.clearButton.TabStop = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // restartButtonn
            // 
            this.restartButtonn.Image = global::medicalProject2.Properties.Resources.restart;
            this.restartButtonn.Location = new System.Drawing.Point(840, 8);
            this.restartButtonn.Name = "restartButtonn";
            this.restartButtonn.Size = new System.Drawing.Size(30, 30);
            this.restartButtonn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restartButtonn.TabIndex = 1;
            this.restartButtonn.TabStop = false;
            this.restartButtonn.Click += new System.EventHandler(this.restartButtonn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::medicalProject2.Properties.Resources.record;
            this.pictureBox4.Location = new System.Drawing.Point(8, 91);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // MedicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1173, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.idName);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.supervisorField);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.categoryField);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.hauseField);
            this.Controls.Add(this.NewsButton);
            this.Controls.Add(this.streetField);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "MedicalForm";
            this.Text = "MedicalForm";
            this.Load += new System.EventHandler(this.MedicalForm_Load);
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButtonn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idName;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox restartButtonn;
        private System.Windows.Forms.PictureBox clearButton;
        private System.Windows.Forms.MaskedTextBox phoneField;
        private System.Windows.Forms.ComboBox supervisorField;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.ComboBox categoryField;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox hauseField;
        private System.Windows.Forms.Button NewsButton;
        private System.Windows.Forms.TextBox streetField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button employysButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button exitButton;
    }
}