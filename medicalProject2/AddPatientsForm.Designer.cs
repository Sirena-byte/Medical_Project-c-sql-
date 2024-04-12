namespace medicalProject2
{
    partial class AddPatientsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientsForm));
            this.medButton = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.placeOfWorkField = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.profileField = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.positionJobField = new System.Windows.Forms.ComboBox();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButtom = new System.Windows.Forms.Button();
            this.empButton = new System.Windows.Forms.Button();
            this.docButton = new System.Windows.Forms.Button();
            this.medicalLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aLastNameField = new System.Windows.Forms.TextBox();
            this.aSurnameField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.aStreetField = new System.Windows.Forms.TextBox();
            this.aFirstNameField = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.aPhoneField = new System.Windows.Forms.MaskedTextBox();
            this.aDateBField = new System.Windows.Forms.MaskedTextBox();
            this.aPasportField = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.aHomeField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // medButton
            // 
            this.medButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.medButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medButton.Location = new System.Drawing.Point(12, 11);
            this.medButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medButton.Name = "medButton";
            this.medButton.Size = new System.Drawing.Size(336, 30);
            this.medButton.TabIndex = 10;
            this.medButton.Text = "Мед. организации";
            this.medButton.UseVisualStyleBackColor = false;
            this.medButton.Click += new System.EventHandler(this.medButton_Click);
            // 
            // searchField
            // 
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchField.Location = new System.Drawing.Point(915, 53);
            this.searchField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(264, 27);
            this.searchField.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(47, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 106;
            this.label7.Text = "Пациенты";
            // 
            // searchButton
            // 
            this.searchButton.Image = global::medicalProject2.Properties.Resources.loupe;
            this.searchButton.Location = new System.Drawing.Point(880, 51);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(29, 30);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 103;
            this.searchButton.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::medicalProject2.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPatients.Location = new System.Drawing.Point(13, 99);
            this.dataGridViewPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.RowHeadersWidth = 51;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.Size = new System.Drawing.Size(1166, 860);
            this.dataGridViewPatients.TabIndex = 108;
            this.dataGridViewPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellContentClick);
            // 
            // placeOfWorkField
            // 
            this.placeOfWorkField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeOfWorkField.FormattingEnabled = true;
            this.placeOfWorkField.Location = new System.Drawing.Point(1405, 144);
            this.placeOfWorkField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeOfWorkField.MaxDropDownItems = 80;
            this.placeOfWorkField.Name = "placeOfWorkField";
            this.placeOfWorkField.Size = new System.Drawing.Size(465, 26);
            this.placeOfWorkField.TabIndex = 127;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1283, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 126;
            this.label5.Text = "Место работы:";
            // 
            // profileField
            // 
            this.profileField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileField.FormattingEnabled = true;
            this.profileField.Location = new System.Drawing.Point(1405, 288);
            this.profileField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileField.MaxDropDownItems = 80;
            this.profileField.Name = "profileField";
            this.profileField.Size = new System.Drawing.Size(465, 26);
            this.profileField.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1354, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 124;
            this.label9.Text = "Имя:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1317, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 123;
            this.label8.Text = "Отчество:";
            // 
            // lastNameField
            // 
            this.lastNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameField.Location = new System.Drawing.Point(1405, 202);
            this.lastNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(465, 24);
            this.lastNameField.TabIndex = 122;
            // 
            // surnameField
            // 
            this.surnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameField.Location = new System.Drawing.Point(1405, 230);
            this.surnameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(465, 24);
            this.surnameField.TabIndex = 121;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::medicalProject2.Properties.Resources.record;
            this.pictureBox4.Location = new System.Drawing.Point(1219, 99);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 109;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1254, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Изменение записи:";
            // 
            // idField
            // 
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idField.Location = new System.Drawing.Point(1405, 318);
            this.idField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(465, 24);
            this.idField.TabIndex = 120;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(1693, 753);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(177, 30);
            this.addButton.TabIndex = 116;
            this.addButton.Text = "Сохранить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(1693, 360);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(177, 30);
            this.changeButton.TabIndex = 113;
            this.changeButton.Text = "Изменить запись";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // positionJobField
            // 
            this.positionJobField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionJobField.FormattingEnabled = true;
            this.positionJobField.Location = new System.Drawing.Point(1405, 258);
            this.positionJobField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.positionJobField.MaxDropDownItems = 80;
            this.positionJobField.Name = "positionJobField";
            this.positionJobField.Size = new System.Drawing.Size(465, 26);
            this.positionJobField.TabIndex = 118;
            // 
            // firstNameField
            // 
            this.firstNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameField.Location = new System.Drawing.Point(1405, 174);
            this.firstNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(465, 24);
            this.firstNameField.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1280, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 117;
            this.label4.Text = "Квалификация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1303, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 114;
            this.label2.Text = "Должность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1319, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 115;
            this.label3.Text = "Фамилия:";
            // 
            // exitButtom
            // 
            this.exitButtom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.exitButtom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButtom.Location = new System.Drawing.Point(1823, 25);
            this.exitButtom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(75, 30);
            this.exitButtom.TabIndex = 128;
            this.exitButtom.Text = "Выйти";
            this.exitButtom.UseVisualStyleBackColor = false;
            // 
            // empButton
            // 
            this.empButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.empButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.empButton.Location = new System.Drawing.Point(365, 11);
            this.empButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empButton.Name = "empButton";
            this.empButton.Size = new System.Drawing.Size(336, 30);
            this.empButton.TabIndex = 129;
            this.empButton.Text = "Сотрудники";
            this.empButton.UseVisualStyleBackColor = false;
            this.empButton.Click += new System.EventHandler(this.empButton_Click);
            // 
            // docButton
            // 
            this.docButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.docButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.docButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.docButton.Location = new System.Drawing.Point(722, 11);
            this.docButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docButton.Name = "docButton";
            this.docButton.Size = new System.Drawing.Size(336, 30);
            this.docButton.TabIndex = 130;
            this.docButton.Text = "Форма врача";
            this.docButton.UseVisualStyleBackColor = false;
            this.docButton.Click += new System.EventHandler(this.docButton_Click);
            // 
            // medicalLabel
            // 
            this.medicalLabel.AutoSize = true;
            this.medicalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicalLabel.Location = new System.Drawing.Point(177, 58);
            this.medicalLabel.Name = "medicalLabel";
            this.medicalLabel.Size = new System.Drawing.Size(0, 20);
            this.medicalLabel.TabIndex = 131;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1354, 585);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 18);
            this.label10.TabIndex = 143;
            this.label10.Text = "Имя:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1317, 616);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 18);
            this.label11.TabIndex = 142;
            this.label11.Text = "Отчество:";
            // 
            // aLastNameField
            // 
            this.aLastNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aLastNameField.Location = new System.Drawing.Point(1405, 582);
            this.aLastNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aLastNameField.Name = "aLastNameField";
            this.aLastNameField.Size = new System.Drawing.Size(465, 24);
            this.aLastNameField.TabIndex = 141;
            // 
            // aSurnameField
            // 
            this.aSurnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aSurnameField.Location = new System.Drawing.Point(1405, 610);
            this.aSurnameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aSurnameField.Name = "aSurnameField";
            this.aSurnameField.Size = new System.Drawing.Size(465, 24);
            this.aSurnameField.TabIndex = 140;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::medicalProject2.Properties.Resources.record;
            this.pictureBox2.Location = new System.Drawing.Point(1219, 508);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 132;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1254, 518);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 20);
            this.label12.TabIndex = 133;
            this.label12.Text = "Добавление записи:";
            // 
            // aStreetField
            // 
            this.aStreetField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aStreetField.Location = new System.Drawing.Point(1405, 698);
            this.aStreetField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aStreetField.Name = "aStreetField";
            this.aStreetField.Size = new System.Drawing.Size(360, 24);
            this.aStreetField.TabIndex = 139;
            // 
            // aFirstNameField
            // 
            this.aFirstNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aFirstNameField.Location = new System.Drawing.Point(1405, 554);
            this.aFirstNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aFirstNameField.Name = "aFirstNameField";
            this.aFirstNameField.Size = new System.Drawing.Size(465, 24);
            this.aFirstNameField.TabIndex = 138;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1263, 671);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 18);
            this.label13.TabIndex = 136;
            this.label13.Text = "Номер телефона:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(1276, 642);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 18);
            this.label14.TabIndex = 134;
            this.label14.Text = "Дата рождения:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(1319, 557);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 18);
            this.label15.TabIndex = 135;
            this.label15.Text = "Фамилия:";
            // 
            // aPhoneField
            // 
            this.aPhoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aPhoneField.Location = new System.Drawing.Point(1405, 668);
            this.aPhoneField.Mask = "+375 00-000-00-00";
            this.aPhoneField.Name = "aPhoneField";
            this.aPhoneField.Size = new System.Drawing.Size(465, 24);
            this.aPhoneField.TabIndex = 149;
            // 
            // aDateBField
            // 
            this.aDateBField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aDateBField.Location = new System.Drawing.Point(1405, 639);
            this.aDateBField.Mask = "00/00/0000";
            this.aDateBField.Name = "aDateBField";
            this.aDateBField.Size = new System.Drawing.Size(465, 24);
            this.aDateBField.TabIndex = 150;
            this.aDateBField.ValidatingType = typeof(System.DateTime);
            // 
            // aPasportField
            // 
            this.aPasportField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aPasportField.Location = new System.Drawing.Point(1405, 727);
            this.aPasportField.Mask = "M\\C000000";
            this.aPasportField.Name = "aPasportField";
            this.aPasportField.Size = new System.Drawing.Size(253, 24);
            this.aPasportField.TabIndex = 151;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(1263, 730);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 18);
            this.label16.TabIndex = 152;
            this.label16.Text = "Номер паспорта:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(1269, 701);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 18);
            this.label17.TabIndex = 153;
            this.label17.Text = "Домашний адрес:";
            // 
            // aHomeField
            // 
            this.aHomeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aHomeField.Location = new System.Drawing.Point(1771, 697);
            this.aHomeField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aHomeField.Name = "aHomeField";
            this.aHomeField.Size = new System.Drawing.Size(99, 24);
            this.aHomeField.TabIndex = 154;
            // 
            // AddPatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.aHomeField);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.aPasportField);
            this.Controls.Add(this.aDateBField);
            this.Controls.Add(this.aPhoneField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.aLastNameField);
            this.Controls.Add(this.aSurnameField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.aStreetField);
            this.Controls.Add(this.aFirstNameField);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.medicalLabel);
            this.Controls.Add(this.docButton);
            this.Controls.Add(this.empButton);
            this.Controls.Add(this.exitButtom);
            this.Controls.Add(this.placeOfWorkField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.profileField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.positionJobField);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.medButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPatientsForm";
            this.Text = "AddPatientsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button medButton;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.ComboBox placeOfWorkField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox profileField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.ComboBox positionJobField;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButtom;
        private System.Windows.Forms.Button empButton;
        private System.Windows.Forms.Button docButton;
        private System.Windows.Forms.Label medicalLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox aLastNameField;
        private System.Windows.Forms.TextBox aSurnameField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox aStreetField;
        private System.Windows.Forms.TextBox aFirstNameField;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox aPhoneField;
        private System.Windows.Forms.MaskedTextBox aDateBField;
        private System.Windows.Forms.MaskedTextBox aPasportField;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox aHomeField;
    }
}