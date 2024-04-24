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
    public partial class DocForm : Form
    {
        enum RowState
        {
            Existed,
            New,
            Modifieted,
            ModifietedNew,
            Deleted
        }
        int count = 0;

        MedicalDB dbM = new MedicalDB();
        int selectedRow;
        public DocForm()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            closeNoteButton.Visible = false;
        }

        private void DocForm_Load(object sender, EventArgs e)
        {
            CreateColumn();//создаем таблицу
            RefreshDataGrid(dataGridViewPriem);//выводим в нее данные из бд
            CreateColumnCard();
            medicalInstField.Text = DataBank.name_medical;
            fallNameDocField.Text = DataBank.full_name_user + " " + DataBank.profession_user + "-" + DataBank.profile_user;
        }
        private void LoadComboBox(string query, string name, string value, ComboBox box) //метод заполнения комбо боксов
        {
            dbM.openConnection();

            var command = new SqlCommand(query, dbM.getConnection());
            command.ExecuteNonQuery();
            command.CommandType = CommandType.Text;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            box.DisplayMember = name;
            box.ValueMember = value;
            box.DataSource = table;

            dbM.closeConnection();

        }

        private void medicalField_SelectedIndexChanged(object sender, EventArgs e)//выбираем врачей данной больницы
        {
        }

        public static string AddPatient(string id) //поиск пациента по коду пациента(id)
        {
            string namePatient = "";

            if (int.TryParse(id, out int newId))
            {

                MedicalDB dbM = new MedicalDB();
                dbM.openConnection();
                string queryString = $"SELECT concat_ws(' ',first_name,last_name,surname)as patient_name FROM patients where id_patient = '{id}'";
                SqlCommand command = new SqlCommand(queryString, dbM.getConnection());

                Object result = command.ExecuteScalar();
                if (result != null)
                {
                    namePatient = result.ToString();
                    dbM.closeConnection();
                    return namePatient;

                }
            }
            else if (id != "")
            {
                MessageBox.Show("Код пациента введен не корректно. Попробуйте еще раз!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;

        }
        private void ClearField()//очистка полей формы текущего приема
        {
            idPatientField.Text = "";
            descField.Text = "";
            temperaturaField.Text = "";
            pressureField.Text = "";
            diagnosisField.Text = "";
            appointmentField.Text = "";
        }

        private void idPatientField_TextChanged(object sender, EventArgs e)//клик по полю (поиск пациента по коду карты)
        {
            patientField.Text = AddPatient(idPatientField.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dbM.openConnection();
            if (idPatientField.Text == "" ||/* doctorNameField.Text == ""||*/ descField.Text == "" || temperaturaField.Text == "" || pressureField.Text == "" || diagnosisField.Text == "" || appointmentField.Text == "")
            {
                MessageBox.Show("Не заполнены все поля! Проверьте данные и попробуйте снова!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string date_of_visit = dateTimePicker.Value.ToString();
                int id_patient = Convert.ToInt32(idPatientField.Text);
                //int id_doctor = Convert.ToInt32(doctorNameField.SelectedValue);
                int id_doctor = DataBank.id_user;
                string inspector = descField.Text;
                string body_temperature = temperaturaField.Text;
                string pressure = pressureField.Text;
                string diagnosis = diagnosisField.Text;
                string appointment = appointmentField.Text;

                //в запросе закомментирован врач
                var addQuery = $"insert into visiting_sheets (date_of_visit,id_patient,id_doctor, inspector, body_temperature,pressure,diagnosis,appointment) values ('{date_of_visit}','{id_patient}','{DataBank.id_user}','{inspector}','{body_temperature}','{pressure}','{diagnosis}','{appointment}')";
                var command = new SqlCommand(addQuery, dbM.getConnection());
                if (command.ExecuteNonQuery() == 1)
                    { }
                else
                    MessageBox.Show("Запись не добавлена...", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearField();
                dbM.closeConnection();
                RefreshDataGrid(dataGridViewPriem);
            }
        }//добавление записи приема(данные пациента о его здоровье)

        private void CreateColumn() //рисуем таблицу с проведенными приемами
        {
            dataGridViewPriem.Columns.Add("IsNewCount", "Порядковый номер");
            dataGridViewPriem.Columns.Add("id_patient", "Код карты");
            dataGridViewPriem.Columns.Add("fio", "ФИО пациента");
            dataGridViewPriem.Columns.Add("IsNew", String.Empty);
            dataGridViewPriem.Columns.Add("id_sheet", "ид приема");

            dataGridViewPriem.Columns[0].Width = 100;
            dataGridViewPriem.Columns[1].Width = 100; ;
            dataGridViewPriem.Columns[2].Width = 250;
            dataGridViewPriem.Columns[3].Visible = false;
            dataGridViewPriem.Columns[4].Visible = false;

        }
        protected void ReadSingleRow(DataGridView dgw, IDataRecord record)//получение данных из бд для заполнения таблицы приема
        {
            dgw.Rows.Add(count, record.GetInt32(0), record.GetString(1), RowState.ModifietedNew, record.GetInt32(2));
        }

        private void RefreshDataGrid(DataGridView dgw) //метод выводит данные в таблицу приема (заполняет поля)
        {
            
            dgw.Rows.Clear();
            string queryString = $"SELECT visiting_sheets.id_patient, concat_ws(' ',first_name,last_name,surname) as fio,id_sheet FROM visiting_sheets JOIN patients ON visiting_sheets.id_patient = patients.id_patient where date_of_visit = '{dateTimePicker.Value}' and id_doctor = '{DataBank.id_user}'";


            SqlCommand command = new SqlCommand(queryString, dbM.getConnection());
            dbM.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                count++;
                ReadSingleRow(dgw, reader);
            }
            count = 0;//сбрасываем счетчик
            reader.Close();
            dbM.closeConnection();

        }

        private void dataGridViewPriem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //действия при клике по таблице приема(выводит данные в карту пациента при клике на него в таблице приема
        {


            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                selectedRow = e.RowIndex;//получаем индекс строки на которой находимся
                int id = 0;

                DataGridViewRow row = dataGridViewPriem.Rows[selectedRow];//смотрим какой индекс у поля
                //проходим по полям
                //при нажатии на поле заполняются поля
                var selectedRovIndex = dataGridViewPriem.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса
                string str = row.Cells[1].Value.ToString();

                id = Convert.ToInt32(str.ToString());


                RefreshDataGridCard(dataGridViewCard, id);
                patientCardField.Text = row.Cells[2].Value.ToString();
            }

        }
        //-------------------------------вывод таблицы карта пациента--------------------------------------
        private void CreateColumnCard()//метод рисует таблицу карты пациента
        {
            dataGridViewCard.Columns.Add("IsNewCount", "Порядковый номер");
            dataGridViewCard.Columns.Add("date_of_visit", "Дата приема");
            dataGridViewCard.Columns.Add("first_name", "Фамилия врача");
            dataGridViewCard.Columns.Add("profile_name", "Профиль врача");
            dataGridViewCard.Columns.Add("id_sheet", "Код приема");
            dataGridViewCard.Columns.Add("IsNew", String.Empty);


            dataGridViewCard.Columns[0].Width = 100;
            dataGridViewCard.Columns[1].Width = 100; ;
            dataGridViewCard.Columns[2].Width = 120;
            dataGridViewCard.Columns[3].Width = 130;
            dataGridViewCard.Columns[4].Visible = false;
            dataGridViewCard.Columns[5].Visible = false;

        }
        protected void ReadSingleRowCard(DataGridView dgw, IDataRecord record)//метод выводит данные в таблицу карты пациента
        {
            dgw.Rows.Add(count, record.GetDateTime(0).ToShortDateString()/*отрезаем время*/, record.GetString(1), record.GetString(2), record.GetInt32(3), RowState.ModifietedNew);
        }

        private void RefreshDataGridCard(DataGridView dgw, int id) //метод выводит данные в таблицу с приемами по выбранному пациенту
        {
            dgw.Rows.Clear();
            
            string queryString = $"SELECT date_of_visit , employees.first_name , profile_name ,id_sheet FROM visiting_sheets JOIN employees ON visiting_sheets.id_doctor = employees.id_employee JOIN doctors_profiles ON doctors_profiles.id_profile = employees.doctor_profile JOIN patients ON patients.id_patient = visiting_sheets.id_patient WHERE visiting_sheets.id_patient = '{id}'";


            SqlCommand command = new SqlCommand(queryString, dbM.getConnection());
            dbM.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                count++;
                ReadSingleRowCard(dgw, reader);
            }
            count = 0;//сбрасываем счетчик
            reader.Close();
            dbM.closeConnection();


        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewPriem);
        }//при выборе даты заполняется таблица приема врача в этот день

        private void doctorNameField_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewPriem);
        }//при выборе доктора заполняется таблица приема этого врача

        private void dataGridViewCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DataGridViewRow row = dataGridViewCard.Rows[selectedRow];//смотрим какой индекс у поля
                //проходим по полям

                //при нажатии на поле заполняются поля
                var selectedRovIndex = dataGridViewCard.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса
                string str = row.Cells[4].Value.ToString();
                //MessageBox.Show(str.ToString());
                fillingOutTheFieldsPriem(str);
            }
        }

        //действия при клике по карте пациента для выбора записи
        private void fillingOutTheFieldsPriem(string id_priem)//заполнение полей при выборе записи приема
        {
            closeNoteButton.Visible = true;
            saveButton.Visible = false;
            if (int.TryParse(id_priem, out int newId))
            {

                MedicalDB dbM = new MedicalDB();
                dbM.openConnection();
                string queryString = $"SELECT date_of_visit,concat_ws(' ',employees.first_name,employees.last_name, employees.surname) as doc, concat_ws(' ',patients.first_name,patients.last_name,patients.surname) as pat,inspector,body_temperature,pressure,diagnosis,appointment, visiting_sheets.id_patient FROM visiting_sheets JOIN patients ON visiting_sheets.id_patient =patients.id_patient JOIN employees ON id_doctor = id_employee WHERE id_sheet ='{id_priem}'";
                SqlCommand command = new SqlCommand(queryString, dbM.getConnection());

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    dateTimePicker.Value = reader.GetDateTime(0);
                    //doctorNameField.Text = reader.GetString(1);
                    patientField.Text = reader.GetString(2);
                    descField.Text = reader.GetString(3);
                    temperaturaField.Text = reader.GetString(4);
                    pressureField.Text = reader.GetString(5);
                    diagnosisField.Text = reader.GetString(6);
                    appointmentField.Text = reader.GetString(7);
                    idPatientField.Text = Convert.ToString(reader.GetInt32(8));
                }
                reader.Close();
                dbM.closeConnection();
            }

        }

        private void closeNoteButton_Click(object sender, EventArgs e)
        {
            clearNote();
            closeNoteButton.Visible = false;
            saveButton.Visible = true;
           
        }

        private void clearNote()
        {
           // doctorNameField.Text = "";
            dateTimePicker.Text = "";
            patientField.Text = "";
            descField.Text = "";
            temperaturaField.Text = "";
            pressureField.Text = "";
            diagnosisField.Text = "";
            appointmentField.Text = "";
            idPatientField.Text = "";
        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
