using medicalProject2;
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
    public partial class AddPatientsForm : Form
    {
        enum RowState
        {
            Existed,
            New,
            Modifieted,
            ModifietedNew,
            Deleted
        }
        MedicalDB dbM = new MedicalDB();

        int selectedRow;
        public AddPatientsForm()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();

            CreateColumn();//создаем таблицу
            RefreshDataGrid(dataGridViewPatients);//выводим в нее данные из бд
        }

        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CreateColumn()
        {
            
            dataGridViewPatients.Columns.Add("id_patient", "Код мед.карты");
            dataGridViewPatients.Columns.Add("name_patient", "ФИО пациента");
            dataGridViewPatients.Columns.Add("date_of_birth", "Дата рождения");
            dataGridViewPatients.Columns.Add("phone_num", "Номер телефона");
            dataGridViewPatients.Columns.Add("home_address", "Домашний адрес");
            dataGridViewPatients.Columns.Add("IsNew", String.Empty);
            dataGridViewPatients.Columns[0].Width = 100;
            dataGridViewPatients.Columns[1].Width = 290;
            dataGridViewPatients.Columns[2].Width = 120;
            dataGridViewPatients.Columns[3].Width = 240;
            dataGridViewPatients.Columns[4].Width = 280;
            dataGridViewPatients.Columns[5].Visible = false;
        }
        protected void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1), record.GetDateTime(2).ToShortDateString(), record.GetString(3), record.GetString(4)
                , RowState.ModifietedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = "SELECT id_patient,concat_ws(' ',first_name,last_name,surname) as name_patient,date_of_birth,phone_num,home_address FROM patients  ";
            SqlCommand command = new SqlCommand(queryString, dbM.getConnection());
            dbM.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dbM.closeConnection();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            dbM.openConnection();

            //объявляем переменные, заполняем значениями из полей
            var firstName = aFirstNameField.Text;
            var lastName = aLastNameField.Text;
            var surname = aSurnameField.Text;
            var phoneNum = aPhoneField.Text;
            var address = aStreetField.Text + "-" + aHomeField.Text;
            var pasport = aPasportField.Text;
            var dateB = "";
            DateTime date = new DateTime();
            if (DateTime.TryParse(aDateBField.Text, out date))
            {
                dateB = aDateBField.Text;
                var addQuery = $"insert into patients(first_name,last_name,surname, date_of_birth,phone_num,home_address,pasport) values ('{firstName}','{lastName}','{surname}','{dateB}','{phoneNum}','{address}','{pasport}')";
                var command = new SqlCommand(addQuery, dbM.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ошибка");
            }
            dbM.closeConnection();
            RefreshDataGrid(dataGridViewPatients);
            ClearField();
        }
        private void ClearField()
        {
            aFirstNameField.Text = string.Empty;
            aLastNameField.Text = string.Empty;
            aSurnameField.Text = string.Empty;
            aDateBField.Text = string.Empty;
            aPhoneField.Text = string.Empty;
            aStreetField.Text = string.Empty;
            aHomeField.Text = string.Empty;
            aPasportField.Text = string.Empty;
        }















        private void medButton_Click(object sender, EventArgs e)
        {
            MedicalForm medical = new MedicalForm();
            medical.Show();
        }

        private void empButton_Click(object sender, EventArgs e)
        {
            EmployeesForm employees = new EmployeesForm();
            employees.Show();
        }

        private void docButton_Click(object sender, EventArgs e)
        {
            DoctorsForm doctors = new DoctorsForm();
            doctors.Show();
        }

        
    }
}

