namespace medicalProject2
{
    partial class DoctorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridViewPriem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patientField = new System.Windows.Forms.TextBox();
            this.idPatientField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pressureField = new System.Windows.Forms.MaskedTextBox();
            this.temperaturaField = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.appointmentField = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descField = new System.Windows.Forms.RichTextBox();
            this.diagnosisField = new System.Windows.Forms.MaskedTextBox();
            this.doctorNameField = new System.Windows.Forms.ComboBox();
            this.medicalField = new System.Windows.Forms.ComboBox();
            this.exitButtom = new System.Windows.Forms.Button();
            this.dataGridViewCard = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.patientCardField = new System.Windows.Forms.Label();
            this.closeNoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лист приема";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(18, 10);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(173, 24);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(1703, 946);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 24);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridViewPriem
            // 
            this.dataGridViewPriem.AllowUserToAddRows = false;
            this.dataGridViewPriem.AllowUserToDeleteRows = false;
            this.dataGridViewPriem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPriem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPriem.Location = new System.Drawing.Point(9, 58);
            this.dataGridViewPriem.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPriem.Name = "dataGridViewPriem";
            this.dataGridViewPriem.ReadOnly = true;
            this.dataGridViewPriem.RowHeadersWidth = 51;
            this.dataGridViewPriem.RowTemplate.Height = 24;
            this.dataGridViewPriem.Size = new System.Drawing.Size(597, 545);
            this.dataGridViewPriem.TabIndex = 7;
            this.dataGridViewPriem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPriem_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patientField);
            this.groupBox1.Controls.Add(this.idPatientField);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pressureField);
            this.groupBox1.Controls.Add(this.temperaturaField);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.appointmentField);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.descField);
            this.groupBox1.Controls.Add(this.diagnosisField);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(620, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1255, 858);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лист приема";
            // 
            // patientField
            // 
            this.patientField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientField.Location = new System.Drawing.Point(486, 25);
            this.patientField.Margin = new System.Windows.Forms.Padding(2);
            this.patientField.Name = "patientField";
            this.patientField.Size = new System.Drawing.Size(351, 24);
            this.patientField.TabIndex = 18;
            // 
            // idPatientField
            // 
            this.idPatientField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idPatientField.Location = new System.Drawing.Point(277, 25);
            this.idPatientField.Margin = new System.Windows.Forms.Padding(2);
            this.idPatientField.Name = "idPatientField";
            this.idPatientField.Size = new System.Drawing.Size(66, 24);
            this.idPatientField.TabIndex = 17;
            this.idPatientField.TextChanged += new System.EventHandler(this.idPatientField_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(161, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Код пациента";
            // 
            // pressureField
            // 
            this.pressureField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressureField.Location = new System.Drawing.Point(1129, 27);
            this.pressureField.Margin = new System.Windows.Forms.Padding(2);
            this.pressureField.Mask = "000\\/00";
            this.pressureField.Name = "pressureField";
            this.pressureField.Size = new System.Drawing.Size(66, 24);
            this.pressureField.TabIndex = 15;
            // 
            // temperaturaField
            // 
            this.temperaturaField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperaturaField.Location = new System.Drawing.Point(977, 27);
            this.temperaturaField.Margin = new System.Windows.Forms.Padding(2);
            this.temperaturaField.Mask = "00.0";
            this.temperaturaField.Name = "temperaturaField";
            this.temperaturaField.Size = new System.Drawing.Size(34, 24);
            this.temperaturaField.TabIndex = 14;
            this.temperaturaField.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(104, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Описание:";
            // 
            // appointmentField
            // 
            this.appointmentField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointmentField.Location = new System.Drawing.Point(329, 812);
            this.appointmentField.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentField.Name = "appointmentField";
            this.appointmentField.Size = new System.Drawing.Size(866, 24);
            this.appointmentField.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(221, 812);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Назначения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(221, 773);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Диагноз:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1044, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Давление:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(860, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Температура:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(358, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "ФИО пациента";
            // 
            // descField
            // 
            this.descField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descField.Location = new System.Drawing.Point(224, 70);
            this.descField.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.descField.Name = "descField";
            this.descField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descField.Size = new System.Drawing.Size(971, 660);
            this.descField.TabIndex = 5;
            this.descField.Text = "";
            // 
            // diagnosisField
            // 
            this.diagnosisField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagnosisField.Location = new System.Drawing.Point(327, 770);
            this.diagnosisField.Margin = new System.Windows.Forms.Padding(2);
            this.diagnosisField.Name = "diagnosisField";
            this.diagnosisField.Size = new System.Drawing.Size(868, 24);
            this.diagnosisField.TabIndex = 4;
            // 
            // doctorNameField
            // 
            this.doctorNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorNameField.FormattingEnabled = true;
            this.doctorNameField.Location = new System.Drawing.Point(1313, 11);
            this.doctorNameField.Margin = new System.Windows.Forms.Padding(2);
            this.doctorNameField.Name = "doctorNameField";
            this.doctorNameField.Size = new System.Drawing.Size(421, 26);
            this.doctorNameField.TabIndex = 14;
            this.doctorNameField.SelectedIndexChanged += new System.EventHandler(this.doctorNameField_SelectedIndexChanged);
            // 
            // medicalField
            // 
            this.medicalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicalField.FormattingEnabled = true;
            this.medicalField.Location = new System.Drawing.Point(844, 13);
            this.medicalField.Margin = new System.Windows.Forms.Padding(2);
            this.medicalField.Name = "medicalField";
            this.medicalField.Size = new System.Drawing.Size(414, 26);
            this.medicalField.TabIndex = 15;
            this.medicalField.SelectedIndexChanged += new System.EventHandler(this.medicalField_SelectedIndexChanged);
            // 
            // exitButtom
            // 
            this.exitButtom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.exitButtom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButtom.Location = new System.Drawing.Point(1770, 13);
            this.exitButtom.Margin = new System.Windows.Forms.Padding(2);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(121, 26);
            this.exitButtom.TabIndex = 18;
            this.exitButtom.Text = "Выйти";
            this.exitButtom.UseVisualStyleBackColor = false;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // dataGridViewCard
            // 
            this.dataGridViewCard.AllowUserToAddRows = false;
            this.dataGridViewCard.AllowUserToDeleteRows = false;
            this.dataGridViewCard.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCard.Location = new System.Drawing.Point(4, 648);
            this.dataGridViewCard.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCard.Name = "dataGridViewCard";
            this.dataGridViewCard.ReadOnly = true;
            this.dataGridViewCard.RowHeadersWidth = 51;
            this.dataGridViewCard.RowTemplate.Height = 24;
            this.dataGridViewCard.Size = new System.Drawing.Size(602, 268);
            this.dataGridViewCard.TabIndex = 19;
            this.dataGridViewCard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCard_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(11, 622);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Карта пациента";
            // 
            // patientCardField
            // 
            this.patientCardField.AutoSize = true;
            this.patientCardField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientCardField.Location = new System.Drawing.Point(191, 624);
            this.patientCardField.Name = "patientCardField";
            this.patientCardField.Size = new System.Drawing.Size(0, 18);
            this.patientCardField.TabIndex = 22;
            // 
            // closeNoteButton
            // 
            this.closeNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeNoteButton.Location = new System.Drawing.Point(1703, 946);
            this.closeNoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeNoteButton.Name = "closeNoteButton";
            this.closeNoteButton.Size = new System.Drawing.Size(112, 24);
            this.closeNoteButton.TabIndex = 23;
            this.closeNoteButton.Text = "Закрыть";
            this.closeNoteButton.UseVisualStyleBackColor = true;
            this.closeNoteButton.Click += new System.EventHandler(this.closeNoteButton_Click);
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.closeNoteButton);
            this.Controls.Add(this.patientCardField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewCard);
            this.Controls.Add(this.exitButtom);
            this.Controls.Add(this.medicalField);
            this.Controls.Add(this.doctorNameField);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewPriem);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoctorsForm";
            this.Text = "DoctorsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridViewPriem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox descField;
        private System.Windows.Forms.MaskedTextBox diagnosisField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox appointmentField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox doctorNameField;
        private System.Windows.Forms.ComboBox medicalField;
        private System.Windows.Forms.MaskedTextBox pressureField;
        private System.Windows.Forms.MaskedTextBox temperaturaField;
        private System.Windows.Forms.TextBox idPatientField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox patientField;
        private System.Windows.Forms.Button exitButtom;
        private System.Windows.Forms.DataGridView dataGridViewCard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label patientCardField;
        private System.Windows.Forms.Button closeNoteButton;
    }
}