namespace medicalProject2
{
    partial class AddMedicalForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.streetField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.PictureBox();
            this.infoButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.categoryField = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_project_DBDataSet = new medicalProject2.medical_project_DBDataSet();
            this.supervisorField = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalprojectDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hauseField = new System.Windows.Forms.TextBox();
            this.categoryTableAdapter = new medicalProject2.medical_project_DBDataSetTableAdapters.categoryTableAdapter();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new medicalProject2.medical_project_DBDataSetTableAdapters.employeesTableAdapter();
            this.phoneField = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalprojectDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.Location = new System.Drawing.Point(243, 375);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(192, 38);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // streetField
            // 
            this.streetField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetField.Location = new System.Drawing.Point(243, 208);
            this.streetField.Name = "streetField";
            this.streetField.Size = new System.Drawing.Size(190, 24);
            this.streetField.TabIndex = 36;
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(243, 148);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(253, 24);
            this.nameField.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(156, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Телефон:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(173, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Адрес:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(148, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(143, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Категория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(258, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::medicalProject2.Properties.Resources.hospital;
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.infoButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 63);
            this.panel1.TabIndex = 25;
            // 
            // clearButton
            // 
            this.clearButton.Image = global::medicalProject2.Properties.Resources.clear;
            this.clearButton.Location = new System.Drawing.Point(504, 10);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(40, 40);
            this.clearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clearButton.TabIndex = 2;
            this.clearButton.TabStop = false;
            // 
            // infoButton
            // 
            this.infoButton.Image = global::medicalProject2.Properties.Resources.info;
            this.infoButton.Location = new System.Drawing.Point(430, 10);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(40, 40);
            this.infoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoButton.TabIndex = 1;
            this.infoButton.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление организации:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(125, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Руководитель:";
            // 
            // categoryField
            // 
            this.categoryField.DataSource = this.categoryBindingSource;
            this.categoryField.DisplayMember = "name_category";
            this.categoryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryField.FormattingEnabled = true;
            this.categoryField.Location = new System.Drawing.Point(243, 177);
            this.categoryField.Name = "categoryField";
            this.categoryField.Size = new System.Drawing.Size(253, 26);
            this.categoryField.TabIndex = 40;
            this.categoryField.ValueMember = "id_category";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.medical_project_DBDataSet;
            // 
            // medical_project_DBDataSet
            // 
            this.medical_project_DBDataSet.DataSetName = "medical_project_DBDataSet";
            this.medical_project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supervisorField
            // 
            this.supervisorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supervisorField.FormattingEnabled = true;
            this.supervisorField.Location = new System.Drawing.Point(243, 275);
            this.supervisorField.Name = "supervisorField";
            this.supervisorField.Size = new System.Drawing.Size(253, 26);
            this.supervisorField.TabIndex = 41;
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
            // hauseField
            // 
            this.hauseField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hauseField.Location = new System.Drawing.Point(442, 208);
            this.hauseField.Name = "hauseField";
            this.hauseField.Size = new System.Drawing.Size(54, 24);
            this.hauseField.TabIndex = 42;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "category";
            this.categoryBindingSource1.DataSource = this.medicalprojectDBDataSetBindingSource;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // phoneField
            // 
            this.phoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneField.Location = new System.Drawing.Point(243, 239);
            this.phoneField.Mask = "(375) 00-000-00-00";
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(253, 24);
            this.phoneField.TabIndex = 43;
            // 
            // AddMedicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.hauseField);
            this.Controls.Add(this.supervisorField);
            this.Controls.Add(this.categoryField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.streetField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Name = "AddMedicalForm";
            this.Text = "AddMedical";
            this.Load += new System.EventHandler(this.AddMedicalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalprojectDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox streetField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox clearButton;
        private System.Windows.Forms.PictureBox infoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox categoryField;
        private System.Windows.Forms.ComboBox supervisorField;
        private System.Windows.Forms.TextBox hauseField;
        private medical_project_DBDataSet medical_project_DBDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private medical_project_DBDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource medicalprojectDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private medical_project_DBDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.MaskedTextBox phoneField;
    }
}