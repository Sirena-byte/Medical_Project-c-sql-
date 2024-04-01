using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace medicalProject2
{
    public partial class AddMedicalForm : Form
    {

        MedicalDB dbM = new MedicalDB();
        public AddMedicalForm()
        {
         

            // DpiFix();
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddMedicalForm_Load(object sender, EventArgs e)
        {
           //загрузка списков в выпадающий список
            this.employeesTableAdapter.Fill(this.medical_project_DBDataSet.employees);
            this.categoryTableAdapter.Fill(this.medical_project_DBDataSet.category);
            this.ClearField();
           

        }

        //метод очищает поля
        private void ClearField()
        {
            categoryField.Text = "";
            nameField.Text = "";
            streetField.Text = "";
            hauseField.Text = "";
            phoneField.Text = "";
            supervisorField.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dbM.openConnection();

            //объявляем переменные, заполняем значениями из полей
            var name = nameField.Text;
            int category = (int)categoryField.SelectedValue;
            var address = streetField.Text + "-" + hauseField.Text;
            int phone;
            int supervisor = (int)supervisorField.SelectedValue;

            //проверка на тип
            if (int.TryParse(phoneField.Text, out phone))
            {
                var addQuery = $"insert into medical_inst (id_category, name_inst,phone_inst, address_inst, supervisor_id) values ('{category}','{name}','{phone}','{address}','{supervisor}')";
                var command = new SqlCommand(addQuery, dbM.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Номер телефона введен в неверном формате! Номер телефона должен состоять только из цифр.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dbM.closeConnection();
        }
        //событие для проверки значения в комбо боксе
       /* private void supervisorField_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(supervisorField.SelectedValue.ToString() + " "+ supervisorField.SelectedValue.GetType());
        }

        private void categoryField_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(categoryField.SelectedValue.ToString() + " " + categoryField.SelectedValue.GetType());
        }*/


    }
}
