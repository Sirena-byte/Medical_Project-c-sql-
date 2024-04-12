namespace medicalProject2
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.medicalInstField = new System.Windows.Forms.ComboBox();
            this.searchField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.PictureBox();
            this.restartButtonn = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.idName = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.TextBox();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.exitButtom = new System.Windows.Forms.Button();
            this.employysButton = new System.Windows.Forms.Button();
            this.doctorsProfileField = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.positionJobField = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.NewsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.profileField = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.placeOfWorkField = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButtonn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.medicalInstField);
            this.panel2.Controls.Add(this.searchField);
            this.panel2.Controls.Add(this.restartButtonn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 41);
            this.panel2.TabIndex = 91;
            // 
            // medicalInstField
            // 
            this.medicalInstField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicalInstField.FormattingEnabled = true;
            this.medicalInstField.Location = new System.Drawing.Point(198, 10);
            this.medicalInstField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medicalInstField.MaxDropDownItems = 80;
            this.medicalInstField.Name = "medicalInstField";
            this.medicalInstField.Size = new System.Drawing.Size(606, 26);
            this.medicalInstField.TabIndex = 100;
            this.medicalInstField.SelectedIndexChanged += new System.EventHandler(this.medicalInstField_SelectedIndexChanged);
            // 
            // searchField
            // 
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchField.Location = new System.Drawing.Point(911, 8);
            this.searchField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(264, 27);
            this.searchField.TabIndex = 3;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(43, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Сотрудники";
            // 
            // searchButton
            // 
            this.searchButton.Image = global::medicalProject2.Properties.Resources.loupe;
            this.searchButton.Location = new System.Drawing.Point(876, 6);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(29, 30);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::medicalProject2.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Image = global::medicalProject2.Properties.Resources.clear1;
            this.clearButton.Location = new System.Drawing.Point(841, 6);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(29, 30);
            this.clearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clearButton.TabIndex = 0;
            this.clearButton.TabStop = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // restartButtonn
            // 
            this.restartButtonn.Image = global::medicalProject2.Properties.Resources.restart;
            this.restartButtonn.Location = new System.Drawing.Point(810, 11);
            this.restartButtonn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restartButtonn.Name = "restartButtonn";
            this.restartButtonn.Size = new System.Drawing.Size(25, 25);
            this.restartButtonn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restartButtonn.TabIndex = 1;
            this.restartButtonn.TabStop = false;
            this.restartButtonn.Click += new System.EventHandler(this.restartButtonn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::medicalProject2.Properties.Resources.record;
            this.pictureBox4.Location = new System.Drawing.Point(1211, 100);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 70;
            this.pictureBox4.TabStop = false;
            // 
            // idName
            // 
            this.idName.AutoSize = true;
            this.idName.Location = new System.Drawing.Point(-52, 139);
            this.idName.Name = "idName";
            this.idName.Size = new System.Drawing.Size(23, 16);
            this.idName.TabIndex = 90;
            this.idName.Text = "ID:";
            // 
            // idField
            // 
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idField.Location = new System.Drawing.Point(1397, 319);
            this.idField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(465, 24);
            this.idField.TabIndex = 89;
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.Pink;
            this.panelmenu.Controls.Add(this.exitButtom);
            this.panelmenu.Controls.Add(this.employysButton);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(1924, 41);
            this.panelmenu.TabIndex = 88;
            // 
            // exitButtom
            // 
            this.exitButtom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.exitButtom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButtom.Location = new System.Drawing.Point(1837, 7);
            this.exitButtom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(75, 30);
            this.exitButtom.TabIndex = 11;
            this.exitButtom.Text = "Выйти";
            this.exitButtom.UseVisualStyleBackColor = false;
            // 
            // employysButton
            // 
            this.employysButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.employysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employysButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employysButton.Location = new System.Drawing.Point(12, 7);
            this.employysButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employysButton.Name = "employysButton";
            this.employysButton.Size = new System.Drawing.Size(336, 30);
            this.employysButton.TabIndex = 9;
            this.employysButton.Text = "Мед. организации";
            this.employysButton.UseVisualStyleBackColor = false;
            this.employysButton.Click += new System.EventHandler(this.employysButton_Click);
            // 
            // doctorsProfileField
            // 
            this.doctorsProfileField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorsProfileField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorsProfileField.FormattingEnabled = true;
            this.doctorsProfileField.Location = new System.Drawing.Point(0, 0);
            this.doctorsProfileField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorsProfileField.MaxDropDownItems = 80;
            this.doctorsProfileField.Name = "doctorsProfileField";
            this.doctorsProfileField.Size = new System.Drawing.Size(1924, 26);
            this.doctorsProfileField.TabIndex = 86;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(1731, 399);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(177, 30);
            this.saveButton.TabIndex = 78;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1246, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Изменение записи:";
            // 
            // changeButton
            // 
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(1182, 399);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(177, 30);
            this.changeButton.TabIndex = 75;
            this.changeButton.Text = "Изменить запись";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // positionJobField
            // 
            this.positionJobField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionJobField.FormattingEnabled = true;
            this.positionJobField.Location = new System.Drawing.Point(1397, 259);
            this.positionJobField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.positionJobField.MaxDropDownItems = 80;
            this.positionJobField.Name = "positionJobField";
            this.positionJobField.Size = new System.Drawing.Size(465, 26);
            this.positionJobField.TabIndex = 81;
            this.positionJobField.SelectedIndexChanged += new System.EventHandler(this.positionJobField_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(1365, 399);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(177, 30);
            this.deleteButton.TabIndex = 73;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // NewsButton
            // 
            this.NewsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NewsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewsButton.Location = new System.Drawing.Point(1548, 399);
            this.NewsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewsButton.Name = "NewsButton";
            this.NewsButton.Size = new System.Drawing.Size(177, 30);
            this.NewsButton.TabIndex = 71;
            this.NewsButton.Text = "Новая запись";
            this.NewsButton.UseVisualStyleBackColor = true;
            this.NewsButton.Click += new System.EventHandler(this.NewsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 860);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // firstNameField
            // 
            this.firstNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameField.Location = new System.Drawing.Point(1397, 175);
            this.firstNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(465, 24);
            this.firstNameField.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1272, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 79;
            this.label4.Text = "Квалификация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1295, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 76;
            this.label2.Text = "Должность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1311, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 77;
            this.label3.Text = "Фамилия:";
            // 
            // surnameField
            // 
            this.surnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameField.Location = new System.Drawing.Point(1397, 231);
            this.surnameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(465, 24);
            this.surnameField.TabIndex = 92;
            // 
            // lastNameField
            // 
            this.lastNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameField.Location = new System.Drawing.Point(1397, 203);
            this.lastNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(465, 24);
            this.lastNameField.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1309, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 94;
            this.label8.Text = "Отчество:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1346, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 95;
            this.label9.Text = "Имя:";
            // 
            // profileField
            // 
            this.profileField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileField.FormattingEnabled = true;
            this.profileField.Location = new System.Drawing.Point(1397, 289);
            this.profileField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileField.MaxDropDownItems = 80;
            this.profileField.Name = "profileField";
            this.profileField.Size = new System.Drawing.Size(465, 26);
            this.profileField.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1275, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 98;
            this.label5.Text = "Место работы:";
            // 
            // placeOfWorkField
            // 
            this.placeOfWorkField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeOfWorkField.FormattingEnabled = true;
            this.placeOfWorkField.Location = new System.Drawing.Point(1397, 145);
            this.placeOfWorkField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeOfWorkField.MaxDropDownItems = 80;
            this.placeOfWorkField.Name = "placeOfWorkField";
            this.placeOfWorkField.Size = new System.Drawing.Size(465, 26);
            this.placeOfWorkField.TabIndex = 99;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.placeOfWorkField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.profileField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idName);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.doctorsProfileField);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.positionJobField);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.NewsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButtonn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox clearButton;
        private System.Windows.Forms.PictureBox restartButtonn;
        private System.Windows.Forms.Label idName;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button employysButton;
        private System.Windows.Forms.ComboBox doctorsProfileField;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.ComboBox positionJobField;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button NewsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox profileField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox placeOfWorkField;
        private System.Windows.Forms.ComboBox medicalInstField;
        private System.Windows.Forms.Button exitButtom;
    }
}