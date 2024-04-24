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
using System.Net;
using System.Reflection;
using Microsoft.VisualBasic;

namespace medicalProject2
{
    public partial class PatientsForm1 : Form
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
        string SelectedDate;
        string SelectedTime;
        int selectedRow;
        int selectedRowDoc;//вся выбранная строка в поле таблицы врачей

        public PatientsForm1()
        {

            InitializeComponent();
            //selectedDateBox.DateChanged += selectedDateBox_DateChanged;
            SelectedDate = dateTimePicker1.Value.ToShortDateString();
            SelectedTime = dateTimePicker1.Value.ToShortTimeString();
            //ClearDoc();
            labelMed.Text = DataBank.name_medical;
            idField.Visible = false;

            CreateColumn();//создаем таблицу
            RefreshDataGrid(dataGridViewPatients);//выводим в нее данные из бд
            CreateColumnDoc();
            RefreshDataGridDoc(dataGridViewDoctors);
            CreateColumnTalon();
            //RefreshDataGridTalon(dataGridViewTalon);
            panelAddPatient.Visible = false;
            groupBoxAddPatient.Visible = false;
            tableLayoutPanel3.RowCount = 1;
            panelUpdatePatient.Visible = true;
            LoadComboBox($"select distinct id_profile, profile_name from employees join doctors_profiles on id_profile = doctor_profile where profile_name != '' and place_of_work ='{DataBank.id_medical}'", "profile_name", "id_profile", this.doctorCategoryField);//выбираем в выпадающий список только те профили, которые есть у врачей работающих именно в этом учреждении
        }


        private void CreateColumn()
        {

            dataGridViewPatients.Columns.Add("id_patient", "КОД КАРТЫ");
            dataGridViewPatients.Columns.Add("name_patient", "ФИО ПАЦИЕНТА");
            dataGridViewPatients.Columns.Add("date_of_birth", "ДАТА РОЖДЕНИЯ");
            dataGridViewPatients.Columns.Add("phone_num", "НОМЕР ТЕЛЕФОНА");
            dataGridViewPatients.Columns.Add("home_address", "ДОМАШНИЙ АДРЕС");
            dataGridViewPatients.Columns.Add("IsNew", String.Empty);
            dataGridViewPatients.Columns[0].Width = 80;
            dataGridViewPatients.Columns[1].Width = 250;
            /* dataGridViewPatients.Columns[2].Width = 120;
             dataGridViewPatients.Columns[3].Width = 140;
             dataGridViewPatients.Columns[4].Width = 280;*/
            dataGridViewPatients.Columns[5].Visible = false;
        }
        protected void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {

            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDateTime(2).ToShortDateString(), record.GetString(3), record.GetString(4));

        }
        private void RefreshDataGrid(DataGridView dgw)
        {

            dgw.Rows.Clear();

            string queryString = "SELECT id_patient,concat_ws(' ',first_name,last_name,surname) as name_patient,date_of_birth,phone_num,home_address FROM patients  ";
            SqlCommand command = new SqlCommand(queryString, dbM.getConnection());
            dbM.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    ReadSingleRow(dgw, reader);
                }
            }
            catch
            {
                //можно  здесь вывести текст ошибки
            }
            finally
            {
                if (reader != null && reader.IsClosed)//если ридер создан и открыт
                {
                    reader.Close();
                }
            }
            dbM.closeConnection();
        }

        private void ClearFieldu()
        {
            uFirstNameField.Text = string.Empty;
            uLastNameField.Text = string.Empty;
            uSurnameField.Text = string.Empty;
            uDateBField.Text = string.Empty;
            uNumPhoneField.Text = string.Empty;
            uStreetField.Text = string.Empty;
            uHouseField.Text = string.Empty;
            uEpartField.Text = string.Empty;
        }
        private void ClearFielda()
        {
            aFirstNameField.Text = string.Empty;
            aLastNameField.Text = string.Empty;
            aSurnameField.Text = string.Empty;
            aDateBField.Text = string.Empty;
            aPhoneField.Text = string.Empty;
            aStreetField.Text = string.Empty;
            aHomeField.Text = string.Empty;
            aEpartFeild.Text = string.Empty;
            aPasportField.Text = string.Empty;
        }

        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DataGridViewRow row = dataGridViewPatients.Rows[selectedRow];//смотрим какой индекс у поля
                //проходим по полям

                //при нажатии на поле заполняются поля
                var selectedRovIndex = dataGridViewPatients.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса

                idField.Text = row.Cells[0].Value.ToString();

                string fio = row.Cells[1].Value.ToString();
                string[] fiO = fio.Split(' ');
                uFirstNameField.Text = fiO[0];
                if (fiO.Count() > 1)
                {

                    string lastName = fiO[1];
                    uLastNameField.Text = lastName;
                    string surname = fiO[2];
                    uSurnameField.Text = surname;
                }
                uDateBField.Text = row.Cells[2].Value.ToString();
                uNumPhoneField.Text = row.Cells[3].Value.ToString();
                string addr = row.Cells[4].Value.ToString();
                addr = addr.Replace('-', ' ');//меняем тире на пробел
                string[] addR = addr.Split(' ');
                uStreetField.Text = addR[0];

                if (addR.Length == 2)
                {
                    uHouseField.Text = addR[1];
                    uEpartField.Text = "";
                }
                if (addR.Length > 2)
                {
                    uHouseField.Text = addR[1];
                    uEpartField.Text = addR[2];
                }
                if (addR.Length == 1)
                {
                    uHouseField.Text = "";
                    uEpartField.Text = "";
                }
            }
        }

        private void change()
        {
            var selectedRovIndex = dataGridViewPatients.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса
            var id = idField.Text;
            var firstname = uFirstNameField.Text + " " + uLastNameField.Text + " " + uSurnameField.Text;
            var phoneNum = uNumPhoneField.Text;
            var address = "";
            if (uEpartField.Text != "")
            {
                address = uStreetField.Text + " " + uHouseField.Text + "-" + uEpartField.Text;
            }
            else
            {
                address = uStreetField.Text + " " + uHouseField.Text;
            }

            var dateB = uDateBField.Text;
            //DateTime date = new DateTime();

            //проверяем не пустая ли строка с определенным индексом в нулевом столбце
            if (dataGridViewPatients.Rows[selectedRovIndex].Cells[0].Value.ToString() != string.Empty)
            {

                //присваиваются значения текстбоксов нижней формы строке , то есть меняем данные в грид таблице
                dataGridViewPatients.Rows[selectedRovIndex].SetValues(id, firstname, dateB, phoneNum, address);//потом вернуть
                dataGridViewPatients.Rows[selectedRovIndex].Cells[5].Value = RowState.Modifieted;

            }
        }

        private void update()//метод в котором проверяем состояние строки
        {
            dbM.openConnection();

            for (int index = 0; index < dataGridViewPatients.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewPatients.Rows[index].Cells[5].Value;//передаем поле, где находится индекс

                if (rowState == RowState.Existed)
                    continue;
                //------------------------------------------------------------

                //------------изменение данных-----------------------
                if (rowState == RowState.Modifieted)
                {
                    var id = dataGridViewPatients.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridViewPatients.Rows[index].Cells[1].Value.ToString();
                    string[] fullname = name.Split(' ');
                    string firstName = fullname[0];
                    string lastName = fullname[1];
                    string surname = fullname[2];

                    var dateB = dataGridViewPatients.Rows[index].Cells[2].Value.ToString();
                    var phNum = dataGridViewPatients.Rows[index].Cells[3].Value.ToString();
                    var address = dataGridViewPatients.Rows[index].Cells[4].Value.ToString();

                    //заносим измененные данные в базу данных
                    var changeQuery = $" update patients set first_name  = '{firstName}',last_name = '{lastName}', surname = '{surname}', date_of_birth = '{dateB}',phone_num = '{phNum}',home_address = '{address}' where id_patient = '{id}'";

                    var command = new SqlCommand(changeQuery, dbM.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Изменения успешно сохранены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid(dataGridViewPatients);
                    ClearFieldu();
                }
            }
            dbM.closeConnection();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT id_patient,concat_ws(' ',first_name,last_name,surname) as namet,date_of_birth,phone_num,home_address FROM patients where concat(id_patient,first_name,last_name,surname,date_of_birth,phone_num,home_address)like '%" + searchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, dbM.getConnection());

            dbM.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            try {
                while (reader.Read())
                {
                    ReadSingleRow(dgw, reader);//построчно выводим
                }
            }
            catch { }
            finally
            {
                if (reader != null && reader.IsClosed)//если ридер создан и открыт
                {
                    reader.Close();
                }
                dbM.closeConnection();
            }




        }

        private void empButton_Click(object sender, EventArgs e)
        {
            EmForm em = new EmForm();
            this.Hide();
            em.ShowDialog();
            this.Show();
        }

        private void docButton_Click(object sender, EventArgs e)
        {
            DocForm doctors = new DocForm();
            this.Hide();
            doctors.ShowDialog();
            this.Show();
        }

        private void medButton_Click(object sender, EventArgs e)
        {
            MedForm medical = new MedForm();
            this.Hide();
            medical.ShowDialog();
            this.Show();
        }






        private void buttonadd_Click(object sender, EventArgs e)
        {
            buttonadd.Visible = false;
            groupBoxUpPatient.Visible = false;
            panelUpdatePatient.Visible = false;
            tableLayoutPanel11.ColumnCount = 1;
            groupBoxAddPatient.Height = 350;
            groupBoxAddPatient.Visible = true;
            panelAddPatient.Height = 350;
            panelAddPatient.Visible = true;
        }

        private void buttonup_Click(object sender, EventArgs e)
        {
            groupBoxAddPatient.Visible = false;
            panelAddPatient.Visible = false;
            tableLayoutPanel11.ColumnCount = 1;
            groupBoxUpPatient.Visible = true;
            panelUpdatePatient.Visible = true;
        }



        private void LoadComboBox(string query, string name, string value, ComboBox box)
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

        /*select concat_ws(' ',first_name,last_name,surname) as fullname from employees where position_job = 2 and place_of_work =3*/
        // -----------------при клике на форму с пациентами--------------------

        private void dataGridViewPatients_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DataGridViewRow row = dataGridViewPatients.Rows[selectedRow];//смотрим какой индекс у поля
                                                                             //проходим по полям

                //при нажатии на поле заполняются поля
                var selectedRovIndex = dataGridViewPatients.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса

                idField.Text = row.Cells[0].Value.ToString();
                string fio = row.Cells[1].Value.ToString();
                string[] fiO = fio.Split(' ');
                uFirstNameField.Text = fiO[0];
                if (fiO.Count() > 1)
                {
                    string lastName = fiO[1];
                    uLastNameField.Text = lastName;
                    string surname = fiO[2];
                    uSurnameField.Text = surname;
                }

                uDateBField.Text = row.Cells[2].Value.ToString();
                uNumPhoneField.Text = row.Cells[3].Value.ToString();
                string fulladdress = row.Cells[4].Value.ToString();
                string[] address = fulladdress.Split(' ');
                uStreetField.Text = address[0];
                string[] hause_epart = address[1].Split('-');
                if (hause_epart.Count() > 1)
                    uEpartField.Text = hause_epart[1];
                uHouseField.Text = hause_epart[0];
            }

        }
        private void buttonup_Click_1(object sender, EventArgs e)
        {
            panelAddPatient.Visible = false;
            tableLayoutPanel11.ColumnCount = 1;
            panelUpdatePatient.Visible = true;
        }


        private void searchField_TextChanged_1(object sender, EventArgs e)
        {
            Search(dataGridViewPatients);
        }
        //-----------------------отрисовка таблицы врачей-------------------------------------------------------------
        private void CreateColumnDoc()
        {

            dataGridViewDoctors.Columns.Add("id_doc", "К");
            dataGridViewDoctors.Columns.Add("name_doc", "ФИО ВРАЧА");
            dataGridViewDoctors.Columns.Add("IsNew", String.Empty);
            dataGridViewDoctors.Columns[0].Visible = false;
            dataGridViewDoctors.Columns[2].Visible = false;

            //dataGridViewDoctors.Columns[2].Visible = false;
            // dataGridViewDoctors.Columns[0].Visible = false;
            //dataGridViewDoctors.Columns[1].Width = 400;
        }
        protected void ReadSingleRowDoc(DataGridView dgw, IDataRecord record)
        {

            try
            {
                dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifietedNew);
                // MessageBox.Show("я рисуую...");
            }
            catch
            {
                MessageBox.Show("Упс...Что-то пошло не так...");
            }

        }

        private void ClearDoc()
        {
            doctorCategoryField.Text = "";
            doctorCategoryField.SelectedValue = 0;

        }
        private void RefreshDataGridDoc(DataGridView dgw)
        {
            dgw.Rows.Clear();
            //-------------------выбор врача-----------------------


            // MessageBox.Show("выбран врач - " + doctorCategoryField.Text + "и его id= " + doctorCategoryField.SelectedValue);
            string queryString = $"SELECT id_employee,concat_ws(' ',first_name,last_name,surname),doctor_profile as name_doc from employees where doctor_profile = '{doctorCategoryField.SelectedValue}' and place_of_work = '{DataBank.id_medical}' ";
            SqlCommand command = new SqlCommand(queryString, dbM.getConnection());
            dbM.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    ReadSingleRowDoc(dgw, reader);
                }
            }
            finally {
                if (reader != null && reader.IsClosed)//если ридер создан и открыт
                {
                    reader.Close();
                }
            }


            dbM.closeConnection();
        }
        private void doctorCategoryField_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            RefreshDataGridDoc(dataGridViewDoctors);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            change();
            update();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dbM.openConnection();

            //объявляем переменные, заполняем значениями из полей
            var firstName = aFirstNameField.Text;
            var lastName = aLastNameField.Text;
            var surname = aSurnameField.Text;
            var phoneNum = aPhoneField.Text;
            var address = "";
            if (aEpartFeild.Text != "")
            {
                address = aStreetField.Text + " " + aHomeField.Text + "-" + aEpartFeild.Text;
            }
            else
            {
                address = aStreetField.Text + " " + aHomeField.Text;
            }

            var pasport = aPasportField.Text;
            var dateB = "";
            DateTime date = new DateTime();

            if (DateTime.TryParse(aDateBField.Text, out date))
            {
                dateB = aDateBField.Text;
                try
                {
                    var addQuery = $"insert into patients(first_name,last_name,surname, date_of_birth,phone_num,home_address,pasport) values ('{firstName}','{lastName}','{surname}','{dateB}','{phoneNum}','{address}','{pasport}')";
                    var command = new SqlCommand(addQuery, dbM.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid(dataGridViewPatients);
                    panelAddPatient.Visible = false;
                    tableLayoutPanel3.RowCount = 1;
                    panelUpdatePatient.Visible = true;
                    ClearFielda();
                }
                catch
                {
                    MessageBox.Show("Пациент с таким номером паспорта уже есть в базе!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                DialogResult dialog = MessageBox.Show("Вы не заполнили все поля. Хотите продолжить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    var addQuery = $"insert into patients(first_name,last_name,surname, date_of_birth,phone_num,home_address,pasport) values ('{firstName}','{lastName}','{surname}','{dateB}','{phoneNum}','{address}','{pasport}')";
                    var command = new SqlCommand(addQuery, dbM.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid(dataGridViewPatients);
                    groupBoxAddPatient.Visible = false;
                    panelAddPatient.Visible = false;
                    tableLayoutPanel11.ColumnCount = 1;
                    groupBoxUpPatient.Visible = true;
                    panelUpdatePatient.Visible = true;
                    buttonadd.Visible = true;
                    ClearFielda();

                }
                else
                {
                    groupBoxAddPatient.Visible = false;
                    panelAddPatient.Visible = false;
                    tableLayoutPanel11.ColumnCount = 1;
                    groupBoxUpPatient.Visible = true;
                    panelUpdatePatient.Visible = true;
                    buttonadd.Visible = true;
                    ClearFielda();
                }
            }
            dbM.closeConnection();

        }
        //--------------------позаз доступных талонов----------------

        private void CreateColumnTalon()
        {
            dataGridViewTalon.Columns.Add("id_time", "id");
            dataGridViewTalon.Columns.Add("name_times", "ВРЕМЯ ПРИЕМА");
            dataGridViewTalon.Columns.Add("IsNew", String.Empty);
            dataGridViewTalon.Columns[0].Visible = false;
            dataGridViewTalon.Columns[2].Visible = false;
        }
        protected void ReadSingleRowTalon(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetValue(1), RowState.ModifietedNew);
        }
        private void RefreshDataGridTalon(DataGridView dgw)
        {

            dgw.Rows.Clear();
            //MessageBox.Show(selectedRowDoc.ToString());

            if (selectedRowDoc >= 0)//если поле есть в таблице
            {
                DataGridViewRow row = dataGridViewDoctors.Rows[selectedRowDoc];
                if (row != null)
                {
                    int id = int.Parse(dataGridViewDoctors.Rows[selectedRowDoc].Cells[0].Value.ToString());//проходим по полям
                    //получаем смену и график врача на выбранную дату////
                    string query1 = $"select id_record,name_shift from  records_doctor join shifts on shifts.id_shift = records_doctor.id_shift where id_employee = '{id}'  and date= '{SelectedDate}'";


                    SqlCommand command1 = new SqlCommand(query1, dbM.getConnection());
                    dbM.openConnection();
                    SqlDataReader reader = command1.ExecuteReader();
                    reader.Read();
                    int idRecord = 0;
                    int Shift = 0;
                    try
                    {
                        if (reader.HasRows)
                        {
                            Object id_record = reader[0].ToString();
                            Object id_shift = reader[1].ToString();
                            idRecord = int.Parse(id_record.ToString());
                            Shift = int.Parse(id_shift.ToString());
                        }
                    }
                    finally { reader.Close(); }

                    if (Shift != 0 && idRecord != 0)
                    {
                        string query2 = $"select id_time, name_time from times where shift = '{Shift}' and id_time not in (select id_time from records_doctor_patient where id_recodrd_doctor = '{idRecord}')";
                        SqlCommand command2 = new SqlCommand(query2, dbM.getConnection());
                        dbM.openConnection();
                        SqlDataReader reader2 = command2.ExecuteReader();
                       
                        try
                        {
                            if (reader2.HasRows)
                            {
                                while (reader2.Read())
                                ReadSingleRowTalon(dgw, reader2);
                            }
                        }
                        finally { reader2.Close(); }
                    }

                   
                }

            }

            dbM.closeConnection();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SelectedDate = dateTimePicker1.Value.ToString();
            AddSifts();
            RefreshDataGridTalon(dataGridViewTalon);
        }

        //---------------------------нажатае на таблицу врачей------------------------
        private void dataGridViewDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            selectedRowDoc = e.RowIndex;
            //MessageBox.Show("selected = " + selectedRowDoc);
            if (e.RowIndex >= 0)
            {
                AddSifts();
                //RefreshDataGridTalon(dataGridViewTalon);
            }
        }

        private void AddSifts()
        {
            //выврать все из time_of_work где id_doctor == ид выбранный доктор и выбранную дату 
            //если запись есть, то показываем свободные талоны
            //если записи нет, то рандомно выбираем смену и создаем time_of_work для этого доктора
            //MessageBox.Show("Выбран врач "+ )


            DataGridViewRow row = dataGridViewDoctors.Rows[selectedRowDoc];//смотрим какой индекс у поля
            string idDoctor = row.Cells[0].Value.ToString();
            string nameDoc = row.Cells[1].Value.ToString();
            //MessageBox.Show("Выбран врач - " + nameDoc + " и у него id = " + idDoctor + " выбрана дата " + SelectedDate + " время обращения = " + SelectedTime);
            dbM.openConnection();
            string queryStr = $"select * from records_doctor where id_employee = '{idDoctor}' and date = '{SelectedDate}'";

            SqlCommand command = new SqlCommand(queryStr, dbM.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            // MessageBox.Show(table.Rows.Count.ToString());


            if (table.Rows.Count > 0)
            {
                //MessageBox.Show("на эту дату у врача записи есть");
                RefreshDataGridTalon(dataGridViewTalon);

            }
            else
            {
                Random rnd = new Random();
                int id_shift = rnd.Next(1, 3);
                try
                {
                    if (id_shift == 3) id_shift = 2;

                    string addQuery = $"insert into records_doctor(id_shift,id_employee,date) values ('{id_shift}','{idDoctor}','{SelectedDate}')";
                    command = new SqlCommand(addQuery, dbM.getConnection());
                    if (command.ExecuteNonQuery() == 1)
                    {
                        // MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGridTalon(dataGridViewTalon);
                    }



                    // MessageBox.Show("запись не добавлена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally { }
            }

            dbM.closeConnection();

        }

        private void dataGridViewTalon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dbM.openConnection();
            int idTime = 0;
            int idRecord = 0;
            int idPatient=0;
            int idShift=0;

            int timeIndex = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DataGridViewRow row = dataGridViewTalon.Rows[timeIndex];
                idTime =int.Parse( row.Cells[0].Value.ToString());
                MessageBox.Show(idTime.ToString());
                
            }
                DialogResult dialog = MessageBox.Show("Добавить пациента на это время?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {

                
                string result = Microsoft.VisualBasic.Interaction.InputBox("Введите код карты пациента:"," ");
                if(result != "")
                {
                   
                    try
                    {

                        //-------------------получаем пациента------------------
                        idPatient = int.Parse(result);
                        string queryStr = $"select * from patients where id_patient = '{idPatient}'";
                        SqlCommand command = new SqlCommand(queryStr, dbM.getConnection());
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            DataGridViewRow row = dataGridViewDoctors.Rows[selectedRowDoc];

                            string idDoctor = row.Cells[0].Value.ToString();
                         
                            int id = int.Parse(idDoctor);
                            //MessageBox.Show(" у него id = " + idDoctor + " выбрана дата " + SelectedDate + " время обращения = " + SelectedTime);
                         //-------------------------получаем ид талона и смену врача------------------ 
                            queryStr = $"select id_record,id_shift from records_doctor where date = '{SelectedDate}' and id_employee = '{id}'";
                            SqlCommand command2 = new SqlCommand(queryStr, dbM.getConnection());
                           
                            SqlDataReader reader = command2.ExecuteReader();
                            MessageBox.Show(SelectedDate);
                            reader.Read();
                            try
                            {

                                if (reader.HasRows)
                                {
                                    Object id_record = reader[0].ToString();
                                    Object id_shift = reader[1].ToString();
                                    idRecord = int.Parse(id_record.ToString());
                                    idShift = int.Parse(id_shift.ToString());

                                }
                            }
                            finally
                            {
                                reader.Close();
                               
                            } 
                        }
                        else
                        {
                            MessageBox.Show("такого пациента нет");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("номер карты пациента введен некорректно");
                    }
                }
                if(idRecord != 0 && idTime != 0 && idPatient != 0)
                {
                    
                    string queryStr = $"insert into records_doctor_patient(id_patient,id_time,id_recodrd_doctor) values ('{idPatient}','{idTime}','{idRecord}')";
                  
                   SqlCommand command = new SqlCommand(queryStr, dbM.getConnection());
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGridTalon(dataGridViewTalon);
                    }
                    else
                    {
                        MessageBox.Show("запись не добавлена");
                    }

                }
                else
                {
                    MessageBox.Show("запись не добавлена. в переменных нет значений");
                }
               
            }
            dbM.closeConnection();
        }

        private void labelMed_Click(object sender, EventArgs e)
        {

        }
    }
}
/*
  
        

select * from patients where id_patient = 7
 
 */