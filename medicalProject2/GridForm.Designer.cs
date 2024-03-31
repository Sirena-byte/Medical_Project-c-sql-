namespace medicalProject2
{
    partial class GridForm
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
            this.tab2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.NewsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priceField = new System.Windows.Forms.TextBox();
            this.postavkaField = new System.Windows.Forms.TextBox();
            this.countField = new System.Windows.Forms.TextBox();
            this.typeProductField = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchField = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.restartButtonn = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButtonn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).BeginInit();
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
            this.tab2.Size = new System.Drawing.Size(800, 561);
            this.tab2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вкладка 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(454, 332);
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
            this.panel3.Location = new System.Drawing.Point(458, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 153);
            this.panel3.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 106);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(177, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить запись";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(12, 75);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(177, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Изменить запись";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 46);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(177, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // NewsButton
            // 
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
            this.panel2.Controls.Add(this.priceField);
            this.panel2.Controls.Add(this.postavkaField);
            this.panel2.Controls.Add(this.countField);
            this.panel2.Controls.Add(this.typeProductField);
            this.panel2.Controls.Add(this.idField);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(9, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 197);
            this.panel2.TabIndex = 2;
            // 
            // priceField
            // 
            this.priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceField.Location = new System.Drawing.Point(164, 166);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(192, 24);
            this.priceField.TabIndex = 11;
            // 
            // postavkaField
            // 
            this.postavkaField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postavkaField.Location = new System.Drawing.Point(164, 138);
            this.postavkaField.Name = "postavkaField";
            this.postavkaField.Size = new System.Drawing.Size(192, 24);
            this.postavkaField.TabIndex = 10;
            // 
            // countField
            // 
            this.countField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countField.Location = new System.Drawing.Point(164, 110);
            this.countField.Name = "countField";
            this.countField.Size = new System.Drawing.Size(192, 24);
            this.countField.TabIndex = 9;
            // 
            // typeProductField
            // 
            this.typeProductField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeProductField.Location = new System.Drawing.Point(164, 82);
            this.typeProductField.Name = "typeProductField";
            this.typeProductField.Size = new System.Drawing.Size(192, 24);
            this.typeProductField.TabIndex = 8;
            // 
            // idField
            // 
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idField.Location = new System.Drawing.Point(164, 54);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(192, 24);
            this.idField.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Поставщик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 265);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.searchField);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.restartButtonn);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 57);
            this.panel1.TabIndex = 0;
            // 
            // searchField
            // 
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchField.Location = new System.Drawing.Point(571, 10);
            this.searchField.Multiline = true;
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(210, 35);
            this.searchField.TabIndex = 3;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Image = global::medicalProject2.Properties.Resources.loupe;
            this.searchButton.Location = new System.Drawing.Point(525, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 40);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            // 
            // restartButtonn
            // 
            this.restartButtonn.Image = global::medicalProject2.Properties.Resources.restart;
            this.restartButtonn.Location = new System.Drawing.Point(455, 5);
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
            this.clearButton.Location = new System.Drawing.Point(389, 5);
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
            this.tabPage2.Size = new System.Drawing.Size(792, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вкладка 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.tab2);
            this.Name = "GridForm";
            this.Text = "GridForm";
            this.Load += new System.EventHandler(this.GridForm_Load);
            this.tab2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartButtonn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox restartButtonn;
        private System.Windows.Forms.PictureBox clearButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button NewsButton;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.TextBox postavkaField;
        private System.Windows.Forms.TextBox countField;
        private System.Windows.Forms.TextBox typeProductField;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}