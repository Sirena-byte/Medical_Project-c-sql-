namespace medicalProject2
{
    partial class AdminPanelMedical
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
            this.components = new System.ComponentModel.Container();
            this.tab2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.NewsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supervisorField = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalprojectDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_project_DBDataSet = new medicalProject2.medical_project_DBDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.categoryField = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idMedicalField = new System.Windows.Forms.TextBox();
            this.addresNumberHField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.addressStreetField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchField = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.restartButtonn = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new medicalProject2.medical_project_DBDataSetTableAdapters.categoryTableAdapter();
            this.employeesTableAdapter = new medicalProject2.medical_project_DBDataSetTableAdapters.employeesTableAdapter();
            this.tab2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalprojectDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButtonn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.tabPage1);
            this.tab2.Controls.Add(this.tabPage2);
            this.tab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab2.Location = new System.Drawing.Point(0, 0);
            this.tab2.Name = "tab2";
            this.tab2.SelectedIndex = 0;
            this.tab2.Size = new System.Drawing.Size(1082, 633);
            this.tab2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1074, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Медицинские организации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(798, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Управление записями";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.saveButton);
            this.panel3.Controls.Add(this.changeButton);
            this.panel3.Controls.Add(this.deleteButton);
            this.panel3.Controls.Add(this.NewsButton);
            this.panel3.Location = new System.Drawing.Point(802, 408);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 153);
            this.panel3.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveButton.Location = new System.Drawing.Point(12, 106);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(177, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить запись";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeButton.Location = new System.Drawing.Point(12, 75);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(177, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Изменить запись";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteButton.Location = new System.Drawing.Point(12, 46);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(177, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // NewsButton
            // 
            this.NewsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NewsButton.Location = new System.Drawing.Point(12, 17);
            this.NewsButton.Name = "NewsButton";
            this.NewsButton.Size = new System.Drawing.Size(177, 23);
            this.NewsButton.TabIndex = 0;
            this.NewsButton.Text = "Новая запись";
            this.NewsButton.UseVisualStyleBackColor = true;
            this.NewsButton.Click += new System.EventHandler(this.NewsButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.supervisorField);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.categoryField);
            this.panel2.Controls.Add(this.idMedicalField);
            this.panel2.Controls.Add(this.addresNumberHField);
            this.panel2.Controls.Add(this.phoneField);
            this.panel2.Controls.Add(this.addressStreetField);
            this.panel2.Controls.Add(this.nameField);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(9, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 249);
            this.panel2.TabIndex = 2;
            // 
            // supervisorField
            // 
            this.supervisorField.DataSource = this.employeesBindingSource;
            this.supervisorField.DisplayMember = "first_name";
            this.supervisorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supervisorField.FormattingEnabled = true;
            this.supervisorField.Location = new System.Drawing.Point(166, 203);
            this.supervisorField.Name = "supervisorField";
            this.supervisorField.Size = new System.Drawing.Size(520, 26);
            this.supervisorField.TabIndex = 15;
            this.supervisorField.ValueMember = "id_employee";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.medicalprojectDBDataSetBindingSource;
            // 
            // medicalprojectDBDataSetBindingSource
            // 
            this.medicalprojectDBDataSetBindingSource.DataSource = this.medical_project_DBDataSet;
            this.medicalprojectDBDataSetBindingSource.Position = 0;
            // 
            // medical_project_DBDataSet
            // 
            this.medical_project_DBDataSet.DataSetName = "medical_project_DBDataSet";
            this.medical_project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID:";
            // 
            // categoryField
            // 
            this.categoryField.DataSource = this.categoryBindingSource1;
            this.categoryField.DisplayMember = "name_category";
            this.categoryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryField.FormattingEnabled = true;
            this.categoryField.Location = new System.Drawing.Point(166, 86);
            this.categoryField.Name = "categoryField";
            this.categoryField.Size = new System.Drawing.Size(520, 26);
            this.categoryField.TabIndex = 5;
            this.categoryField.ValueMember = "id_category";
            this.categoryField.SelectedIndexChanged += new System.EventHandler(this.categoryField_SelectedIndexChanged);
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "category";
            this.categoryBindingSource1.DataSource = this.medicalprojectDBDataSetBindingSource;
            // 
            // idMedicalField
            // 
            this.idMedicalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idMedicalField.Location = new System.Drawing.Point(166, 58);
            this.idMedicalField.Name = "idMedicalField";
            this.idMedicalField.Size = new System.Drawing.Size(520, 24);
            this.idMedicalField.TabIndex = 13;
            // 
            // addresNumberHField
            // 
            this.addresNumberHField.Location = new System.Drawing.Point(626, 144);
            this.addresNumberHField.Multiline = true;
            this.addresNumberHField.Name = "addresNumberHField";
            this.addresNumberHField.Size = new System.Drawing.Size(60, 24);
            this.addresNumberHField.TabIndex = 12;
            // 
            // phoneField
            // 
            this.phoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneField.Location = new System.Drawing.Point(166, 172);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(520, 24);
            this.phoneField.TabIndex = 10;
            // 
            // addressStreetField
            // 
            this.addressStreetField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressStreetField.Location = new System.Drawing.Point(166, 144);
            this.addressStreetField.Name = "addressStreetField";
            this.addressStreetField.Size = new System.Drawing.Size(455, 24);
            this.addressStreetField.TabIndex = 9;
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(166, 116);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(520, 24);
            this.nameField.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Руководитель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Запись:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::medicalProject2.Properties.Resources.record;
            this.pictureBox4.Location = new System.Drawing.Point(16, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 265);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchField);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.restartButtonn);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 57);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::medicalProject2.Properties.Resources.hospital1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // searchField
            // 
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchField.Location = new System.Drawing.Point(841, 10);
            this.searchField.Multiline = true;
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(210, 35);
            this.searchField.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Image = global::medicalProject2.Properties.Resources.loupe;
            this.searchButton.Location = new System.Drawing.Point(795, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 40);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            // 
            // restartButtonn
            // 
            this.restartButtonn.Image = global::medicalProject2.Properties.Resources.restart;
            this.restartButtonn.Location = new System.Drawing.Point(735, 5);
            this.restartButtonn.Name = "restartButtonn";
            this.restartButtonn.Size = new System.Drawing.Size(40, 40);
            this.restartButtonn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restartButtonn.TabIndex = 1;
            this.restartButtonn.TabStop = false;
            this.restartButtonn.Click += new System.EventHandler(this.restartButtonn_Click);
            // 
            // clearButton
            // 
            this.clearButton.Image = global::medicalProject2.Properties.Resources.clear1;
            this.clearButton.Location = new System.Drawing.Point(680, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(40, 40);
            this.clearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clearButton.TabIndex = 0;
            this.clearButton.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1074, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сотрудники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.medicalprojectDBDataSetBindingSource;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // AdminPanelMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 633);
            this.Controls.Add(this.tab2);
            this.Name = "AdminPanelMedical";
            this.Text = "AdminPanelMedical";
            this.Load += new System.EventHandler(this.AdminPanelMedical_Load);
            this.tab2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalprojectDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButtonn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button NewsButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.TextBox addressStreetField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox restartButtonn;
        private System.Windows.Forms.PictureBox clearButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox addresNumberHField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox categoryField;
        private System.Windows.Forms.TextBox idMedicalField;
        private System.Windows.Forms.BindingSource medicalprojectDBDataSetBindingSource;
        private medical_project_DBDataSet medical_project_DBDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private medical_project_DBDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.ComboBox supervisorField;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private medical_project_DBDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
    }
}